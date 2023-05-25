// See https://aka.ms/new-console-template for more information
Console.WriteLine("Guess the secret number!");
Console.WriteLine("Take a guess.");





int secret = 42;


int guessCount = 0;
while( guessCount < 4)
{
guessCount++;
    int guess = Convert.ToInt32(Console.ReadLine());
if (secret == guess){
Console.WriteLine("Wow!!! You guessed my secret!");
break;
}

else if (guessCount < 4)
{
Console.WriteLine("Try again next time :(");
}

else {
    Console.WriteLine("You ran out of guesses :(");
}

}
