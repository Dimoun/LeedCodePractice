using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classisc
{
    public class Classics_20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            if (s.Length == 1)
                return false;
            for(int i=0; i<s.Length; i++)
            {
                if(s[i] == '('|| s[i] == '['|| s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;
                    char ch = stack.Peek();
                    switch (s[i])
                    {
                        case ')':
                            if (ch != '(')
                            {
                                return false;
                            }
                            {
                                stack.Pop();
                            }
                            break;
                        case ']':
                            if (ch != '[')
                            {
                                return false;
                            }
                            else
                            {
                                stack.Pop();
                            }
                            break;
                        case '}':
                            if (ch != '{')
                            {
                                return false;
                            }
                            else
                            {
                                stack.Pop();
                            }
                            break;
                    }
                }
            }
            return stack.Count == 0 ? true : false ;
        }
    }
}
