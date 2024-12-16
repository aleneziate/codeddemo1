//See https://aka.ms/new-console-template for more information

// Datatype Var-Name ; 
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

string FirstName ; 
string  LastName ; 

int num1 , num2 , sum ;
num1 = 5 ;
num2 = 7 ;
sum = num1 + num2  ;


FirstName = "Ahmed";
LastName = "Damra";

string N1, N2, N3;
N1 = "3";
N2 = "4" ;
N3 = "5" ;

string Total = (Convert .ToInt32(N1) + Convert .ToInt32(N2) +  Convert .ToInt32(N3)).ToString() ;




 Console.WriteLine("Mr ." +FirstName +" "+ LastName +"your number is "+ (num1+num2)) ;

Console.WriteLine("Totla is:" +Total); 

Console.WriteLine("Enter Your Full Name:");
string FullName =Console.ReadLine() ;
Console.WriteLine("Enter your City: ");
string City =Console.ReadLine() ;
Console.WriteLine("welcome" + FullName + " My City is:" + City);







Console.WriteLine("Enter mark1:");
    string mark1 = Console.ReadLine() ;
Console.WriteLine("Enter mark2:");
 string mark2 = Console.ReadLine() ;
sum=Convert .ToInt32(mark1) +Convert .ToInt32(mark2) ;
Console.WriteLine(sum);

Console.WriteLine("Enter mark 1");

Console.WriteLine("Enter Avg");
double avg = Convert .ToDouble(Console.ReadLine()) ;
if (avg >= 50 && avg <=100)
{

    Console.WriteLine("Pass");

}
else if (avg < 50 && avg >=0)
{

    Console.WriteLine("Fail");
}
else
    Console.WriteLine("out of range");