public static int toFactorial(int numToFactorial)
{
    int factorial = 1;

    if(numToFactorial <= 0)
        return factorial;
    else
    {
        for(int i = 1; i <= numToFactorial; i++) 
            factorial = i * factorial;
    }

    return factorial;
}