using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(EnglishDigit(input));

    }
    static string EnglishDigit(int number)
    {
        string numberAsWord = String.Empty;
        number = number % 10;
        switch (number)
        {
            case 0:
                numberAsWord =  "zero";
                break;
            case 1:
                numberAsWord = "one";
                break;
            case 2:
                numberAsWord = "two";
                break;
            case 3:
                numberAsWord = "three";
                break;
            case 4:
                numberAsWord = "four";
                break;
            case 5:
                numberAsWord = "five";
                break;
            case 6:
                numberAsWord = "six";
                break;
            case 7:
                numberAsWord = "seven";
                break;
            case 8:
                numberAsWord = "eight";
                break;
            case 9:
                numberAsWord = "nine";
                break;
            default:
                break;
        }
        return numberAsWord;
    }
}

//using System;

//class Program
//{
//    static void Main() // SECOND SOLUTION WITH CHAR
//    {
//        char[] number = Console.ReadLine().ToCharArray();

//        char lastNumber = number[number.Length - 1];

//        Console.WriteLine(charAsWord(lastNumber));
//    }

//    static string charAsWord(char symbol)
//    {
//        string numberAsWord = String.Empty;
//        switch (symbol)
//        {
//            case '0':
//                numberAsWord = "zero";
//                break;
//            case '1':
//                numberAsWord = "one";
//                break;
//            case '2':
//                numberAsWord = "two";
//                break;
//            case '3':
//                numberAsWord = "three";
//                break;
//            case '4':
//                numberAsWord = "four";
//                break;
//            case '5':
//                numberAsWord = "five";
//                break;
//            case '6':
//                numberAsWord = "six";
//                break;
//            case '7':
//                numberAsWord = "seven";
//                break;
//            case '8':
//                numberAsWord = "eight";
//                break;
//            case '9':
//                numberAsWord = "nine";
//                break;
//            default:
//                break;
//        }
//        return numberAsWord;
//    }
//}