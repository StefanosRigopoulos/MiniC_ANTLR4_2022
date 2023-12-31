//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:\UOP\7th Semester\Compilers II\Laboratory\MiniC\MiniC.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace MiniC {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IMiniCListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class MiniCBaseListener : IMiniCListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>StatementCompound</c>
	/// labeled alternative in <see cref="MiniCParser.compound_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementCompound([NotNull] MiniCParser.StatementCompoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementCompound</c>
	/// labeled alternative in <see cref="MiniCParser.compound_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementCompound([NotNull] MiniCParser.StatementCompoundContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>SpecSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecSTRING([NotNull] MiniCParser.SpecSTRINGContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecSTRING([NotNull] MiniCParser.SpecSTRINGContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>SpecDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecDOUBLE([NotNull] MiniCParser.SpecDOUBLEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecDOUBLE([NotNull] MiniCParser.SpecDOUBLEContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>SpecINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecINTEGER([NotNull] MiniCParser.SpecINTEGERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecINTEGER([NotNull] MiniCParser.SpecINTEGERContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementNULL</c>
	/// labeled alternative in <see cref="MiniCParser.null_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementNULL([NotNull] MiniCParser.StatementNULLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementNULL</c>
	/// labeled alternative in <see cref="MiniCParser.null_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementNULL([NotNull] MiniCParser.StatementNULLContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementSwitch</c>
	/// labeled alternative in <see cref="MiniCParser.switch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementSwitch([NotNull] MiniCParser.StatementSwitchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementSwitch</c>
	/// labeled alternative in <see cref="MiniCParser.switch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementSwitch([NotNull] MiniCParser.StatementSwitchContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementFor</c>
	/// labeled alternative in <see cref="MiniCParser.for_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementFor([NotNull] MiniCParser.StatementForContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementFor</c>
	/// labeled alternative in <see cref="MiniCParser.for_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementFor([NotNull] MiniCParser.StatementForContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementDoWhile</c>
	/// labeled alternative in <see cref="MiniCParser.do_while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementDoWhile([NotNull] MiniCParser.StatementDoWhileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementDoWhile</c>
	/// labeled alternative in <see cref="MiniCParser.do_while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementDoWhile([NotNull] MiniCParser.StatementDoWhileContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementExpr</c>
	/// labeled alternative in <see cref="MiniCParser.expr_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementExpr([NotNull] MiniCParser.StatementExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementExpr</c>
	/// labeled alternative in <see cref="MiniCParser.expr_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementExpr([NotNull] MiniCParser.StatementExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementIf</c>
	/// labeled alternative in <see cref="MiniCParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementIf([NotNull] MiniCParser.StatementIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementIf</c>
	/// labeled alternative in <see cref="MiniCParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementIf([NotNull] MiniCParser.StatementIfContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprINTEGER([NotNull] MiniCParser.ExprINTEGERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprINTEGER([NotNull] MiniCParser.ExprINTEGERContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprSpecVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprSpecVARIABLE([NotNull] MiniCParser.ExprSpecVARIABLEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprSpecVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprSpecVARIABLE([NotNull] MiniCParser.ExprSpecVARIABLEContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprComparison</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprComparison([NotNull] MiniCParser.ExprComparisonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprComparison</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprComparison([NotNull] MiniCParser.ExprComparisonContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprRelationalOperators</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprRelationalOperators([NotNull] MiniCParser.ExprRelationalOperatorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprRelationalOperators</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprRelationalOperators([NotNull] MiniCParser.ExprRelationalOperatorsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprVARIABLE([NotNull] MiniCParser.ExprVARIABLEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprVARIABLE([NotNull] MiniCParser.ExprVARIABLEContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprNot</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprNot([NotNull] MiniCParser.ExprNotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprNot</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprNot([NotNull] MiniCParser.ExprNotContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprParenthesis</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprParenthesis([NotNull] MiniCParser.ExprParenthesisContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprParenthesis</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprParenthesis([NotNull] MiniCParser.ExprParenthesisContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprAddSub</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprAddSub([NotNull] MiniCParser.ExprAddSubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprAddSub</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprAddSub([NotNull] MiniCParser.ExprAddSubContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprAnd</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprAnd([NotNull] MiniCParser.ExprAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprAnd</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprAnd([NotNull] MiniCParser.ExprAndContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprCOMMENT</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprCOMMENT([NotNull] MiniCParser.ExprCOMMENTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprCOMMENT</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprCOMMENT([NotNull] MiniCParser.ExprCOMMENTContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprUnaryPlus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprUnaryPlus([NotNull] MiniCParser.ExprUnaryPlusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprUnaryPlus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprUnaryPlus([NotNull] MiniCParser.ExprUnaryPlusContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprMulDiv</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprMulDiv([NotNull] MiniCParser.ExprMulDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprMulDiv</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprMulDiv([NotNull] MiniCParser.ExprMulDivContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprFCall</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprFCall([NotNull] MiniCParser.ExprFCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprFCall</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprFCall([NotNull] MiniCParser.ExprFCallContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprDOUBLE([NotNull] MiniCParser.ExprDOUBLEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprDOUBLE([NotNull] MiniCParser.ExprDOUBLEContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprOr</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOr([NotNull] MiniCParser.ExprOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprOr</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOr([NotNull] MiniCParser.ExprOrContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprSTRING([NotNull] MiniCParser.ExprSTRINGContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprSTRING([NotNull] MiniCParser.ExprSTRINGContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprUnaryMinus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprUnaryMinus([NotNull] MiniCParser.ExprUnaryMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprUnaryMinus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprUnaryMinus([NotNull] MiniCParser.ExprUnaryMinusContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprPlusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprPlusOne([NotNull] MiniCParser.ExprPlusOneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprPlusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprPlusOne([NotNull] MiniCParser.ExprPlusOneContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprAssignment</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprAssignment([NotNull] MiniCParser.ExprAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprAssignment</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprAssignment([NotNull] MiniCParser.ExprAssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprMinusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprMinusOne([NotNull] MiniCParser.ExprMinusOneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprMinusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprMinusOne([NotNull] MiniCParser.ExprMinusOneContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementWhile</c>
	/// labeled alternative in <see cref="MiniCParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementWhile([NotNull] MiniCParser.StatementWhileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementWhile</c>
	/// labeled alternative in <see cref="MiniCParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementWhile([NotNull] MiniCParser.StatementWhileContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementBREAK</c>
	/// labeled alternative in <see cref="MiniCParser.break_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementBREAK([NotNull] MiniCParser.StatementBREAKContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementBREAK</c>
	/// labeled alternative in <see cref="MiniCParser.break_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementBREAK([NotNull] MiniCParser.StatementBREAKContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionDefinition</c>
	/// labeled alternative in <see cref="MiniCParser.function_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDefinition([NotNull] MiniCParser.FunctionDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionDefinition</c>
	/// labeled alternative in <see cref="MiniCParser.function_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDefinition([NotNull] MiniCParser.FunctionDefinitionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementRETURN</c>
	/// labeled alternative in <see cref="MiniCParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementRETURN([NotNull] MiniCParser.StatementRETURNContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementRETURN</c>
	/// labeled alternative in <see cref="MiniCParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementRETURN([NotNull] MiniCParser.StatementRETURNContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompileUnit([NotNull] MiniCParser.CompileUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompileUnit([NotNull] MiniCParser.CompileUnitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.function_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_definition([NotNull] MiniCParser.Function_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.function_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_definition([NotNull] MiniCParser.Function_definitionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.fargs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFargs([NotNull] MiniCParser.FargsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.fargs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFargs([NotNull] MiniCParser.FargsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] MiniCParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] MiniCParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.expr_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_statement([NotNull] MiniCParser.Expr_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.expr_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_statement([NotNull] MiniCParser.Expr_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_statement([NotNull] MiniCParser.If_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_statement([NotNull] MiniCParser.If_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.for_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_statement([NotNull] MiniCParser.For_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.for_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_statement([NotNull] MiniCParser.For_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_statement([NotNull] MiniCParser.While_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_statement([NotNull] MiniCParser.While_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.do_while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDo_while_statement([NotNull] MiniCParser.Do_while_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.do_while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDo_while_statement([NotNull] MiniCParser.Do_while_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.switch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_statement([NotNull] MiniCParser.Switch_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.switch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_statement([NotNull] MiniCParser.Switch_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.switch_case"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_case([NotNull] MiniCParser.Switch_caseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.switch_case"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_case([NotNull] MiniCParser.Switch_caseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.switch_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_default([NotNull] MiniCParser.Switch_defaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.switch_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_default([NotNull] MiniCParser.Switch_defaultContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_statement([NotNull] MiniCParser.Return_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_statement([NotNull] MiniCParser.Return_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.break_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreak_statement([NotNull] MiniCParser.Break_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.break_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreak_statement([NotNull] MiniCParser.Break_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.null_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNull_statement([NotNull] MiniCParser.Null_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.null_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNull_statement([NotNull] MiniCParser.Null_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.compound_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_statement([NotNull] MiniCParser.Compound_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.compound_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_statement([NotNull] MiniCParser.Compound_statementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatements([NotNull] MiniCParser.StatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatements([NotNull] MiniCParser.StatementsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] MiniCParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] MiniCParser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecifier([NotNull] MiniCParser.SpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecifier([NotNull] MiniCParser.SpecifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgs([NotNull] MiniCParser.ArgsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgs([NotNull] MiniCParser.ArgsContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace MiniC
