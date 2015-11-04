using System;
using System.Collections.Generic;
using System.Text;

// Thanks to: http://www.cl.cam.ac.uk/teaching/2004/CompConstr/NEJ/
// For their C# Recursive Descent Parser example

namespace GMCalc
{
    public enum Token
    {
        NO_TOK,             // NO TOKEN
        EOF,                // END OF FILE
        EOL,                // END OF LINE/STRING
        PLUS,               // + (Operator: binary)
        MINUS,              // - (Operator: binary)
        TIMES,              // * (Operator: binary)
        DIVIDE,             // / (Operator: binary)
        MODULUS,            // % (Operator: binary)
        EXPONENT,           // ^ (Operator: binary)
        COMPARE_EQ,         // = (Operator: binary)
        COMPARE_GT,         // > (Operator: binary)
        COMPARE_LT,         // < (Operator: binary)
        COMPARE_GE,         // >= (Operator: binary)
        COMPARE_LE,         // <= (Operator: binary)
        LPAREN,             // ( (Left Parentheses)
        RPAREN,             // ) (Right Parentheses)
        DIE,                // dn, Dn (die designation and number of faces)
        EXPR,               // (...) (subexpression)
        NUMBER,             // n (raw value number)
        REF                 // r (a reference string)
    }

    /*class Token
    {
    }*/
}
