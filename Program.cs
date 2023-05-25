// See https://aka.ms/new-console-template for more information
Console.WriteLine("Guess the secret number!");
Console.WriteLine("Take a guess.");

Console.WriteLine("Choose a difficulty level:");
Console.WriteLine("1. Easy");
Console.WriteLine("2. Medium");
Console.WriteLine("3. Hard");
Console.WriteLine("4. Cheater");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice) {
    case 1:
    choice = 8;
    Console.WriteLine("You have chosen easy mode." + " You have 8 guesses");
    break;

    case 2:
    choice = 6;
    Console.WriteLine("You have chosen medium mode." + " You have 6 guesses");
    break;

    case 3:
    choice = 4;
    Console.WriteLine("You have chosen hard mode." + " You have 4 guesses");
    break;

    case 4:
    choice = int.MaxValue;
    Console.WriteLine("You have chosen cheater mode." + " Guess until correct");
    break;
}

int secret = new Random().Next(1,100);


int guessCount = 0;
while( guessCount < choice)
{
guessCount++;
    int guess = Convert.ToInt32(Console.ReadLine());
if (secret == guess){
Console.WriteLine("Wow!!! You guessed my secret!");
break;
}

else if (guessCount < choice && secret < guess)
{
Console.WriteLine("Try again. Too high :("+ "Total Guesses" + (guessCount));
}

else if (guessCount < choice && secret > guess)
{
Console.WriteLine("Try again. Too low :("+ "Total Guesses" + (guessCount));
}

else {
    Console.WriteLine(" No more guesses." + 

    "The secret number was" + ""
    +
    secret);
}

}
