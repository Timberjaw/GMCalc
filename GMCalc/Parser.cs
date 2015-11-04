using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Threading;

namespace GMCalc
{
    public class Parser
    {
        Lexer lexer;
        private int tick = 0;
        private Int32 result = 0;
        private System.Random rand;
        private int inputLength;
        private BackgroundWorker worker;
        public Hashtable references;

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      Parser (constructor)
        //
        // Implements
        //      Saves the lexer object in this parser instance.
        //
        public Parser(Lexer l)
        {
            lexer = l;
            rand = new Random((Int32)System.DateTime.Now.Ticks);
            references = new Hashtable();
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      getSeed
        //
        // Implements
        //      Retrieves the last used random seed value
        //
        public Int32 getSeed()
        {
            return rand.Next();
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      Parse
        //
        // Implements
        //      Four-function calculator with parentheses.
        //
        //      Term -      T -> T + F | T - F | F
        //      Factor -    F -> F * P | F / P | P
        //      Die Roll -  D -> d(T) | d(n)
        //      Reference - R -> T | n
        //      Prog -      P -> ( T ) | FD | D | R | n
        //
        //      The top-level function Parse() make suse of helper functions RdT(), RdF() and
        //      which implement each of the rules above.
        //
        public String Parse(String input, BackgroundWorker w, DoWorkEventArgs e)
        {
            Int32 result = 0;
            lexer.setInput(input);

            this.worker = w;

            inputLength = input.Length;

            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                }

                this.lex();

                switch (lexer.getToken())
                {
                    case Token.EOF:
                    case Token.EOL:
                        this.result = result;
                        return("= " + result);

                    default:
                        tick++;
                        Console.WriteLine("" + tick + ": Parse() -> Running RdT()");
                        result = RdT();
                        this.result = result;
                        return("= " + result);
                }
            }
        }

        public Int32 getResult()
        {
            return this.result;
        }

