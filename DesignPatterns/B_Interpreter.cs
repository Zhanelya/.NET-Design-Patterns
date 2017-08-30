using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class B_Interpreter
    {
        public void BInterpreter()
        {
            Context context = new Context();



            // Usually a tree 

            ArrayList list = new ArrayList();



            // Populate 'abstract syntax tree' 

            list.Add(new TerminalExpression());

            list.Add(new NonterminalExpression());

            list.Add(new TerminalExpression());

            list.Add(new TerminalExpression());



            // Interpret

            foreach (AbstractExpression exp in list)

            {

                exp.Interpret(context);

            }



            // Wait for user

            Console.ReadKey();
        }
    }
    class Context

    {

    }



    /// <summary>

    /// The 'AbstractExpression' abstract class

    /// </summary>

    abstract class AbstractExpression

    {

        public abstract void Interpret(Context context);

    }



    /// <summary>

    /// The 'TerminalExpression' class

    /// </summary>

    class TerminalExpression : AbstractExpression

    {

        public override void Interpret(Context context)

        {

            Console.WriteLine("Called Terminal.Interpret()");

        }

    }



    /// <summary>

    /// The 'NonterminalExpression' class

    /// </summary>

    class NonterminalExpression : AbstractExpression

    {

        public override void Interpret(Context context)

        {

            Console.WriteLine("Called Nonterminal.Interpret()");

        }

    }
}
