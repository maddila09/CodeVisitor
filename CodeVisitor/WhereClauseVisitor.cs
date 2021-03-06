using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace CodeVisitor
    {
        class WhereClauseVisitor : CSharpSyntaxRewriter
        {
            public WhereClauseVisitor()
            {
                Classes = new List<WhereClauseSyntax>();
            }

            public List<WhereClauseSyntax> Classes { get; set; }

            public override SyntaxNode VisitWhereClause(WhereClauseSyntax node)
            {
                node = (WhereClauseSyntax)base.VisitWhereClause(node);
                Classes.Add(node);
                return node;
            }
        }
    }