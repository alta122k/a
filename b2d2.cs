using System.Diagnostics;
using System;
using System.Collections;
namespace New_folder__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("nhap");
                string lh = Console.ReadLine();
                Stack stack = new Stack();
     
                foreach (char i in lh)
                {
                    if (i == '(')
                    {
                          stack.Push(i);
                    }
                    else if (i == ')')
                    {
                        if(stack.Count==0)
                        { 
                            stack.Push(i);
                            break;
                        }
                        
                        if (stack != null)
                        {
                            stack.Pop();
                        }
                        // else
                        // {
                        //     stack.Push(i);

                        // }
                    }

                }
             
                if (stack.Count !=0)
                    Console.WriteLine("false");
                else
                {
                    Console.WriteLine("true");
                }

            }


        }
    }
}
