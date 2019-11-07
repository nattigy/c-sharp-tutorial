using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Operators
    {
        string[] ops = new string[10];
        public void push(string chr)
        {
            ops[ops.Length - 1] = chr;
        }

        public string pop()
        {
            string val = ops[ops.Length - 1];
            ops[ops.Length - 1] = null;
            return val;
        }
    }
}
