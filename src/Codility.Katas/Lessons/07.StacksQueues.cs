using System;
using System.Collections.Generic;

namespace Codility.Katas.Lessons
{
    // Stacks and Queues - https://app.codility.com/programmers/lessons/7-stacks_and_queues/
    public class StacksQueues
    {
        public static int Brackets(string s) {
            int result = 0;
            int n = s.Length;

            if (n == 0) {
                result = 1;
            } else {
                if (n % 2 == 0) {
                                            
                    string s1 = string.Empty;
                    for (int i = 0; i < n-1;)
                    {
                        char a = QueuePop(ref s);
                        char b = QueuePop(ref s);
                        if (IsProperlyNested(a, b)) {
                            i = 0;
                            while (s1 != string.Empty)
                            {
                                char c = StackPop(ref s1);
                                QueuePush(ref s, c);
                            }
                            n = s.Length;
                            result = n > 0 ? 0 : 1;
                        } else {
                            StackPush(ref s1, a);
                            QueuePush(ref s, b);
                            i++;
                        }
                    }
                }
            }

            return result;
        }

        private static bool IsProperlyNested(char a, char b) {
            bool result = false;
            switch (a) {
                case '(':
                    result = (b == ')');
                    break;
                case '[':
                    result = (b == ']');
                    break;
                case '{':
                    result = (b == '}');
                    break;
                default:
                    result = false;
                    break;
            }

            return result;
        }

        public static char StackPop(ref string s) {
            int n = s.Length;
            char c = '\0';
            
            if (n > 0) {
                c = s[n-1];
                s = s.Substring(0, n-1);
            }

            return c;
        }

        public static int StackPush(ref string s, char c) {
            int n = s.Length;
            char[] s1 = new char[n+1];

            for (int i = 0; i < n; i++)
            {
                s1[i] = s[i];
            }
            s1[n] = c;

            s = new string(s1);

            return n;
        }

        public static char QueuePop(ref string s) {
            int n = s.Length;
            char c = '\0';

            if (n > 0)
            {
                c = s[0];
                s = s.Substring(1, n-1);
            }

            return c;
        }

        public static int QueuePush(ref string s, char c) {
            int n = s.Length;
            char[] s1 = new char[n+1];
            
            s1[0] = c;
            for (int i = 0; i < n; i++)
            {
                s1[i+1] = s[i];
            }

            s = new string(s1);

            return 0;
        }

    }
}