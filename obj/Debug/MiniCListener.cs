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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MiniCParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMiniCListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>StatementCompound</c>
	/// labeled alternative in <see cref="MiniCParser.compound_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementCompound([NotNull] MiniCParser.StatementCompoundContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementCompound</c>
	/// labeled alternative in <see cref="MiniCParser.compound_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementCompound([NotNull] MiniCParser.StatementCompoundContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SpecSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecSTRING([NotNull] MiniCParser.SpecSTRINGContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecSTRING([NotNull] MiniCParser.SpecSTRINGContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SpecDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecDOUBLE([NotNull] MiniCParser.SpecDOUBLEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecDOUBLE([NotNull] MiniCParser.SpecDOUBLEContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>SpecINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecINTEGER([NotNull] MiniCParser.SpecINTEGERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecINTEGER([NotNull] MiniCParser.SpecINTEGERContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementNULL</c>
	/// labeled alternative in <see cref="MiniCParser.null_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementNULL([NotNull] MiniCParser.StatementNULLContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementNULL</c>
	/// labeled alternative in <see cref="MiniCParser.null_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementNULL([NotNull] MiniCParser.StatementNULLContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementSwitch</c>
	/// labeled alternative in <see cref="MiniCParser.switch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementSwitch([NotNull] MiniCParser.StatementSwitchContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementSwitch</c>
	/// labeled alternative in <see cref="MiniCParser.switch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementSwitch([NotNull] MiniCParser.StatementSwitchContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementFor</c>
	/// labeled alternative in <see cref="MiniCParser.for_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementFor([NotNull] MiniCParser.StatementForContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementFor</c>
	/// labeled alternative in <see cref="MiniCParser.for_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementFor([NotNull] MiniCParser.StatementForContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementDoWhile</c>
	/// labeled alternative in <see cref="MiniCParser.do_while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementDoWhile([NotNull] MiniCParser.StatementDoWhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementDoWhile</c>
	/// labeled alternative in <see cref="MiniCParser.do_while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementDoWhile([NotNull] MiniCParser.StatementDoWhileContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementExpr</c>
	/// labeled alternative in <see cref="MiniCParser.expr_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementExpr([NotNull] MiniCParser.StatementExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementExpr</c>
	/// labeled alternative in <see cref="MiniCParser.expr_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementExpr([NotNull] MiniCParser.StatementExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementIf</c>
	/// labeled alternative in <see cref="MiniCParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementIf([NotNull] MiniCParser.StatementIfContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementIf</c>
	/// labeled alternative in <see cref="MiniCParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementIf([NotNull] MiniCParser.StatementIfContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprINTEGER([NotNull] MiniCParser.ExprINTEGERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprINTEGER</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprINTEGER([NotNull] MiniCParser.ExprINTEGERContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprSpecVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprSpecVARIABLE([NotNull] MiniCParser.ExprSpecVARIABLEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprSpecVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprSpecVARIABLE([NotNull] MiniCParser.ExprSpecVARIABLEContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprComparison</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprComparison([NotNull] MiniCParser.ExprComparisonContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprComparison</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprComparison([NotNull] MiniCParser.ExprComparisonContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprRelationalOperators</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprRelationalOperators([NotNull] MiniCParser.ExprRelationalOperatorsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprRelationalOperators</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprRelationalOperators([NotNull] MiniCParser.ExprRelationalOperatorsContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprVARIABLE([NotNull] MiniCParser.ExprVARIABLEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprVARIABLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprVARIABLE([NotNull] MiniCParser.ExprVARIABLEContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprNot</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprNot([NotNull] MiniCParser.ExprNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprNot</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprNot([NotNull] MiniCParser.ExprNotContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprParenthesis</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprParenthesis([NotNull] MiniCParser.ExprParenthesisContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprParenthesis</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprParenthesis([NotNull] MiniCParser.ExprParenthesisContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprAddSub</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprAddSub([NotNull] MiniCParser.ExprAddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprAddSub</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprAddSub([NotNull] MiniCParser.ExprAddSubContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprAnd</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprAnd([NotNull] MiniCParser.ExprAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprAnd</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprAnd([NotNull] MiniCParser.ExprAndContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprCOMMENT</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprCOMMENT([NotNull] MiniCParser.ExprCOMMENTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprCOMMENT</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprCOMMENT([NotNull] MiniCParser.ExprCOMMENTContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprUnaryPlus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprUnaryPlus([NotNull] MiniCParser.ExprUnaryPlusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprUnaryPlus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprUnaryPlus([NotNull] MiniCParser.ExprUnaryPlusContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprMulDiv</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprMulDiv([NotNull] MiniCParser.ExprMulDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprMulDiv</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprMulDiv([NotNull] MiniCParser.ExprMulDivContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprFCall</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprFCall([NotNull] MiniCParser.ExprFCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprFCall</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprFCall([NotNull] MiniCParser.ExprFCallContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprDOUBLE([NotNull] MiniCParser.ExprDOUBLEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprDOUBLE</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprDOUBLE([NotNull] MiniCParser.ExprDOUBLEContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprOr</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOr([NotNull] MiniCParser.ExprOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprOr</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOr([NotNull] MiniCParser.ExprOrContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprSTRING([NotNull] MiniCParser.ExprSTRINGContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprSTRING</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprSTRING([NotNull] MiniCParser.ExprSTRINGContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprUnaryMinus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprUnaryMinus([NotNull] MiniCParser.ExprUnaryMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprUnaryMinus</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprUnaryMinus([NotNull] MiniCParser.ExprUnaryMinusContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprPlusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprPlusOne([NotNull] MiniCParser.ExprPlusOneContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprPlusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprPlusOne([NotNull] MiniCParser.ExprPlusOneContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprAssignment</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprAssignment([NotNull] MiniCParser.ExprAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprAssignment</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprAssignment([NotNull] MiniCParser.ExprAssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ExprMinusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprMinusOne([NotNull] MiniCParser.ExprMinusOneContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExprMinusOne</c>
	/// labeled alternative in <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprMinusOne([NotNull] MiniCParser.ExprMinusOneContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementWhile</c>
	/// labeled alternative in <see cref="MiniCParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementWhile([NotNull] MiniCParser.StatementWhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementWhile</c>
	/// labeled alternative in <see cref="MiniCParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementWhile([NotNull] MiniCParser.StatementWhileContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementBREAK</c>
	/// labeled alternative in <see cref="MiniCParser.break_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementBREAK([NotNull] MiniCParser.StatementBREAKContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementBREAK</c>
	/// labeled alternative in <see cref="MiniCParser.break_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementBREAK([NotNull] MiniCParser.StatementBREAKContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionDefinition</c>
	/// labeled alternative in <see cref="MiniCParser.function_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDefinition([NotNull] MiniCParser.FunctionDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionDefinition</c>
	/// labeled alternative in <see cref="MiniCParser.function_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDefinition([NotNull] MiniCParser.FunctionDefinitionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>StatementRETURN</c>
	/// labeled alternative in <see cref="MiniCParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementRETURN([NotNull] MiniCParser.StatementRETURNContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>StatementRETURN</c>
	/// labeled alternative in <see cref="MiniCParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementRETURN([NotNull] MiniCParser.StatementRETURNContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] MiniCParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] MiniCParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.function_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_definition([NotNull] MiniCParser.Function_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.function_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_definition([NotNull] MiniCParser.Function_definitionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.fargs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFargs([NotNull] MiniCParser.FargsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.fargs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFargs([NotNull] MiniCParser.FargsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] MiniCParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] MiniCParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.expr_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_statement([NotNull] MiniCParser.Expr_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.expr_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_statement([NotNull] MiniCParser.Expr_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_statement([NotNull] MiniCParser.If_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_statement([NotNull] MiniCParser.If_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.for_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_statement([NotNull] MiniCParser.For_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.for_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_statement([NotNull] MiniCParser.For_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile_statement([NotNull] MiniCParser.While_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile_statement([NotNull] MiniCParser.While_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.do_while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDo_while_statement([NotNull] MiniCParser.Do_while_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.do_while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDo_while_statement([NotNull] MiniCParser.Do_while_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.switch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_statement([NotNull] MiniCParser.Switch_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.switch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_statement([NotNull] MiniCParser.Switch_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.switch_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_case([NotNull] MiniCParser.Switch_caseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.switch_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_case([NotNull] MiniCParser.Switch_caseContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.switch_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_default([NotNull] MiniCParser.Switch_defaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.switch_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_default([NotNull] MiniCParser.Switch_defaultContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturn_statement([NotNull] MiniCParser.Return_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturn_statement([NotNull] MiniCParser.Return_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.break_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreak_statement([NotNull] MiniCParser.Break_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.break_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreak_statement([NotNull] MiniCParser.Break_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.null_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull_statement([NotNull] MiniCParser.Null_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.null_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull_statement([NotNull] MiniCParser.Null_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.compound_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_statement([NotNull] MiniCParser.Compound_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.compound_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_statement([NotNull] MiniCParser.Compound_statementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatements([NotNull] MiniCParser.StatementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatements([NotNull] MiniCParser.StatementsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] MiniCParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] MiniCParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecifier([NotNull] MiniCParser.SpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecifier([NotNull] MiniCParser.SpecifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MiniCParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgs([NotNull] MiniCParser.ArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MiniCParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgs([NotNull] MiniCParser.ArgsContext context);
}
} // namespace MiniC
