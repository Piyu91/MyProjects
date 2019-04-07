using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int uinput = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            Console.WriteLine("{0} {1}", uinput, obj.isArmstrong(uinput) ? "is a armstrong number" : "is not a armstrong number");
        }
        public int getLength(int uInput)
        {
            int divi, numCount = 0;
            while (uInput != 0)
            {
                divi = uInput / 10;
                numCount +=  1;
                uInput = divi;
            }
            return numCount;
        }
        public bool isArmstrong(int uInput)
        {
            int orginVal = uInput;
            int armrem, armdivi, armsum=0, numCount;
            numCount = getLength(uInput);
            while (uInput != 0)
            {
                armrem = uInput % 10;
                armdivi = uInput / 10;
                uInput = armdivi;
                armsum = (int)(armsum + Math.Pow(armrem, numCount));

            }
            return orginVal == armsum;
        }
    }
}

//To find a even or odd number
//int uinput = convert.toint32(console.readline());
//            if(uinput % 2 == 0)
//            {
//                console.writeline("{0} number is even",uinput);
//            }
//            else
//            {
//                console.writeline("{0} number is odd",uinput);
//            }
//Find a prime number
//int uprime = Convert.ToInt32(Console.ReadLine());
//int i;
//            for (i = 2; i<uprime; i++)
//            {
//                if(uprime%i == 0)
//                {
//                    Console.WriteLine("{0} Number is not prime",uprime);
//                    break;
//                }
//            }
//            if(i==uprime)
//            {
//                Console.WriteLine("{0} is a prime Number",uprime);
//            }

//Prime number -- Optimized version
//int uprime = Convert.ToInt32(Console.ReadLine());
//string x = "is a prime number";
//            if (uprime % 2 == 0)
//            {
//                x = "is not a prime number";
//            }
//            else
//            {
//                for (int i = 3; i <= Math.Sqrt(uprime); i++)
//                {
//                    if (uprime % i == 0)
//                    {
//                        x = "is not a prime number";
//                        break;
//                    }
//                }
//            }
//                Console.WriteLine("{0} {1}",uprime,x);

//FInd if a number is pallindrome or not
//int uinput = Convert.ToInt32(Console.ReadLine());
//int originnumber = uinput;
//int rem;
//int divi;
//int summ = 0;
//            while (uinput != 0)
//            {
//                rem = uinput % 10;
//                divi = uinput / 10;
//                uinput = divi;
//                summ = (summ* 10) + rem;

//            }
//            if(originnumber == summ)
//            {
//                Console.WriteLine("{0} its a palindrome number", originnumber);
//            }
//            else
//            {
//                Console.WriteLine("{0} its not a palindrome number", originnumber);
//            }

//Fibonacci series
//int uinput = Convert.ToInt32(Console.ReadLine());
//int a = -1;
//int b = 1;
//int c;
//            for (int i = 0; i<uinput; i++)
//            {
//                c = a + b;
//                a = b;
//                b = c;
//                Console.Write("{0} ",c);
//            }


//Check if a number is a armstrong number without external function
//int uinput = Convert.ToInt32(Console.ReadLine());
//int arminput = uinput;
//int inp = uinput;
//int divi, numCount = 0, armrem, armdivi, armsum = 0;

//            while(uinput != 0)
//            {
//                divi = uinput / 10;
//                numCount = numCount + 1;
//                uinput = divi;
//            }

//            while (arminput != 0)
//            {
//                armrem = arminput % 10;
//                armdivi = arminput / 10;
//                arminput = armdivi;
//                armsum =(int) (armsum + Math.Pow(armrem, numCount));
//            }
//            Console.WriteLine("{0} {1}",inp, armsum==inp? "is a armstrong number" : "is not a armstrong number");


///Check if a number is a Armstrong Number using Function
///static void Main(string[] args)
//        {
//            int uinput = Convert.ToInt32(Console.ReadLine());
//Program obj = new Program();
//Console.WriteLine("{0} {1}", uinput, obj.isArmstrong(uinput)? "is a armstrong number" : "is not a armstrong number");
//        }
//        public int getLength(int uInput)
//{
//    int divi, numCount = 0;
//    while (uInput != 0)
//    {
//        divi = uInput / 10;
//        numCount += 1;
//        uInput = divi;
//    }
//    return numCount;
//}
//public bool isArmstrong(int uInput)
//{
//    int orginVal = uInput;
//    int armrem, armdivi, armsum = 0, numCount;
//    numCount = getLength(uInput);
//    while (uInput != 0)
//    {
//        armrem = uInput % 10;
//        armdivi = uInput / 10;
//        uInput = armdivi;
//        armsum = (int)(armsum + Math.Pow(armrem, numCount));

//    }
//    return orginVal == armsum;
//}