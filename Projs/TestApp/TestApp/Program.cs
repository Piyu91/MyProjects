using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        /**********Swap two numbers with call be reference Function*****************/
        static void valueSwap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }

        static int facto(int n)
        {
         
            if (n == 1)
            {
              
                return 1;
            }
            else
            {
                return  n * facto(n-1);

            }

           

           
        }

        public static int LcmFunc( int fstNum, int secNum)
        {
            int a, b;
            if (fstNum > secNum)
            {
                a = fstNum;
                b = secNum;
            }
            else
            {
                a = secNum;
                b = fstNum;
            }

            for (int i = 1; i <= b; i++)
            {
                if ((a * i) % b == 0)
                {
                    return i * a;
                }
            }
            return b;
        }


        static void printAlphabet(int j)
        {
           
           

                if (j == 91)
                {
                    j = j + 6;
                }
                
              

               Console.WriteLine("{0}", Convert.ToChar(j));
            if(j <= 122) {
               printAlphabet(j+1);
            }


        }

        public static bool isArmstrong(int num)
        {
            int temp = num,r;
            int sum = 0;
            int numlength = noOfDigit(num);

            while (num > 0)
            {

                r = num % 10;
                sum = sum + Convert.ToInt32(Math.Pow(r, numlength));
                num = num / 10;
            }

            if (temp == sum)
            {

                return true;
            }
            return false;
        }


        public static int noOfDigit(int num)
        {
            int counter = 0;
            while (num > 0)
            {
                num = num / 10;
                counter++;
            }
            return counter;
        }





        static void Main(string[] args)
        {

            /*************Palindrom Number***************/

            //int a, b = 0, num,palindrome;

            //num = Convert.ToInt32( Console.ReadLine());
            //palindrome = num;

            //while (palindrome > 0)
            //{
            //    a = palindrome % 10;
            //    b = (b  * 10) + a;
            //    palindrome = palindrome / 10;
            //}

            //if (num == b)
            //{
            //    Console.WriteLine("Palindrome number is : {0}", b);
            //}
            //else
            //{
            //    Console.WriteLine("Not Palindrome number is : {0}", b);
            //}


            /********** Fibonacci****************************/

            /*int fibo1=0,fibo2=1, fibo3;
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write(fibo1 + " " );
            Console.Write(fibo2 + " ");
            
            for (int i = 0; i < num-2; i++)
            {
                fibo3 = fibo1 + fibo2;
                Console.Write(fibo3 + " ");
                fibo1 = fibo2;
                fibo2 = fibo3;



            }


            Console.ReadKey();*/


            /**********Swap two numbers with temp variable*****************/

            /*int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Value of a : {0}", a);
            Console.WriteLine("Value of b : {0}", b);
            Console.ReadKey();*/



            /**********Swap two numbers without temp variable*****************/

            /*int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Value of a : {0}", a);
            Console.WriteLine("Value of b : {0}", b);
            Console.ReadKey();*/



            /**********Swap two numbers with call be reference*****************/


            /*int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value of a before Swap: {0}", a);
            Console.WriteLine("Value of b before Swap: {0}", b);

            valueSwap(ref a, ref b);

            Console.WriteLine("Value of a After Swap: {0}", a);
            Console.WriteLine("Value of b After Swap: {0}", b);*/


            /***************even odd numbers*************/

            /*int a,n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number");

            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if(a%2 == 0)
                {
                    Console.WriteLine("Number is Even: {0}", a);
                }
                else
                {
                    Console.WriteLine("Number is odd: {0}", a);
                }
            }*/


            /**************Vowel search**************/

            /*char[] vArray = {'A', 'E', 'I', 'O', 'U'};
            char val = Convert.ToChar((Console.ReadLine()));
            val = char.ToUpper(val);


            if (vArray.Contains(val))
            {
                Console.WriteLine("Character is Vowel: {0}", val);
            }
            else
            {
                Console.WriteLine("Character is Consonent: {0}", val);
            }
            Console.ReadKey();*/


            /**************Largest Number**************/


            /*int n,largenum;
            Console.WriteLine("Please enter the Array size");
            n = Convert.ToInt32(Console.ReadLine());
            //int[] lnArray = new int[n];
            List<int> lnArray = new List<int>();

            for (int i = 0; i < n; i++)
            {
                //lnArray[i] = Convert.ToInt32(Console.ReadLine());
                lnArray.Add(Convert.ToInt32(Console.ReadLine()));
             
            }
           // lnArray = tmArray.ToArray();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array structure: {0}", lnArray[i]);
            }

           

            if (lnArray.Count > 0)
            {
                largenum = lnArray[0];
                for (int i = 1; i < lnArray.Count; i++)
                {
                    if (largenum < lnArray[i])
                    {
                        int temp = largenum;
                        largenum = lnArray[i];
                        lnArray[i] = temp;
                    }
                }

                Console.WriteLine("Largest Number: {0}", largenum);
            }*/


            /**************Second Largest Number**************/

            /* int n,temp;
             Console.WriteLine("Please enter the Array size");
             n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Please enter the Array number");

             List<int> lnarray = new List<int>();

             for (int i = 0; i < n; i++)
             {
                 lnarray.Add(Convert.ToInt32(Console.ReadLine()));
             }

             for (int i = 0; i < n; i++)
             {
                 for (int j = i+1; j< n; j++)
                 {
                     if(lnarray[i] < lnarray[j])
                     {
                         temp = lnarray[i];
                         lnarray[i] = lnarray[j];
                         lnarray[j] = temp;
                     }
                 }
             }

             Console.WriteLine("Second largest number {0}", lnarray[1]);*/



            /**************Leapyear**************/

            /* int year;
             year = Convert.ToInt32(Console.ReadLine());

             if ((year%4==0 && year%100!=0) || year%400 ==0)
             {
                 Console.WriteLine("Enter year is leap year {0}", year);
             }
             else
             {
                 Console.WriteLine("Enter year is not leap year {0}", year);
             }*/



            /***************ASCII Value******************/

            /*
            Console.WriteLine("Please enter a Character");
            char charVal = Convert.ToChar((Console.ReadLine()));
            byte[] asiiChar = Encoding.ASCII.GetBytes(charVal.ToString());

            Console.WriteLine("ASCII value of a Character {0}", asiiChar[0]);
            Console.ReadKey();*/





            /***************Absolute Value******************/

            /*Console.WriteLine("Please enter first value");
            int fstVal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Second value");
            int sectVal = Convert.ToInt32(Console.ReadLine());

            int absdiff = Math.Abs(fstVal - sectVal);

            Console.WriteLine("Absolute difference {0}", absdiff);
            Console.ReadKey();*/


            /***************Check numnber is character or number or symbol******************/

            /* Console.WriteLine("Please enter a Character or number or symbol");
             char mychar = Convert.ToChar(Console.ReadLine());
             byte[] asciiVal = Encoding.ASCII.GetBytes(mychar.ToString());

             if ((asciiVal[0] > 64 && asciiVal[0] < 91) || (asciiVal[0] > 96 && asciiVal[0] < 123))
             {
                 Console.WriteLine("It is Character {0}", asciiVal[0]);
             }
             else if (asciiVal[0] >=48 && asciiVal[0]<=57)
             {
                 Console.WriteLine("It is number {0}", asciiVal[0]);
             }
             else
             {
                 Console.WriteLine("It is sysmbol {0}", asciiVal[0]);
             }*/

            /*if (Char.IsDigit(mychar))
            {
                Console.WriteLine("It is number {0}", mychar);
            }
            else if(Char.IsLetter(mychar))
            {
                Console.WriteLine("It is Character {0}", mychar);
            }
            else
            {
                Console.WriteLine("It is sysmbol {0}", mychar);
            }*/


            /***************Sum of nth natural number with loop******************/

            /*int n, sum = 0;
            Console.WriteLine("Please enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Sum of the number {0}", sum);*/


            /***************Sum of nth natural number without loop(AP)******************/

            /*int fstNumber=1, LstNumber,sum,d=1,n;

            Console.WriteLine("Please enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            LstNumber = fstNumber + (n-1)*d;
            sum = (n * (fstNumber + LstNumber)) / 2;

            Console.WriteLine("Sum of the number {0}", sum);*/

            /***************product of nth natural number without loop(GP)******************/

            /*int fstNumber = 1, LstNumber, sum, r = 2, n,prodct;

            Console.WriteLine("Please enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            prodct = fstNumber * (r ^ (n - 1));
            Console.WriteLine("Product of the number {0}", prodct);*/


            /***************Factorial of a number with loop******************/

            /*int n,facto;
            Console.WriteLine("Please enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            facto = n;
            for (int i = 1; i < n; i++)
            {
                
                    facto = facto * i;
               
            }

            Console.WriteLine("Factorial of the number {0}", facto);*/


            /***************Factorial of a number without loop recusrsion******************/

            /* int k,f;
             Console.WriteLine("Please enter the number");
             k = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Factorial of the number {0}", facto(k));*/

            /***************GCM of number******************/

            /*int dvdn, divider,reminder;

            Console.WriteLine("Please enter the number");
            dvdn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the divider");
            divider = Convert.ToInt32(Console.ReadLine());

            reminder = dvdn % divider;
           while(reminder != 0)
            {
                divider = reminder;
                dvdn = divider;
                reminder = divider % dvdn;
            }

            Console.WriteLine("GCM of number {0}", divider);*/


            /***************LCM of number******************/

            /* int Num1, Num2 ,lcmResult;

             Console.WriteLine("Please enter the First number");
             Num1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Please enter the second number");
             Num2 = Convert.ToInt32(Console.ReadLine());


             lcmResult = LcmFunc(Num1, Num2);
             Console.WriteLine("LCM of number {0}", lcmResult);
             Console.ReadKey();*/


            /***************Print A-Z******************/



            /*for (int j = 65; j < 123; j++)
            {
                

                if (j == 91)
                {
                    j = j + 6;
                }

                Console.WriteLine("{0}", Convert.ToChar(j));
            }*/

            /*int val = 65;
            printAlphabet(val);*/




            /***************count of digit in a number******************/

            /* int num,digitnum;
             Console.WriteLine("Please enter the number");
             num = Convert.ToInt32(Console.ReadLine());

             num = Math.Abs(num);

             Console.WriteLine("Number of digits {0}", Math.Floor(Math.Log10(num) + 1));*/




            /***************power of a number******************/

            /*int num, powernum, powermult;
            Console.WriteLine("Please enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            powermult = 1;
            Console.WriteLine("Please enter the power of number");
            powernum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < powernum; i++)
            {
                powermult = powermult * num;
            }
            Console.WriteLine("Power of a number {0}", powermult);*/


            /***************Prime number numbers******************/


            /*int num, cnt = 0;
            Console.WriteLine("Please enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cnt++;
                }
            }

            if (cnt == 2)
            {
                Console.WriteLine("This is a prime number {0}", num);
            }
            else
            {
                Console.WriteLine("This is not a prime number {0}", num);
            }*/


            /***************Prime number numbers btwn 2 numbers******************/

            /*int num1, num2, cnt = 0;
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {

                cnt = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                }

                if (cnt == 2)
                {
                    Console.WriteLine("This is a prime number {0}", i);
                }
                
            }*/


            /***************armstrong number******************/

            /*int num1, r, sum=0,temp = 0;
            Console.WriteLine("Please enter the number");
            num1 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            while (num1 > 0)
            {
               
                r = num1 % 10;
                sum = sum + (r * r * r);
                num1 = num1 / 10;
            }

            if(temp == sum)
            {
               
                Console.WriteLine("This is a Armstrong number {0}", sum);
            }
            else
            {
                Console.WriteLine("This is not a Armstrong number {0}", sum);
            }*/


            /***************armstrong number btwn 2 number******************/

            int num1, num2, sum = 0,r,temp=0;
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                if(isArmstrong(i))
                {
                    Console.WriteLine("Its a armstrong number: {0}",i);
                }

            }



          
           

        }
       
    }
}
