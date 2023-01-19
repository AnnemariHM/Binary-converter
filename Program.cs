internal class Program
{
    private static void Main(string[] args)
    {//Asks 8bit binary-number and convert it to decimal
        Console.WriteLine("Tervetuloa käyttämään 8bit binäärimuunninta!\n\n"
        + "Anna kaikki kahdeksan numeroa ja erota numerot välilyönnillä. Esimerkiksi 0 0 1 0 0 1 1 0\n\n"
        + "Syötä binäärinumero ja paina enter:");
        string input = Console.ReadLine();
        int sum = 0;//sum is for counting the decimals
        int dnumber = 256;//dnumber is for getting the correct value of binary-number
        string[] parts = input.Split(" ");
        for(int i = 0; i < parts.Length; i++)//Goes trough the array...
        {
            dnumber = dnumber/2;
            if(Convert.ToInt32(parts[i]) == 1)//...and counts the decimals
            {
                sum = sum + dnumber;
            }
        }
        Console.WriteLine("Desimaaliluku: " + sum);
    }
}