// See https://aka.ms/new-console-template for more information

Console.WriteLine("----------Qusetion 1 -----------");
Console.Write("input text: ");
 string firstword = Console.ReadLine();
 Console.WriteLine($"length of text 1 is : {firstword.Length}");

Console.Write("input second text: ");
string secondword = Console.ReadLine();
 Console.WriteLine($"length of text 2 is: {secondword.Length}");

 int bothwordlength = firstword.Length + secondword.Length;
 Console.WriteLine($"sum of {firstword} and {secondword} is {bothwordlength}");

 int finalresult = bothwordlength < 20 ? bothwordlength + 20 : bothwordlength * 3;

 Console.WriteLine($"the final result is {finalresult}");






Console.WriteLine("---------Question 2 ----------");
decimal cp = 200.876M;
decimal sp =255.425M;
decimal profit = sp - cp;

Console.WriteLine($"the profit made is {Math.Round(profit ,2)}");

Console.WriteLine("---------Question 3-----------");
string word = Console.ReadLine();
int index = word.IndexOf(word[2]);
Console.WriteLine($"lenghth of {word} is {word.Length}");
 int addition = index + word.Length;
Console.WriteLine($"sum is = {addition}");
 int character= addition;
 char A = (char)character;
 Console.WriteLine($"character value is {A}");





Console.WriteLine("--------Question 4--------");
Console.Write("input a number:");
int num01 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int num02 = Convert.ToInt32(Console.ReadLine());

int result = Math.Max(num01, num02);
Console.WriteLine($"the greater of the 2 number is {result}");

Console.WriteLine("---------Question 5-----------");

        int sum = 0;
        int i = 0;
         while ( i <= 4)
      {
          Console.Write("Please enter number :");
          string  input = Console.ReadLine();
          int x;
           bool isInteger = int.TryParse(input , out x);
      if (!isInteger)
           {
             i--;
             Console.Write("Invalid input! ");
             
           }
           
           
           sum += x;
           i++;
        
         }
         Console.WriteLine($"The sum of the numbers is :{sum}");

Console.WriteLine("--------------Question 6 ------------");
const int value= 5;
Console.Write("input a number: ");
int firstnum = Convert.ToInt32(Console.ReadLine());

Console.Write("input second number: ");
int secondnum = Convert.ToInt32(Console.ReadLine());

int correctanswer = (firstnum + secondnum) - value;

Console.Write($"input ur answer: ");
 int useranswer = Convert.ToInt32(Console.ReadLine());
if ( correctanswer != useranswer)
 {
 Console.WriteLine($"incorrect answer, the correct answer is {A}");
 }

else{
  Console.WriteLine("correct answer");
}


Console.WriteLine("-------Question 7 -----------");
Console.Write("input a number between 0 and 9: ");
 
 int num = Convert.ToInt32(Console.ReadLine());

 switch (num)
 {
   case 0:
   Console.WriteLine("zero");
   break;

   case 1:
   Console.WriteLine("one");
   break;

   case 2: 
   Console.WriteLine("Two");
   break;

   case 3:
   Console.WriteLine("3");
   break;

   case 4:
   Console.WriteLine("four");
   break;

  case 5:
Console.WriteLine("five");
break;

  case 6:
  Console.WriteLine("six");
break;

  case 7:
Console.WriteLine("seven");
break;

case 8:
Console.WriteLine("8");
break;

case 9:
Console.WriteLine("nine");
break;

 }


