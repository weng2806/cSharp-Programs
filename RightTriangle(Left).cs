i = 1;
while (i <= 5)
{
    int j = 1;
    
    // space muna
    while (j <= 5 - i)
    {
        Console.Write(" ");
        j++;
    }
    // yung asterisk naman
    j = 1;
    while (j <= i)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}
