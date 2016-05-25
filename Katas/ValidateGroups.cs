using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    // validate a string for correct groupings of (), {} and [], such that {[()]} = true, {[(])} = false
    public class ValidateGroups
    {
        char[] openers = new char[] { '[', '(', '{' };
        char[] closers = new char[] { ']', ')', '}' };

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            char[] a = s.ToCharArray();
            for (int i=0; i<a.Length; i++)
            {
                char c = a[i];
                int ix = Array.IndexOf(openers, c);
                if (ix > -1)
                {
                    stack.Push(closers[ix]);
                }
                else
                {
                    ix = Array.IndexOf(closers, c);
                    if (ix > -1)
                    {
                        if (stack.Count == 0) return false;
                        else
                        {
                            char closer = stack.Pop();
                            if (closer != c) return false;
                        }
                    }
                }
            }
            if (stack.Count > 0) return false;
            else return true;
        }
    }
}
