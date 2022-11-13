namespace inputZKlavesnice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte cislo: ");
            string a = Console.ReadLine();
            int aa = Convert.ToInt32(a);

            Console.Write("Zadejte cislo: ");
            string b = Console.ReadLine();
            int bb = Convert.ToInt32(b);

            Console.WriteLine("cislo a: "+bb);
            Console.WriteLine("cislo b: "+aa);
            Console.WriteLine();
            MatematickeUpravy mu = new MatematickeUpravy(aa,bb);
            Console.WriteLine("soucet: "+mu.Add());
            Console.WriteLine("odecet: " + mu.Odecti());
            Console.WriteLine("nasobeni: " + mu.mul());
            Console.WriteLine("deleni: " + mu.div());
            Console.WriteLine();

            Console.Write("Zadejte svoje jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte svuj vek: ");
            string vek = Console.ReadLine();
            int age = Convert.ToInt32(vek);
            Console.WriteLine("jmeno: "+jmeno+"\n"+"vek: "+age);


        }
    }
}