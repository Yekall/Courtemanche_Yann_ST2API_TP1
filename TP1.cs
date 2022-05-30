using System;
using System.IO;
using System.Text.Json.Serialization;




namespace TP1_Application
{
    class Program
    {
        public static void Ex1_1()
        {
            for (int i=0; i<=10;i++){
                Console.WriteLine("Table of ", i);
                for (int j=0; j<=10;j++){
                    Console.WriteLine("{0}x{1}={2}",i,j,(i*j));
                }
            }
        }
        public static void Ex1_2()
        {
            for (int i=0; i<=10;i++){
                Console.WriteLine("Table of ", i);
                for (int j=0; j<=10;j++){
                    if (i*j % 2 == 1 )
                    {
                        Console.WriteLine("{0}x{1}={2}",i,j,(i*j));
                    }
                }
            }
        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static void Ex1_3()
        {
            int table = AskUserForParameter();
            Console.WriteLine("Table of ", table);
            for (int j=0; j<=10;j++){
                Console.WriteLine("{0}x{1}={2}",table,j,(table*j));
            }
        }

        public static void Ex2_1()
        {
            for (int i = 2; i <= 1000; i++)
            {
                if (VerifPrime(i))
                {
                    Console.WriteLine(i);
                }
                    
            }
        }

        public static bool VerifPrime(int n)
        {
            for (int i=2; i <= n-1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        public static void Ex2_2(int n)
        {
            long a = 0;
            long b = 1;
            long c = 0;
            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }

        public static void Ex2_3(int n,int i)
        {
            if (i <= 25)
            {
                n = n * i;
                i++;
                Ex2_3(n,i);
            }
            else
            {
                Console.WriteLine(n);
            }
        }

        private static int PowerFunction(int x)
        {
            return (int) (Math.Pow(x, 2) - 4);
        }

        public static void Ex3()
        {
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(10/PowerFunction(i));
                }
                catch 
                {
                    Console.WriteLine("C'est dla D");
                    
                }
            }
        }

        public static void Ex4()
        {
            int m = AskUserForParameter();
            int n = AskUserForParameter()-1;
            for (int i = 0; i <= n; i++)
            {
                
                for (int j = 0; j < m; j++)
                {
                    if (((i == 0)|(i == n))  & ((j==0)|(j==m-1)))
                    {
                        Console.Write("0");
                    }
                    else if (((i == 0)|(i== n)) & ((j!=0)&(j!=m-1)))
                    {
                        Console.Write("-");
                    }
                    else if (((i != 0)&(i!= n)) & ((j==0)|(j==m-1)))
                    {
                        Console.Write("|");
                    }
                    else if ((i % 3 == 1) & (j % 3 == 1))
                    {
                        Console.Write("*");
                    }
                    else if ((i % 3 == 0) & (j % 3 == 0))
                    {
                        Console.Write("*");
                    }
                    else if ((i % 3 == 2) & (j % 3 == 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }

       
        
        public static void Ex5()
        {
            int s = 6;
            int sb = s * 2 - 1;
            for (int i = 0;i < s;i++)
            {

                int cv = (sb - i * 2 ) / 2;
                for (int j = 0; j < sb; j++)
                {
                    if ((j < cv) || (j >= sb-cv))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        if ((i%3 == j%3))
                        {
                            Random rnd = new Random();
                            int x = rnd.Next();
                            if (x% 2 == 0)
                            {
                                Console.Write("o");
                            }
                            else
                            {
                                Console.Write("i");
                            }
                        }
                            else
                        {
                            Console.Write("*");
                        }
                            
                    }
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < sb+1; i++)
            {
                if ((i == sb/2-1) || (i == sb/2+1))
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
            
        
    

            
            
        
        
        static void Main(string[] arg)
        {
            
            Ex1_1();
            Ex1_2();
            Ex1_3();
            Ex2_1();
            Ex2_2(10);
            Ex2_3(1,1);
            Ex3();
            Ex4();
            Ex5();
        }
    }
}