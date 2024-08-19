using System;

    class basic {
        static void Main() {
            
        int firstNumber = 28;
        int secondNumber = 10;
    
        int sum = firstNumber + secondNumber;
        int difference = firstNumber - secondNumber;
        int product = firstNumber * secondNumber;
        int quotient = firstNumber / secondNumber;
        int modulo = firstNumber % secondNumber;
        
        Console.WriteLine("hi sir");
        Console.WriteLine("The First Number is: " + firstNumber);
        Console.WriteLine("The Second Number is: " + secondNumber);
     
        for (int weng = secondNumber; weng < firstNumber; weng++) {
            Console.Write("-");
        }
        Console.WriteLine("");
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);
        Console.WriteLine("The quotient is: " + quotient);
        Console.WriteLine("The modulo is: " + modulo);
    
  }
}
