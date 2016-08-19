using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace BuildBreaker2
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class BuildBreakerAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "BuildBreaker";

        // You can change these strings in the Resources.resx file. If you do not want your analyzer to be localize-able, you can use regular strings for Title and MessageFormat.
        // See https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Localizing%20Analyzers.md for more on localization
        private static readonly LocalizableString Title = "SPAM!!";
        private static readonly LocalizableString MessageFormat = "SPAM SPAM SPAM!!";
        private static readonly LocalizableString Description = "SPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAM!";
        private const string Category = "Nosense";

        private static DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Error, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeNode, Enum.GetValues(typeof(SyntaxKind)).Cast<SyntaxKind>().ToArray());
        }

        private static void AnalyzeNode(SyntaxNodeAnalysisContext context)
        {
            // TODO: Replace the following code with your own analysis, generating Diagnostic objects for any issues you find
            // For all such symbols, produce a diagnostic.
            var diagnostic = Diagnostic.Create(Rule, context.Node.GetLocation(), context.Node.ToString());

            context.ReportDiagnostic(diagnostic);
        }
    }
}
