using System;
using System.Collections.Generic;
using System.Linq;
using Roslyn.Compilers.CSharp;

namespace LaharlCSharp.BuildLines
{
	internal class NodeBuildingWalker : SyntaxWalker
	{
		private readonly NodeBuilder builder;

		public NodeBuildingWalker(NodeBuilder builder)
		{
			this.builder = builder;
		}

		public override void Visit(SyntaxNode node)
		{
			base.Visit(node);
		}

		public override void DefaultVisit(SyntaxNode node)
		{
			base.DefaultVisit(node);
		}

		public override void VisitIdentifierName(IdentifierNameSyntax node)
		{
			base.VisitIdentifierName(node);
		}

		public override void VisitQualifiedName(QualifiedNameSyntax node)
		{
			base.VisitQualifiedName(node);
		}

		public override void VisitGenericName(GenericNameSyntax node)
		{
			base.VisitGenericName(node);
		}

		public override void VisitTypeArgumentList(TypeArgumentListSyntax node)
		{
			base.VisitTypeArgumentList(node);
		}

		public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
		{
			base.VisitAliasQualifiedName(node);
		}

		public override void VisitPredefinedType(PredefinedTypeSyntax node)
		{
			base.VisitPredefinedType(node);
		}

		public override void VisitArrayType(ArrayTypeSyntax node)
		{
			base.VisitArrayType(node);
		}

		public override void VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
		{
			base.VisitArrayRankSpecifier(node);
		}

		public override void VisitPointerType(PointerTypeSyntax node)
		{
			base.VisitPointerType(node);
		}

		public override void VisitNullableType(NullableTypeSyntax node)
		{
			base.VisitNullableType(node);
		}

		public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
		{
			base.VisitOmittedTypeArgument(node);
		}

		public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
		{
			base.VisitParenthesizedExpression(node);
		}

		public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
		{
			base.VisitPrefixUnaryExpression(node);
		}

		public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
		{
			base.VisitPostfixUnaryExpression(node);
		}

		public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
		{
			base.VisitMemberAccessExpression(node);
		}

		public override void VisitBinaryExpression(BinaryExpressionSyntax node)
		{
			base.VisitBinaryExpression(node);
		}

		public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
		{
			base.VisitConditionalExpression(node);
		}

		public override void VisitThisExpression(ThisExpressionSyntax node)
		{
			base.VisitThisExpression(node);
		}

		public override void VisitBaseExpression(BaseExpressionSyntax node)
		{
			base.VisitBaseExpression(node);
		}

		public override void VisitLiteralExpression(LiteralExpressionSyntax node)
		{
			base.VisitLiteralExpression(node);
		}

		public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)
		{
			base.VisitMakeRefExpression(node);
		}

