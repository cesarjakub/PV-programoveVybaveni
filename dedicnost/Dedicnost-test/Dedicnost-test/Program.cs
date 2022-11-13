namespace Dedicnost_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prvni cviceni
            Napoj napoj = new Napoj(20, "Malinovka");
            Napoj alk = new AlkoholickyNapoj(12, 120, "Vino");

            Console.WriteLine(napoj.ToString());
            Console.WriteLine(alk.ToString());

            Console.WriteLine();
            //druhy cviceni
            Auto auto = new Auto("SPZ – ABC 52 36", 50);
            Auto nakladni = new NakladniAuto(20, "SPZ A3D 25 42", 70);
            Console.WriteLine(auto.ToString());
            Console.WriteLine(nakladni.ToString());
        }
    }
}