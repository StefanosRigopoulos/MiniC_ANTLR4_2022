using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniC
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader aStreamReader = new StreamReader(args[0]);
            AntlrInputStream antlrInputStream = new AntlrInputStream(aStreamReader);
            MiniCLexer lexer = new MiniCLexer(antlrInputStream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            MiniCParser parser = new MiniCParser(tokens);
            IParseTree tree = parser.compileUnit();
            Console.WriteLine(tree.ToStringTree());

            STPrinterVisitor stPrinter = new STPrinterVisitor();    // This prints the syntax tree (object).
            stPrinter.Visit(tree);  // We start from the root node of the syntax tree.

            ASTGenerator astGen = new ASTGenerator();   // This prints the abstract syntax tree.
            astGen.Visit(tree); // We start from the root node of the abstract syntax tree.

            MiniCASTBaseVisitor<int> dummyVisitor = new MiniCASTBaseVisitor<int>();
            dummyVisitor.Visit(astGen.MRoot);

            ASTPrinterVisitor astPrinter = new ASTPrinterVisitor("ast.dot");
            astPrinter.Visit(astGen.MRoot);

            MiniC2CGeneration cGeneration = new MiniC2CGeneration();
            cGeneration.Visit(astGen.MRoot);
            String cFileName = Path.GetFileNameWithoutExtension(args[0]);
            StreamWriter mir = new StreamWriter("mir.dot");
            cGeneration.MTranslatedFile.PrintStructure(mir);
            StreamWriter outCFile = new StreamWriter(@"D:\UOP\7th Semester\Compilers II\Laboratory\MiniC\Testbench\" + cFileName + ".c");
            cGeneration.MTranslatedFile.EmmitToFile(outCFile);
            outCFile.Close();
        }
    }
}
