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
    public static float FindfloatMax(float num1, float num2, float num3)
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
    public static string FindStringMax(string myString1, string myString2, string myString3)
    {
        int max = 0;
        string s = "";
        if (myString1.Length > max) { max = myString1.Length; s = myString1; }
        if (myString2.Length > max) { max = myString2.Length; s = myString2; }
        if (myString3.Length > max) { max = myString3.Length; s = myString3; }
        return s;
    }

}
