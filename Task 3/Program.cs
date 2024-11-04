using System;

public class CurrencyConverter
{
    public static double ConvertCurrency(double amount, double exchangeRate)
    {
        return amount * exchangeRate;
    }
}