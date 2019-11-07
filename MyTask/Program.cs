using System;

namespace MyTask
{
    class Program
    {
        
        static int Test(string line,int i)
        {
            int start_symbol = i;
            bool result = true;
              int number=1;
            
            if(line[i]=='0' && line[i+1]=='1')
            {
                i=i+2;
                while (line[i] != '0')
                {
                    i++;
                    number++;
                };
            }
            if(number%2==0)
            start_symbol = start_symbol + (number + 2);

            return start_symbol;

        }

       static void Search(string chain)
        {
            bool start = true;
            string line = chain;
            int length = line.Length;
            int[] mas = new int[length*2];
            if(line=="")
            {
                Console.WriteLine("no chain");
                start = false;
            }

            for (int i = 0; i < length; i++)
            {
                if (line[i] == '1' || line[i] == '0')
                {
                    start = true;
                }
                else
                {
                    Console.WriteLine("Wrong alphabet");
                    start = false;
                    break;
                }
            }
            if(start==true)
            {
                
                for (int i=0;i<length-3;i++)
                {
                    int start_symbol = 0;
                    int end_symbol = 0;

                    int result = Test(line, i);
                    if(result!=(i))
                    {
                          start_symbol = i+1;
                          end_symbol =result;
                       
                            Console.WriteLine(start_symbol);
                            Console.WriteLine(end_symbol);
                        
                    }
                      
                }

            }

        }

        static void Main(string[] args)
        {

            string chain=Console.ReadLine();
            Search(chain);

        }
    }
}
