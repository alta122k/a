using System.Diagnostics;
using System;
using System.Collections;

namespace New_folder__2_
{
    class node{
       public string ch;
       public node pnext; 
    }
    class Char
    {
        string i;
    }
    class stack
    {
        public node phead;
        public node GetNode(string s)
        {
            
            node P = new node();
            P.ch = s;
            P.pnext = null;
            return P;
        } 
        public stack()
        {
            phead=null;
        }
        public stack(string bieuthuc)
        {
               
               
                Stack stack = new Stack();
     
                foreach (char i in bieuthuc)
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

    
    class Program
    {
        static void Main(string[] args)
        {
           
            //  Queue MyQueue = new Queue(); 

            //   foreach (char i in Console.ReadLine())
            //     {
            //         if (i == '(')
            //         {
            //               MyQueue.Enqueue(i);
            //         }
            //         else if (i == ')')
            //         {
            //             if(MyQueue.Count==0)
            //             { 
            //                 MyQueue.Enqueue(i);
            //                 break;
            //             }
                        
            //             if (MyQueue != null)
            //             {
            //                MyQueue.Dequeue();
            //             }
            //             // else
            //             // {
            //             //     stack.Push(i);

            //             // }
            //         }

            //     }
             
            //     if (MyQueue.Count !=0)
            //         Console.WriteLine("false");
            //     else
            //     {
            //         Console.WriteLine("true");
            //     }



            while (true)
            { 
                Console.WriteLine("nhap");
                stack s=new stack(Console.ReadLine());

            }
          

        }
    }
}
