i = 1;
int spaces = 0;
int stars = 5;
while (i <= 5)
{
    int j = 1;

    // Print leading spaces
    int s = 1;
    while (s <= spaces)
    {
        Console.Write(" ");
        s++;
    }

    // Print stars
    while (j <= stars)
    {
        Console.Write("*");
        j++;
    }

    Console.WriteLine();
    spaces++;  // dadagdag space kadaa row
    stars--;   // bawas asterisk kasi pababa siya
    i++;
}
