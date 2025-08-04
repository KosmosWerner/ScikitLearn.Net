using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;

namespace ScikitLearn.Signatures.Analyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class SignaturesAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticIdInvalidTarget = "OneOfAttributeInvalidTarget";
        public const string DiagnosticIdMissing = "OneOfAttributeMissing";

        private static readonly LocalizableString TitleInvalidTarget = "Invalid OneOf usage";
        private static readonly LocalizableString MessageInvalidTarget = "[OneOf<>] can only be applied to parameters of type 'object' or 'object?'";

        private static readonly LocalizableString TitleMissing = "Missing OneOf attribute";
        private static readonly LocalizableString MessageMissing = "Parameters of type 'object' or 'object?' must have the [OneOf<>] attribute";

        private const string Category = "Design";

        private static readonly DiagnosticDescriptor RuleInvalidTarget = new DiagnosticDescriptor(
            DiagnosticIdInvalidTarget,
            TitleInvalidTarget,
            MessageInvalidTarget,
            Category,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true
        );

        private static readonly DiagnosticDescriptor RuleMissing = new DiagnosticDescriptor(
            DiagnosticIdMissing,
            TitleMissing,
            MessageMissing,
            Category,
            DiagnosticSeverity.Error,
            isEnabledByDefault: true
        );

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics =>
                ImmutableArray.Create(RuleInvalidTarget, RuleMissing);

        public override void Initialize(AnalysisContext context)
        {
            context.EnableConcurrentExecution();
            context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

            // Validate attributes usage
            context.RegisterSyntaxNodeAction(AnalyzeAttribute, SyntaxKind.Attribute);

            // Validate parameters
            context.RegisterSyntaxNodeAction(AnalyzeParameter, SyntaxKind.Parameter);
        }

        /// <summary>
        /// Ensures that [OneOf<>] is only applied to parameters of type object/object?.
        /// </summary>
        private static void AnalyzeAttribute(SyntaxNodeAnalysisContext context)
        {
            var attributeNode = (AttributeSyntax)context.Node;

            var attributeSymbol = context.SemanticModel.GetSymbolInfo(attributeNode).Symbol;
            if (attributeSymbol?.ContainingType?.Name != "OneOfAttribute") return;

            if (!(attributeNode.Parent?.Parent is ParameterSyntax parameter))
                return;

            var parameterType = context.SemanticModel.GetTypeInfo(parameter.Type).Type;
            if (parameterType == null) return;

            bool isObjectType = parameterType.SpecialType == SpecialType.System_Object;
            if (!isObjectType)
            {
                var diagnostic = Diagnostic.Create(RuleInvalidTarget, attributeNode.GetLocation());
                context.ReportDiagnostic(diagnostic);
            }
        }

        /// <summary>
        /// Ensures that parameters of type object/object? have the [OneOf<>] attribute.
        /// </summary>
        private static void AnalyzeParameter(SyntaxNodeAnalysisContext context)
        {
            var parameterNode = (ParameterSyntax)context.Node;
            var parameterType = context.SemanticModel.GetTypeInfo(parameterNode.Type).Type;
            if (parameterType == null) return;

            if (parameterType.SpecialType != SpecialType.System_Object) return;

            bool hasAllowedTypes = parameterNode.AttributeLists
                .SelectMany(a => a.Attributes)
                .Any(attr =>
                {
                    var symbol = context.SemanticModel.GetSymbolInfo(attr).Symbol;
                    return symbol?.ContainingType?.Name == "OneOfAttribute";
                });

            if (!hasAllowedTypes)
            {
                var diagnostic = Diagnostic.Create(RuleMissing, parameterNode.Identifier.GetLocation());
                context.ReportDiagnostic(diagnostic);
            }
        }
    }
}
