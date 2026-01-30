namespace DigitalisNyomozoIroda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Béla", 23, "jó gyerek");
            Suspect s = new Suspect(p, 100, "Mégse olyan jó gyerek");
			Console.WriteLine();
			Console.WriteLine(s);

        }
    }
}
