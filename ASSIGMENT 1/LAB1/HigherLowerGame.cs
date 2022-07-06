// See https://aka.ms/new-console-template for more information
/*String choice ="Y";

while(choice == "Y"){
Random random = new Random();
int guess=0;
int no_guess = 0;
int num = random.Next(1,100);

    while (guess != num)
    {
        Console.WriteLine("Enter your guess:");
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess > num)
            Console.WriteLine(guess + " is too high \n");

        if (guess < num)
            Console.WriteLine(guess + " is too low \n");
        no_guess++;
        if (guess == num)
           Console.WriteLine("\nYou have guessed it correctly \nThe number is: " + num + "\nYou have guessed: " + no_guess + " times");
    }
    Console.WriteLine("Do you want to contiue (Y/N):");
    choice = Console.ReadLine().ToUpper();
   
}
    Console.WriteLine("\nThanks for playing have a nice day!!");*/
int guess = 0;
int no_guess = 0;
int num = 0;
int dig1=0;
int dig2=0;
int dig3= 0 ;
int dig4 = 0    ;

Random random = new Random();

do
{
    dig1 = random.Next(1, 10);
    dig2 = random.Next(1, 10);
    dig3 = random.Next(1, 10);
    dig4 = random.Next(1, 10);
} while (dig1 == dig2 || dig2 == dig3 || dig3 == dig4 || dig1 == dig3 || dig1 == dig4 || dig2 == dig4);
    var numb = new[] { dig1, dig2, dig3, dig4 };
foreach (var i in numb)
{
    num = num * 10 + i;
}
Console.WriteLine(num);

