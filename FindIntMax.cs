public class FindMaximum
{
    public static int FindIntMax(int num1, int num2, int num3)
    {
        if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
        {
            return num1;
        }
        if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
        {
            return num2;
        }
        if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
        {
            return num3;
        }
        return 0;
    }
}
