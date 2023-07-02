int a = 18;
int b = 6;
int c = a + b;
int d = a - b;
int e = a * b;
int f = a / b;
Console.WriteLine($"addition {c}, substraction {d},multiplication {e},division {f} ");

int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d);

int a = 5;
int b = 4;
int c = 2;
int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
Console.WriteLine(d);

//******************************************Explore integer precision and limits*************************************************

int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

//******************************************Work with the double type************************************************************

double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

//******************************************Work with decimal typ****************************************************************

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

//area of circle
double radius= 2.50;
double pi=3.14;
double area=Math.PI*radius*radius;
Console.WriteLine(area);

//******************************************using the if statement**************************************************************

int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");
    
int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");
    
int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) && (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}

int a = 5;
int b = 3;
int c = 4;
if ((a + b + c > 10) || (a == b))
{
    Console.WriteLine("The answer is greater than 10");
    Console.WriteLine("Or the first number is equal to the second");
}
else
{
    Console.WriteLine("The answer is not greater than 10");
    Console.WriteLine("And the first number is not equal to the second");
}

//******************************************Use loops***************************************************************************

int counter = 0;
while (counter < 10)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
}

int counter = 0;
do
{
  Console.WriteLine($"Hello World! The counter is {counter}");
  counter++;
} while (counter < 10);


for (int counter = 0; counter < 10; counter++)
{
  Console.WriteLine($"Hello World! The counter is {counter}");
}

for (int row = 1; row < 11; row++)
{
  for (char column = 'a'; column < 'k'; column++)
  {
    Console.WriteLine($"The cell is ({row}, {column})");
  }
}

int sum = 0;
for (int number = 1; number < 21; number++)
{
  if (number % 3 == 0)
  {
    sum = sum + number;
  }
}
Console.WriteLine($"The sum is {sum}");