		public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)
		{
			base.VisitRefTypeExpression(node);
		}

		public override void VisitRefValueExpression(RefValueExpressionSyntax node)
		{
			base.VisitRefValueExpression(node);
		}

		public override void VisitCheckedExpression(CheckedExpressionSyntax node)
		{
			base.VisitCheckedExpression(node);
		}

		public override void VisitDefaultExpression(DefaultExpressionSyntax node)
		{
			base.VisitDefaultExpression(node);
		}

		public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
		{
			base.VisitTypeOfExpression(node);
		}

		public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
		{
			base.VisitSizeOfExpression(node);
		}

		public override void VisitInvocationExpression(InvocationExpressionSyntax node)
		{
			base.VisitInvocationExpression(node);
		}

		public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
		{
			base.VisitElementAccessExpression(node);
		}

		public override void VisitArgumentList(ArgumentListSyntax node)
		{
			base.VisitArgumentList(node);
		}

		public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
		{
			base.VisitBracketedArgumentList(node);
		}

		public override void VisitArgument(ArgumentSyntax node)
		{
			base.VisitArgument(node);
		}

		public override void VisitNameColon(NameColonSyntax node)
		{
			base.VisitNameColon(node);
		}

		public override void VisitCastExpression(CastExpressionSyntax node)
		{
			base.VisitCastExpression(node);
		}

		public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
		{
			base.VisitAnonymousMethodExpression(node);
		}

		public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
		{
			base.VisitSimpleLambdaExpression(node);
		}

		public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
		{
			base.VisitParenthesizedLambdaExpression(node);
		}

		public override void VisitInitializerExpression(InitializerExpressionSyntax node)
		{
			base.VisitInitializerExpression(node);
		}

		public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
		{
			base.VisitObjectCreationExpression(node);
		}

		public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
		{
			base.VisitAnonymousObjectMemberDeclarator(node);
		}

		public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
		{
			base.VisitAnonymousObjectCreationExpression(node);
		}

		public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
		{
			base.VisitArrayCreationExpression(node);
		}

		public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
		{
			base.VisitImplicitArrayCreationExpression(node);
		}

		public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
		{
			base.VisitStackAllocArrayCreationExpression(node);
		}

		public override void VisitQueryExpression(QueryExpressionSyntax node)
		{
			base.VisitQueryExpression(node);
		}

		public override void VisitQueryBody(QueryBodySyntax node)
		{
			base.VisitQueryBody(node);
		}

		public override void VisitFromClause(FromClauseSyntax node)
		{
			base.VisitFromClause(node);
		}

		public override void VisitLetClause(LetClauseSyntax node)
		{
			base.VisitLetClause(node);
		}

		public override void VisitJoinClause(JoinClauseSyntax node)
		{
			base.VisitJoinClause(node);
		}

		public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
		{
			base.VisitJoinIntoClause(node);
		}

		public override void VisitWhereClause(WhereClauseSyntax node)
		{
			base.VisitWhereClause(node);
		}

		public override void VisitOrderByClause(OrderByClauseSyntax node)
		{
			base.VisitOrderByClause(node);
		}

		public override void VisitOrdering(OrderingSyntax node)
		{
			base.VisitOrdering(node);
		}

		public override void VisitSelectClause(SelectClauseSyntax node)
		{
			base.VisitSelectClause(node);
		}

		public override void VisitGroupClause(GroupClauseSyntax node)
		{
			base.VisitGroupClause(node);
		}

		public override void VisitQueryContinuation(QueryContinuationSyntax node)
		{
			base.VisitQueryContinuation(node);
		}

		public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
		{
			base.VisitOmittedArraySizeExpression(node);
		}

		public override void VisitGlobalStatement(GlobalStatementSyntax node)
		{
			base.VisitGlobalStatement(node);
		}

		public override void VisitBlock(BlockSyntax node)
		{
			builder.AppendLine(node.OpenBraceToken.ToString());
			builder.IncreaseIndent();

			foreach (var statement in node.Statements)
			{
				base.Visit(statement);
			}

			builder.DecreaseIndent();
			builder.AppendLine(node.CloseBraceToken.ToString());
		}

		public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
		{
			base.VisitLocalDeclarationStatement(node);
		}

		public override void VisitVariableDeclaration(VariableDeclarationSyntax node)
		{
			base.VisitVariableDeclaration(node);
		}

		public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
		{
			base.VisitVariableDeclarator(node);
		}

		public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
		{
			base.VisitEqualsValueClause(node);
		}

		public override void VisitExpressionStatement(ExpressionStatementSyntax node)
		{
			builder.AppendLine(node.ToString());
		}

		public override void VisitEmptyStatement(EmptyStatementSyntax node)
		{
			base.VisitEmptyStatement(node);
		}

		public override void VisitLabeledStatement(LabeledStatementSyntax node)
		{
			base.VisitLabeledStatement(node);
		}

		public override void VisitGotoStatement(GotoStatementSyntax node)
		{
			base.VisitGotoStatement(node);
		}

		public override void VisitBreakStatement(BreakStatementSyntax node)
		{
			base.VisitBreakStatement(node);
		}

		public override void VisitContinueStatement(ContinueStatementSyntax node)
		{
			base.VisitContinueStatement(node);
		}

		public override void VisitReturnStatement(ReturnStatementSyntax node)
		{
			base.VisitReturnStatement(node);
		}

		public override void VisitThrowStatement(ThrowStatementSyntax node)
		{
			base.VisitThrowStatement(node);
		}

		public override void VisitYieldStatement(YieldStatementSyntax node)
		{
			base.VisitYieldStatement(node);
		}

		public override void VisitWhileStatement(WhileStatementSyntax node)
		{
			base.VisitWhileStatement(node);
		}

		public override void VisitDoStatement(DoStatementSyntax node)
		{
			base.VisitDoStatement(node);
		}

		public override void VisitForStatement(ForStatementSyntax node)
		{
			base.VisitForStatement(node);
		}

		public override void VisitForEachStatement(ForEachStatementSyntax node)
		{
			base.VisitForEachStatement(node);
		}

		public override void VisitUsingStatement(UsingStatementSyntax node)
		{
			base.VisitUsingStatement(node);
		}

		public override void VisitFixedStatement(FixedStatementSyntax node)
		{
			base.VisitFixedStatement(node);
		}

		public override void VisitCheckedStatement(CheckedStatementSyntax node)
		{
			base.VisitCheckedStatement(node);
		}

		public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
		{
			base.VisitUnsafeStatement(node);
		}

		public override void VisitLockStatement(LockStatementSyntax node)
		{
			base.VisitLockStatement(node);
		}

		public override void VisitIfStatement(IfStatementSyntax node)
		{
			base.VisitIfStatement(node);
		}

		public override void VisitElseClause(ElseClauseSyntax node)
		{
			base.VisitElseClause(node);
		}

		public override void VisitSwitchStatement(SwitchStatementSyntax node)
		{
			base.VisitSwitchStatement(node);
		}

		public override void VisitSwitchSection(SwitchSectionSyntax node)
		{
			base.VisitSwitchSection(node);
		}

		public override void VisitSwitchLabel(SwitchLabelSyntax node)
		{
			base.VisitSwitchLabel(node);
		}

		public override void VisitTryStatement(TryStatementSyntax node)
		{
			base.VisitTryStatement(node);
		}

		public override void VisitCatchClause(CatchClauseSyntax node)
		{
			base.VisitCatchClause(node);
		}

		public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
		{
			base.VisitCatchDeclaration(node);
		}

		public override void VisitFinallyClause(FinallyClauseSyntax node)
		{
			base.VisitFinallyClause(node);
		}

		public override void VisitCompilationUnit(CompilationUnitSyntax node)
		{
			foreach (var usingSyntax in node.Usings)
				base.Visit(usingSyntax);

			builder.AppendLine("");

			foreach (var member in node.Members)
				base.Visit(member);
		}

		public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
		{
			base.VisitExternAliasDirective(node);
		}

		public override void VisitUsingDirective(UsingDirectiveSyntax node)
		{
			builder.AppendLine(node.ToString());
		}

		public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
		{
			builder.AppendLine(node.NamespaceKeyword + " " + node.Name);
			builder.AppendLine(node.OpenBraceToken.ToString());
			builder.IncreaseIndent();
			foreach (var member in node.Members)
			{
				base.Visit(member);
			}
			builder.DecreaseIndent();
			builder.AppendLine(node.CloseBraceToken.ToString());
		}

		public override void VisitAttributeList(AttributeListSyntax node)
		{
			base.VisitAttributeList(node);
		}

		public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
		{
			base.VisitAttributeTargetSpecifier(node);
		}

		public override void VisitAttribute(AttributeSyntax node)
		{
			base.VisitAttribute(node);
		}

		public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
		{
			base.VisitAttributeArgumentList(node);
		}

		public override void VisitAttributeArgument(AttributeArgumentSyntax node)
		{
			base.VisitAttributeArgument(node);
		}

		public override void VisitNameEquals(NameEqualsSyntax node)
		{
			base.VisitNameEquals(node);
		}

		public override void VisitTypeParameterList(TypeParameterListSyntax node)
		{
			base.VisitTypeParameterList(node);
		}

		public override void VisitTypeParameter(TypeParameterSyntax node)
		{
			base.VisitTypeParameter(node);
		}

		public override void VisitClassDeclaration(ClassDeclarationSyntax node)
		{
			var header = string.Join(" ",
				string.Join(" ", node.Modifiers),
				node.Keyword,
				node.Identifier);
			builder.AppendLine(header);
			builder.AppendLine(node.OpenBraceToken.ToString());
			builder.IncreaseIndent();

			foreach (var member in node.Members)
				base.Visit(member);

			builder.DecreaseIndent();
			builder.AppendLine(node.CloseBraceToken.ToString());
		}

		public override void VisitStructDeclaration(StructDeclarationSyntax node)
		{
			base.VisitStructDeclaration(node);
		}

		public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
		{
			base.VisitInterfaceDeclaration(node);
		}

		public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
		{
			base.VisitEnumDeclaration(node);
		}

		public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
		{
			base.VisitDelegateDeclaration(node);
		}

		public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
		{
			base.VisitEnumMemberDeclaration(node);
		}

		public override void VisitBaseList(BaseListSyntax node)
		{
			base.VisitBaseList(node);
		}

		public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
		{
			base.VisitTypeParameterConstraintClause(node);
		}

		public override void VisitConstructorConstraint(ConstructorConstraintSyntax node)
		{
			base.VisitConstructorConstraint(node);
		}

		public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
		{
			base.VisitClassOrStructConstraint(node);
		}

		public override void VisitTypeConstraint(TypeConstraintSyntax node)
		{
			base.VisitTypeConstraint(node);
		}

		public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
		{
			base.VisitFieldDeclaration(node);
		}

		public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
		{
			base.VisitEventFieldDeclaration(node);
		}

		public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
		{
			base.VisitExplicitInterfaceSpecifier(node);
		}

		public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
		{
			var modifiers = string.Join(" ", node.Modifiers);
			var nameAndArguments = node.Identifier.ToString() + node.ParameterList;
			var signature = string.Join(" ", modifiers, node.ReturnType, nameAndArguments);
			builder.AppendLine(signature);
			base.Visit(node.Body);
		}

		public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
		{
			base.VisitOperatorDeclaration(node);
		}

		public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
		{
			base.VisitConversionOperatorDeclaration(node);
		}

		public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
		{
			base.VisitConstructorDeclaration(node);
		}

		public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
		{
			base.VisitConstructorInitializer(node);
		}

		public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
		{
			base.VisitDestructorDeclaration(node);
		}

		public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
		{
			base.VisitPropertyDeclaration(node);
		}

		public override void VisitEventDeclaration(EventDeclarationSyntax node)
		{
			base.VisitEventDeclaration(node);
		}

		public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
		{
			base.VisitIndexerDeclaration(node);
		}

		public override void VisitAccessorList(AccessorListSyntax node)
		{
			base.VisitAccessorList(node);
		}

		public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
		{
			base.VisitAccessorDeclaration(node);
		}

		public override void VisitParameterList(ParameterListSyntax node)
		{
			base.VisitParameterList(node);
		}

		public override void VisitBracketedParameterList(BracketedParameterListSyntax node)
		{
			base.VisitBracketedParameterList(node);
		}

		public override void VisitParameter(ParameterSyntax node)
		{
			base.VisitParameter(node);
		}

		public override void VisitIncompleteMember(IncompleteMemberSyntax node)
		{
			base.VisitIncompleteMember(node);
		}

		public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
		{
			base.VisitSkippedTokensTrivia(node);
		}

		public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
		{
			base.VisitDocumentationCommentTrivia(node);
		}

		public override void VisitXmlElement(XmlElementSyntax node)
		{
			base.VisitXmlElement(node);
		}

		public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node)
		{
			base.VisitXmlElementStartTag(node);
		}

		public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node)
		{
			base.VisitXmlElementEndTag(node);
		}

		public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node)
		{
			base.VisitXmlEmptyElement(node);
		}

		public override void VisitXmlName(XmlNameSyntax node)
		{
			base.VisitXmlName(node);
		}

		public override void VisitXmlPrefix(XmlPrefixSyntax node)
		{
			base.VisitXmlPrefix(node);
		}

		public override void VisitXmlAttribute(XmlAttributeSyntax node)
		{
			base.VisitXmlAttribute(node);
		}

		public override void VisitXmlText(XmlTextSyntax node)
		{
			base.VisitXmlText(node);
		}

		public override void VisitXmlCDataSection(XmlCDataSectionSyntax node)
		{
			base.VisitXmlCDataSection(node);
		}

		public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
		{
			base.VisitXmlProcessingInstruction(node);
		}

		public override void VisitXmlComment(XmlCommentSyntax node)
		{
			base.VisitXmlComment(node);
		}

		public override void VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
		{
			base.VisitIfDirectiveTrivia(node);
		}

		public override void VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
		{
			base.VisitElifDirectiveTrivia(node);
		}

		public override void VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
		{
			base.VisitElseDirectiveTrivia(node);
		}

		public override void VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
		{
			base.VisitEndIfDirectiveTrivia(node);
		}

		public override void VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
		{
			base.VisitRegionDirectiveTrivia(node);
		}

		public override void VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
		{
			base.VisitEndRegionDirectiveTrivia(node);
		}

		public override void VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
		{
			base.VisitErrorDirectiveTrivia(node);
		}

		public override void VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
		{
			base.VisitWarningDirectiveTrivia(node);
		}

		public override void VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
		{
			base.VisitBadDirectiveTrivia(node);
		}

		public override void VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
		{
			base.VisitDefineDirectiveTrivia(node);
		}

		public override void VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
		{
			base.VisitUndefDirectiveTrivia(node);
		}

		public override void VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
		{
			base.VisitLineDirectiveTrivia(node);
		}

		public override void VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
		{
			base.VisitPragmaWarningDirectiveTrivia(node);
		}

		public override void VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
		{
			base.VisitPragmaChecksumDirectiveTrivia(node);
		}

		public override void VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
		{
			base.VisitReferenceDirectiveTrivia(node);
		}

		public override void VisitToken(SyntaxToken token)
		{
			base.VisitToken(token);
		}

		public override void VisitLeadingTrivia(SyntaxToken token)
		{
			base.VisitLeadingTrivia(token);
		}

		public override void VisitTrailingTrivia(SyntaxToken token)
		{
			base.VisitTrailingTrivia(token);
		}

		public override void VisitTrivia(SyntaxTrivia trivia)
		{
			base.VisitTrivia(trivia);
		}

		public override string ToString()
		{
			return base.ToString();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
