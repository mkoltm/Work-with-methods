using System;

public class Calculator
{
    public static double PerformOperation(double operand1, double operand2, string operation)
    {
        switch (operation)
        {
            case "додавання":
                return operand1 + operand2;
            case "віднімання":
                return operand1 - operand2;
            case "множення":
                return operand1 * operand2;
            case "ділення":
                if (operand2 != 0)
                    return operand1 / operand2;
                else
                    throw new ArgumentException("Ділення на нуль неможливе");
            default:
                throw new ArgumentException("Невірна операція");
        }
    }
}
