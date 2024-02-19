
Random rnd = new Random();
int cpuRandom;

bool loopActice = true;// bool - True/false

while(loopActice)
{
    cpuRandom = rnd.Next(1, 4);
   // Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a  guess, enter a  number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        // loopActice = false;- toimub sama moodi nagu break;
        break;
    }
    else
    {
        Console.WriteLine("Oops. Try again");
    }
}
Console.WriteLine("Have a nice day");