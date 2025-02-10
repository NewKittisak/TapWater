
class Program
{
    static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(GenerateFeeMessage(0));  // 0 units
        Console.WriteLine(GenerateFeeMessage(5));  // 5 units
        Console.WriteLine(GenerateFeeMessage(19)); // 19 units
        Console.WriteLine(GenerateFeeMessage(23)); // 23 units
        Console.WriteLine(GenerateFeeMessage(39)); // 39 units
    }

    static string GenerateFeeMessage(int unitsUsed)
    {
        int fee = 50; // Initial fee
        string feeDetails = $"Use {unitsUsed} PaidPerUnit {fee} Bath";

        string additionalFees = "";

        if (unitsUsed >= 31)
        {
            int additionalFee = (unitsUsed - 30) * 50;
            fee += additionalFee;
            additionalFees += $"+{additionalFee}";
            unitsUsed = 30;
        }
        if (unitsUsed >= 21)
        {
            int additionalFee = (unitsUsed - 20) * 30;
            fee += additionalFee;
            additionalFees += $"+{additionalFee}";
            unitsUsed = 20;
        }
        if (unitsUsed >= 11)
        {
            int additionalFee = (unitsUsed - 10) * 10;
            fee += additionalFee;
            additionalFees += $"+{additionalFee}";
            unitsUsed = 10;
        }
        if (unitsUsed >= 1)
        {
            int additionalFee = unitsUsed * 5;
            fee += additionalFee;
            additionalFees += $"+{additionalFee}";
        }

        return $"{feeDetails}{additionalFees} Bath";
    }
}
