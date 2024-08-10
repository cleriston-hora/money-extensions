namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal valor)
    {
         return decimal.ToInt32(valor * 100);
    }
}
