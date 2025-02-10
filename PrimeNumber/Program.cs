
class Program
{
    static void Main(string[] args)
    {
        // รับค่าจากผู้ใช้
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // ตรวจสอบและแยกตัวเลข
        if (int.TryParse(input, out int number) && number <= 50000 && number > 0)
        {
            // เรียกฟังก์ชันแสดงจำนวนเฉพาะและไม่เฉพาะ
            ShowPrimeAndNonPrimeNumbers(number);
        }
        else
        {
            Console.WriteLine("Error: Please Number");
        }
    }

    // ฟังก์ชันตรวจสอบจำนวนเฉพาะ
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    // ฟังก์ชันแสดงจำนวนเฉพาะและไม่เฉพาะ
    static void ShowPrimeAndNonPrimeNumbers(int number)
    {
        var primeNumbers = new System.Collections.Generic.List<int>();
        var nonPrimeNumbers = new System.Collections.Generic.List<int>();

        // แยกจำนวนเฉพาะและไม่เฉพาะ
        for (int i = 1; i <= number; i++)
        {
            if (IsPrime(i))
                primeNumbers.Add(i);
            else
                nonPrimeNumbers.Add(i);
        }

        // แสดงผลลัพธ์
        Console.WriteLine($"Number: {string.Join(" ", nonPrimeNumbers)}");
        Console.WriteLine($"Prime number: {string.Join(" ", primeNumbers)}");
    }
}
