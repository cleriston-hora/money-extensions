namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal valor)
    {
        if (valor <= 0)        
            return 0;

        return decimal.ToInt32(valor * 100);
    }
}
