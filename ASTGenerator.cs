using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Tree;

namespace MiniC
{
    public class ASTGenerator : MiniCBaseVisitor<int>
    {
        private CCompileUnit m_root;
        public ASTElement MRoot => m_root;
        private Stack<(ASTElement, int)> m_contextData = new Stack<(ASTElement, int)>();

        public override int VisitCompileUnit(MiniCParser.CompileUnitContext context)
        {
            CCompileUnit newNode = new CCompileUnit();
            m_root = newNode;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_BODY.
            m_contextData.Push((newNode, CCompileUnit.CT_BODY));
            // We visit the child for statements.
            foreach (var child in context.statement())
            {
                Visit(child);
            }
            // We pop the tuple we added before.
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_FUNCTION_BODY.
            m_contextData.Push((newNode, CCompileUnit.CT_FUNCTION_BODY));
            // We visit the child for function.
            foreach (var child in context.function_definition())
            {
                Visit(child);
            }
            // We pop the tuple we added before.
            m_contextData.Pop();


            return 0;
        }

        public override int VisitFunctionDefinition(MiniCParser.FunctionDefinitionContext context)
        {
            (ASTElement, int) parent_data, new_parent_data;

            CFunctionDefinition newNode = new CFunctionDefinition();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newNode, parent_data.Item2);

            new_parent_data = (newNode, CFunctionDefinition.CT_FNAME);
            m_contextData.Push(new_parent_data);
            Visit(context.expr());
            m_contextData.Pop();

            if (context.fargs() != null)
            {
                new_parent_data = (newNode, CFunctionDefinition.CT_ARGS);
                m_contextData.Push(new_parent_data);
                Visit(context.fargs());
                m_contextData.Pop();
            }

            new_parent_data = (newNode, CFunctionDefinition.CT_BODY);
            m_contextData.Push(new_parent_data);
            Visit(context.compound_statement());
            m_contextData.Pop();
            
            return 0;
        }

