class Program
{
    //Throw statement
    static void Main(string[] args)
    {

        Dividesafely(4, 0);

    }

    public static int Dividesafely(int a, int b) 
    { 
    
        if(b == 0) 
        { 
        
            throw new DivideByZeroException ("Denominator cannot be zero!");
        }
        return a/b;
    }

    public class InvalidAgeException : Exception 
    {

        public InvalidAgeException(string message) : base(message) { }
    
    }

    public static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("User must be 18 or above.");
        }

    }
}