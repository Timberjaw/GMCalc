using System;
using System.Collections.Generic;
using System.Text;

namespace GMCalc
{
    public class Lexer
    {
        public int lastchar;
        public int index;
        public Int32 number;
        public String reference;
        public Token token;
        public String input;
        public String cleanInput;

        ////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      Lexer (constructor)
        //
        // Implements
        //      Initialises a lexer object, clearing number and setting the first character
        //      to a space (will be consumed later).
        //
        public Lexer()
        {
            setInput("");
        }

        public void setInput(String s)
        {
            input = s + "\n";
            cleanInput = input;
            index = 0;
            lastchar = ' ';
            number = 0;
            reference = "";
            token = Token.NO_TOK;
        }

        ////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      lex
        //
        // Implements
        //      The lexer itself.  Each call consumes characters from Console until a match
        //      the largest lexical item is found.  For most items this will be a single 
        //      character, but for numbers we keep consuming chars until either the next
        //      char is not a number (in which case we stop munching and return a NUMBER
        //      token), or the number that would be produced is just far too large to fit
        //      into the integer type we're using for numbers.
        //      Note: a future implementation might want to handle this second case a bit
        //      more elegantly than just maxing out.
        //
        public Token lex()
        {
            int nextchar;

            token = Token.NO_TOK;
            number = 0;

            while (token == Token.NO_TOK && (index < input.Length))
            {
                nextchar = input[index++];
                //Console.WriteLine("" + lastchar.ToString());
                //Console.WriteLine("->" + nextchar.ToString());

                switch (lastchar)
                {
                    // Catch end of input
                    case -1: token = Token.EOF; break;

                    // Operators and other tokens
                    case '+': token = Token.PLUS; break;
                    case '-': token = Token.MINUS; break;
                    case '*': token = Token.TIMES; break;
                    case '/': token = Token.DIVIDE; break;
                    case '^': token = Token.EXPONENT; break;
                    case '(': token = Token.LPAREN; break;
                    case ')': token = Token.RPAREN; break;
                    case ';': token = Token.EOL; break;

                    // Numbers.  Check for maximum
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        if (number <= (Int32.MaxValue / 10))
                            number = number * 10 + (Int32)(((Int32)lastchar) - '0');
                        else
                            number = Int32.MaxValue;

                        if (nextchar < '0' || nextchar > '9')
                            token = Token.NUMBER;
                        break;
                    
                    // Dice
                    case 'd':
                    case 'D':
                        if (!nextchar.Equals('(') && (nextchar < '0' || nextchar > '9'))
                        {
                            // Bad
                        } else
                        {
                            token = Token.DIE;
                        }
                        break;

                    // Consume everything else
                    default: break;
                }

                if (
                    ((lastchar >= 'A' && lastchar <= 'Z') || (lastchar >= 'a' && lastchar <= 'z')) &&
                    ((nextchar >= 'A' && nextchar <= 'Z') || (nextchar >= 'a' && nextchar <= 'z'))
                    )
                {
                    reference = Convert.ToChar(lastchar).ToString();
                    token = Token.REF;

                    while ((nextchar >= 'A' && nextchar <= 'Z') || (nextchar >= 'a' && nextchar <= 'z'))
                    {
                        reference = reference + Convert.ToChar(nextchar).ToString();
                        nextchar = input[index++];
                    }
                }

                lastchar = nextchar;
            }

            return token;
        }

        ////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      getNumber
        //
        // Implements
        //      Accessor method for number.
        //
        public Int32 getNumber() { return number; }

        ////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      getReference
        //
        // Implements
        //      Accessor method for reference.
        //
        public String getReference() { return reference; }

        ////////////////////////////////////////////////////////////////////////////////////
        //
        // Method
        //      getToken
        //
        // Implements
        //      Accessor method for token.
        //
        public Token getToken() { return token; }

    }
}