        // Statements
        public override int VisitStatementExpr(MiniCParser.StatementExprContext context)
        {
            (ASTElement, int) parent_data;

            CStatementExpr newNode = new CStatementExpr();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_BODY.
            m_contextData.Push((newNode, CStatementExpr.CT_BODY));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitStatementCompound(MiniCParser.StatementCompoundContext context)
        {
            (ASTElement, int) parent_data;

            CStatementCompound newNode = new CStatementCompound();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_BODY.
            m_contextData.Push((newNode, CStatementCompound.CT_BODY));
            // We visit the children on the left.
            Visit(context.statements());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitStatementIf(MiniCParser.StatementIfContext context)
        {
            (ASTElement, int) parent_data;

            CStatementIf newNode = new CStatementIf();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_CONDITION.
            m_contextData.Push((newNode, CStatementIf.CT_CONDITION));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_TRUE_BODY.
            m_contextData.Push((newNode, CStatementIf.CT_TRUE_BODY));
            // We visit the children on the right.
            Visit(context.statement(0));
            m_contextData.Pop();

            if (context.statement(1) != null)
            {
                // We give the parents before adding the child to the stack and determining the place of the child to be on CT_FALSE_BODY.
                m_contextData.Push((newNode, CStatementIf.CT_FALSE_BODY));
                // We visit the children on the right.
                Visit(context.statement(1));
                m_contextData.Pop();
            }

            return 0;
        }

        public override int VisitStatementFor(MiniCParser.StatementForContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            CStatementFor newNode = new CStatementFor();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_START.
            m_contextData.Push((newNode, CStatementFor.CT_START));
            // We visit the children on the left.
            Visit(context.expr(0));
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_CONDITION.
            m_contextData.Push((newNode, CStatementFor.CT_CONDITION));
            // We visit the children on the right.
            Visit(context.expr(1));
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LOOP.
            m_contextData.Push((newNode, CStatementFor.CT_LOOP));
            // We visit the children on the right.
            Visit(context.expr(2));
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_BODY.
            m_contextData.Push((newNode, CStatementFor.CT_BODY));
            // We visit the children on the right.
            Visit(context.compound_statement());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitStatementWhile(MiniCParser.StatementWhileContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            CStatementWhile newNode = new CStatementWhile();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_CONDITION.
            m_contextData.Push((newNode, CStatementWhile.CT_CONDITION));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_BODY.
            m_contextData.Push((newNode, CStatementWhile.CT_BODY));
            // We visit the children on the right.
            Visit(context.compound_statement());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitStatementDoWhile(MiniCParser.StatementDoWhileContext context)
        {
            (ASTElement, int) parent_data;

            CStatementDoWhile newNode = new CStatementDoWhile();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_BODY.
            m_contextData.Push((newNode, CStatementDoWhile.CT_BODY));
            // We visit the children on the left.
            Visit(context.compound_statement());
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_CONDITION.
            m_contextData.Push((newNode, CStatementDoWhile.CT_CONDITION));
            // We visit the children on the right.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitStatementSwitch(MiniCParser.StatementSwitchContext context)
        {
            /*
            (ASTElement, int) parent_data;

            CStatementSwitch newNode = new CStatementSwitch();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_CONDITION.
            m_contextData.Push((newNode, CStatementSwitch.CT_IDENTIFIER));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_TRUE_BODY.
            m_contextData.Push((newNode, CStatementSwitch.CT_CASE));
            // We visit the children on the right.
            for (int i = 0; i < newNode.GetChild(CStatementSwitch.CT_CASE).Get)
            {
                Visit(context.switch_case(i)));
        }
            m_contextData.Pop();

            if (context.statement(1) != null)
            {
                // We give the parents before adding the child to the stack and determining the place of the child to be on CT_FALSE_BODY.
                m_contextData.Push((newNode, CStatementIf.CT_FALSE_BODY));
                // We visit the children on the right.
                Visit(context.statement(1));
                m_contextData.Pop();
            }
            */
            return 0;
        }

        public override int VisitStatementRETURN(MiniCParser.StatementRETURNContext context)
        {
            (ASTElement, int) parent_data;

            CStatementRETURN newNode = new CStatementRETURN();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CStatementRETURN.CT_BODY));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitStatementBREAK(MiniCParser.StatementBREAKContext context)
        {
            (ASTElement, int) parent_data;

            CStatementBreak newNode = new CStatementBreak();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CStatementBreak.CT_BODY));
            // We visit the children on the left.
            Visit(context.SEMICOLON());
            m_contextData.Pop();

            return 0;
        }

        // Expressions
        public override int VisitExprAssignment(MiniCParser.ExprAssignmentContext context)
        {
            (ASTElement, int) parent_data;

            CExprAssignment newNode = new CExprAssignment();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprAssignment.CT_LEFT));
            // We visit the children on the left which is the VARIABLE.
            Visit(context.VARIABLE());
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
            m_contextData.Push((newNode, CExprAssignment.CT_RIGHT));
            // We visit the children on the right which is the expr.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprPlusOne(MiniCParser.ExprPlusOneContext context)
        {
            (ASTElement, int) parent_data;

            CExprPlusOne newNode = new CExprPlusOne();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprPlusOne.CT_BODY));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprMinusOne(MiniCParser.ExprMinusOneContext context)
        {
            (ASTElement, int) parent_data;

            CExprMinusOne newNode = new CExprMinusOne();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprMinusOne.CT_BODY));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprUnaryPlus(MiniCParser.ExprUnaryPlusContext context)
        {
            (ASTElement, int) parent_data;

            CExprUnaryPlus newNode = new CExprUnaryPlus();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprUnaryPlus.CT_BODY));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprUnaryMinus(MiniCParser.ExprUnaryMinusContext context)
        {
            (ASTElement, int) parent_data;

            CExprUnaryMinus newNode = new CExprUnaryMinus();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprUnaryMinus.CT_BODY));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprNot(MiniCParser.ExprNotContext context)
        {
            (ASTElement, int) parent_data;

            CExprNot newNode = new CExprNot();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprNot.CT_BODY));
            // We visit the children on the left.
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprMulDiv(MiniCParser.ExprMulDivContext context)
        {
            (ASTElement, int) parent_data;

            switch (context.op.Type)
            {
                case MiniCLexer.MULTI:
                    CExprMultiplication newNodeMulti = new CExprMultiplication();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeMulti, parent_data.Item2);
                    newNodeMulti.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeMulti, CExprMultiplication.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeMulti, CExprMultiplication.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
                case MiniCLexer.DIV:
                    CExprDivision newNodeDiv = new CExprDivision();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeDiv, parent_data.Item2);
                    newNodeDiv.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeDiv, CExprDivision.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeDiv, CExprDivision.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
            }
            return 0;
        }

        public override int VisitExprAddSub(MiniCParser.ExprAddSubContext context)
        {
            (ASTElement, int) parent_data;

            switch (context.op.Type)
            {
                case MiniCLexer.PLUS:
                    CExprAddition newNodePlus = new CExprAddition();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodePlus, parent_data.Item2);
                    newNodePlus.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodePlus, CExprAddition.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodePlus, CExprAddition.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
                case MiniCLexer.MINUS:
                    CExprSubtraction newNodeMinus = new CExprSubtraction();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeMinus, parent_data.Item2);
                    newNodeMinus.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeMinus, CExprSubtraction.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeMinus, CExprSubtraction.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
            }
            return 0;
        }

        public override int VisitExprRelationalOperators(MiniCParser.ExprRelationalOperatorsContext context)
        {
            (ASTElement, int) parent_data;

            switch (context.op.Type)
            {
                case MiniCLexer.GT:
                    CExprGreaterThan newNodeGT = new CExprGreaterThan();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeGT, parent_data.Item2);
                    newNodeGT.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeGT, CExprGreaterThan.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeGT, CExprGreaterThan.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
                case MiniCLexer.GTE:
                    CExprGreaterThanEqual newNodeGTE = new CExprGreaterThanEqual();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeGTE, parent_data.Item2);
                    newNodeGTE.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeGTE, CExprGreaterThanEqual.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeGTE, CExprGreaterThanEqual.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
                case MiniCLexer.LT:
                    CExprLesserThan newNodeLT = new CExprLesserThan();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeLT, parent_data.Item2);
                    newNodeLT.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeLT, CExprLesserThan.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeLT, CExprLesserThan.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
                case MiniCLexer.LTE:
                    CExprLesserThanEqual newNodeLTE = new CExprLesserThanEqual();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeLTE, parent_data.Item2);
                    newNodeLTE.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeLTE, CExprLesserThanEqual.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeLTE, CExprLesserThanEqual.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
            }
            return 0;
        }

        public override int VisitExprComparison(MiniCParser.ExprComparisonContext context)
        {
            (ASTElement, int) parent_data;

            switch (context.op.Type)
            {
                case MiniCLexer.EQUAL:
                    CExprEqual newNodeEQUAL = new CExprEqual();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeEQUAL, parent_data.Item2);
                    newNodeEQUAL.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeEQUAL, CExprEqual.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeEQUAL, CExprEqual.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
                case MiniCLexer.NEQUAL:
                    CExprNotEqual newNodeNEQUAL = new CExprNotEqual();
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newNodeNEQUAL, parent_data.Item2);
                    newNodeNEQUAL.MParent = parent_data.Item1;

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
                    m_contextData.Push((newNodeNEQUAL, CExprNotEqual.CT_LEFT));
                    // We visit the children on the left.
                    Visit(context.expr(0));
                    m_contextData.Pop();

                    // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
                    m_contextData.Push((newNodeNEQUAL, CExprNotEqual.CT_RIGHT));
                    // We visit the children on the right.
                    Visit(context.expr(1));
                    m_contextData.Pop();

                    break;
            }
            return 0;
        }

        public override int VisitExprAnd(MiniCParser.ExprAndContext context)
        {
            (ASTElement, int) parent_data;

            CExprAnd newNode = new CExprAnd();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprAnd.CT_LEFT));
            // We visit the children on the left.
            Visit(context.expr(0));
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
            m_contextData.Push((newNode, CExprAnd.CT_RIGHT));
            // We visit the children on the right.
            Visit(context.expr(1));
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprOr(MiniCParser.ExprOrContext context)
        {
            (ASTElement, int) parent_data;

            CExprOr newNode = new CExprOr();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprOr.CT_LEFT));
            // We visit the children on the left.
            Visit(context.expr(0));
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
            m_contextData.Push((newNode, CExprOr.CT_RIGHT));
            // We visit the children on the right.
            Visit(context.expr(1));
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprFCall(MiniCParser.ExprFCallContext context)
        {
            (ASTElement, int) parent_data;

            CExprFCall newNode = new CExprFCall();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprFCall.CT_FNAME));
            // We visit the children on the left.
            Visit(context.VARIABLE());
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
            m_contextData.Push((newNode, CExprFCall.CT_ARGS));
            // We visit the children on the right.
            Visit(context.args());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExprSpecVARIABLE(MiniCParser.ExprSpecVARIABLEContext context)
        {
            (ASTElement, int) parent_data;

            CExprSpecVARIABLE newNode = new CExprSpecVARIABLE();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CExprSpecVARIABLE.CT_SPECIFIERTYPE));
            // We visit the children on the left.
            int i = Visit(context.specifier());
            switch (i)
            {
                case 1: // Integer
                    newNode.variableType = VariableType.VT_INTEGER;
                    break;
                case 2: // Double
                    newNode.variableType = VariableType.VT_DOUBLE;
                    break;
                case 3: // String
                    newNode.variableType = VariableType.VT_STRING;
                    break;
            }
            m_contextData.Pop();

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_RIGHT.
            m_contextData.Push((newNode, CExprSpecVARIABLE.CT_VARIABLE));
            // We visit the children on the right.
            Visit(context.VARIABLE());
            m_contextData.Pop();

            return 0;
        }

        // Specifiers
        public override int VisitSpecINTEGER(MiniCParser.SpecINTEGERContext context)
        {
            (ASTElement, int) parent_data;

            CSpecINTEGER newNode = new CSpecINTEGER();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CSpecINTEGER.CT_SPECIFIER));
            // We visit the children on the left.
            Visit(context.INTSPECIFIER());
            m_contextData.Pop();

            return 1;
        }

        public override int VisitSpecDOUBLE(MiniCParser.SpecDOUBLEContext context)
        {
            (ASTElement, int) parent_data;

            CSpecDOUBLE newNode = new CSpecDOUBLE();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CSpecDOUBLE.CT_SPECIFIER));
            // We visit the children on the left.
            Visit(context.DOUBLESPECIFIER());
            m_contextData.Pop();

            return 2;
        }

        public override int VisitSpecSTRING(MiniCParser.SpecSTRINGContext context)
        {
            (ASTElement, int) parent_data;

            CSpecSTRING newNode = new CSpecSTRING();
            // We figure who is the parent of this node.
            parent_data = m_contextData.Peek();
            // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
            parent_data.Item1.AddChild(newNode, parent_data.Item2);
            newNode.MParent = parent_data.Item1;

            // We give the parents before adding the child to the stack and determining the place of the child to be on CT_LEFT.
            m_contextData.Push((newNode, CSpecSTRING.CT_SPECIFIER));
            // We visit the children on the left.
            Visit(context.STRINGSPECIFIER());
            m_contextData.Pop();

            return 3;
        }

        // Terminal
        public override int VisitTerminal(ITerminalNode node)
        {
            (ASTElement, int) parent_data;

            switch (node.Symbol.Type)
            {
                case MiniCLexer.VARIABLE:
                    CExprVARIABLE newVARIABLE = new CExprVARIABLE(node.Symbol.Text);
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();

                    // Specifying the type of variable based on what specifier has in front of it.
                    switch (parent_data.Item1.variableType)
                    {
                        case VariableType.VT_INTEGER:
                            newVARIABLE.variableType = VariableType.VT_INTEGER;
                            break;
                        case VariableType.VT_DOUBLE:
                            newVARIABLE.variableType = VariableType.VT_DOUBLE;
                            break;
                        case VariableType.VT_STRING:
                            newVARIABLE.variableType = VariableType.VT_STRING;
                            break;
                    }

                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newVARIABLE, parent_data.Item2);
                    newVARIABLE.MParent = parent_data.Item1;
                    
                    break;
                case MiniCLexer.STRING:
                    CExprSTRING newSTRING = new CExprSTRING(node.Symbol.Text);
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newSTRING, parent_data.Item2);
                    newSTRING.MParent = parent_data.Item1;

                    break;
                case MiniCLexer.COMMENT:
                    CExprCOMMENT newCOMMENT = new CExprCOMMENT(node.Symbol.Text);
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newCOMMENT, parent_data.Item2);
                    newCOMMENT.MParent = parent_data.Item1;

                    break;
                case MiniCLexer.INTEGER:
                    CExprINTEGER newINTEGER = new CExprINTEGER(node.Symbol.Text);
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newINTEGER, parent_data.Item2);
                    newINTEGER.MParent = parent_data.Item1;

                    break;
                case MiniCLexer.DOUBLE:
                    CExprDOUBLE newDOUBLE = new CExprDOUBLE(node.Symbol.Text);
                    // We figure who is the parent of this node.
                    parent_data = m_contextData.Peek();
                    // We are adding to the parent the children of this node. (Item1 = parent, Item2 = children)
                    parent_data.Item1.AddChild(newDOUBLE, parent_data.Item2);
                    newDOUBLE.MParent = parent_data.Item1;

                    break;
            }
            return 0;
        }
    }
}