        private void lex()
        {
            lexer.lex();
            this.worker.ReportProgress(
                Math.Min(100, (int)((lexer.index * 100 / this.inputLength * 100) / 100))
            );
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      RdT
        //
        // Implements
        //      The production rule:   T -> T + F | T - F | F
        //
        Int32 RdT()
        {
            tick++; Console.WriteLine("" + tick + ": RdT() -> Running RdF()");
            Int32 result = RdF();
            tick++; Console.WriteLine("" + tick + ": RdT() -> Got '" + result + "' from RdF()");

            //this.lex();

            while (true)
            {
                switch (lexer.getToken())
                {
                    case Token.PLUS:
                        this.lex();
                        tick++; Console.WriteLine("" + tick + ": RdT() -> Running RdF() for PLUS");
                        result += RdF();
                        continue;

                    case Token.MINUS:
                        this.lex();
                        tick++; Console.WriteLine("" + tick + ": RdT() -> Running RdF() for MINUS");
                        result -= RdF();
                        continue;

                    default:
                        return result;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      RdF
        //
        // Implements
        //      The production rule:  F -> FdP | F ^ P | F * P | F / P | P
        //
        Int32 RdF()
        {
            tick++; Console.WriteLine("" + tick + ": RdF() -> Running RdP()");
            Int32 result = RdP();
            tick++; Console.WriteLine("" + tick + ": RdF() -> Got '" + result + "' from RdP()");

            while (true)
            {
                switch (lexer.getToken())
                {
                    case Token.DIE:
                        this.lex();
                        tick++; Console.WriteLine("" + tick + ": RdP() -> Running RdD("+result+")");
                        result = RdD(result);
                        tick++; Console.WriteLine("" + tick + ": RdP() -> Got '" + result + "' from RdD()");
                        break;

                    case Token.EXPONENT:
                        this.lex();
                        tick++; Console.WriteLine("" + tick + ": RdP() -> Running RdP() for EXPONENT");
                        result = (Int32)Math.Pow((double)result, RdP());
                        tick++; Console.WriteLine("" + tick + ": RdF() -> Got '" + result + "' from RdP()");
                        continue;

                    case Token.TIMES:
                        this.lex();
                        tick++; Console.WriteLine("" + tick + ": RdP() -> Running RdP() for TIMES");
                        result = result * RdP();
                        tick++; Console.WriteLine("" + tick + ": RdF() -> Got '" + result + "' from RdP()");
                        continue;

                    case Token.DIVIDE:
                        this.lex();
                        tick++; Console.WriteLine("" + tick + ": RdP() -> Running RdP() for DIVIDE");
                        result /= RdP();
                        tick++; Console.WriteLine("" + tick + ": RdF() -> Got '" + result + "' from RdP()");
                        continue;

                    default:
                        return result;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      RdD
        //
        // Implements
        //      The production rule:  D -> d(T) | d(n)
        //

        Int32 getDieRolls(Int32 sides, Int32 dice)
        {
            Int32 result = 0;
            for (int i = 0; i < dice; i++)
            {
                if ((dice / 10) > 0)
                {
                    if (i % (int)(dice / 10) == 0)
                    {
                        this.worker.ReportProgress(
                            (int)(((double)i / (double)dice) * 100.0)
                        );
                    }
                }
                result += rand.Next((Int32)sides) + 1;
            }

            return result;
        }

        Int32 RdD(Int32 dieMax)
        {
            Int32 result;

            switch (lexer.getToken())
            {
                case Token.NUMBER:
                    if (lexer.getNumber() > 0)
                    {
                        tick++; Console.WriteLine("" + tick + ": RdD() -> Running getDieRolls() for " + (Int32)lexer.getNumber() + " sides and " + dieMax + " rolls");
                        result = getDieRolls((Int32)lexer.getNumber(), dieMax); //(rand.Next((Int32)lexer.getNumber()) + 1);
                    }
                    else
                    {
                        result = 0;
                    }
                    break;

                case Token.LPAREN:
                    this.lex();
                    tick++; Console.WriteLine("" + tick + ": RdD() LPAREN -> Running RdT() for subexpression");
                    result = RdT();
                    tick++; Console.WriteLine("" + tick + ": RdD() LPAREN -> Got " + result + ", running getDieRolls() for " + result + " sides and " + dieMax + " rolls");
                    result = getDieRolls(result, dieMax);

                    if (lexer.getToken() != Token.RPAREN)
                    {
                        Console.WriteLine("RdD LPAREN -> Error: missing closing ')', found '" + lexer.getToken() + "' instead; current #: " + lexer.getNumber() + "");
                        throw new System.Exception();
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Expression in RdD: " + lexer.getToken());
                    throw new System.Exception();
            }

            tick++; Console.WriteLine("" + tick + ": RdD -> Result: " + result);
            this.lex();
            return result;
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      RdR
        //
        // Implements
        //      The production rule:  R -> T | n
        //
        Int32 RdR()
        {
            Int32 result = 0;

            tick++; Console.WriteLine("" + tick + ": RdR() -> Getting ref to '" + lexer.getReference() + "' from lexer");
            if (references.ContainsKey(lexer.getReference()))
            {
                // Update lexer input
                tick++; Console.WriteLine("" + tick + ": RdR() -> Replacing '" + lexer.getReference() + "' with '" + Convert.ToString(references[lexer.getReference()]) + "' in lexer input");
                lexer.input = lexer.input.Replace(lexer.getReference(), Convert.ToString(references[lexer.getReference()]));
                if (lexer.getReference().Equals("Last"))
                {
                    lexer.cleanInput = lexer.cleanInput.Replace(lexer.getReference(), Convert.ToString(references[lexer.getReference()]));
                }
                tick++; Console.WriteLine("" + tick + ": RdR() -> New lexer input: " + lexer.input);
                tick++; Console.WriteLine("" + tick + ": RdR() -> New clean lexer input: " + lexer.cleanInput);

                // Update lexer index and lastchar
                lexer.index -= (lexer.getReference().Length);
                lexer.lastchar = lexer.input[lexer.index-1];

                Console.WriteLine(lexer.index + " | Type: " + lexer.getToken());

                // Lex
                this.lex();
                Console.WriteLine(lexer.index + " | Type: " + lexer.getToken());

                // Get result from RdT
                result = RdT();
            }
            else
            {
                tick++; Console.WriteLine("" + tick + ": RdR() -> reference invalid!");
                return 0;
                //throw new System.Exception();
            }

            return result;
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      RdP
        //
        // Implements
        //      The production rule:  P -> ( T ) | D | n
        //
        Int32 RdP()
        {
            Int32 result;

            switch (lexer.getToken())
            {
                case Token.DIE:
                    this.lex();
                    tick++; Console.WriteLine("" + tick + ": RdP() -> Running RdD(1)");
                    result = RdD(1);
                    tick++; Console.WriteLine("" + tick + ": RdP() -> Got '" + result + "' from RdD()");
                    break;

                case Token.LPAREN:
                    this.lex();
                    tick++; Console.WriteLine("" + tick + ": RdP() -> Running RdT()");
                    result = RdT();
                    tick++; Console.WriteLine("" + tick + ": RdP() -> Got '" + result + "' from RdT()");
                    if (lexer.getToken() != Token.RPAREN)
                    {
                        Console.WriteLine("Error: missing closing ')', found '" + lexer.getToken() + "' instead; current #: " + lexer.getNumber() + "");
                        throw new System.Exception();
                    }
                    this.lex();
                    break;

                case Token.NUMBER:
                    result = (Int32)lexer.getNumber();
                    this.lex();
                    if (lexer.getToken() == Token.DIE)
                    {
                        System.Console.WriteLine("Next is DIE");
                        this.lex();
                        result = RdD(result);
                    }
                    System.Console.WriteLine("" + result);
                    break;

                case Token.REF:
                    result = RdR();
                    tick++; Console.WriteLine("" + tick + ": RdP() -> Got '" + result + "' from RdR(), next: " + lexer.getToken());
                    break;

                default:
                    Console.WriteLine("Invalid Expression in RdP");
                    throw new System.Exception();
            }

            return result;
        }

    }
}
