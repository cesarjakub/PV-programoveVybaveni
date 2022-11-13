namespace _1209tridy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //cviceni jedna
            Console.WriteLine("CV 1:");
            int cislo = 5;

            Interval interval1 = new Interval(10,2);
            Interval interval2 = new Interval(22,11);
            if(interval1.nachaziSe(cislo) == true)
            {
                Console.WriteLine(cislo + " se nachazi v intervalu");
            }
            else
            {
                Console.WriteLine(cislo+ " se nenachazi v intervalu");
            }
            Console.WriteLine(interval1.prunik(interval2));

            /*
            //cviceni dve
            Console.WriteLine();
            Console.WriteLine("CV 2:");
            Primka primka = new Primka(1,5);
            primka.DelkaPrimky();


            //cviceni tri
            Console.WriteLine();
            Console.WriteLine("CV 3:");
            Trojuhelnik troj1 = new Trojuhelnik(4,3,4);

            if (troj1.pravostTroj() == true)
            {
                if (troj1.rovnoramenny())
                {
                    Console.WriteLine("trojuhlenik je rovnoramenny");
                }
                if (troj1.rovnostranny())
                {
                    Console.WriteLine("trojuhlenik je rovnostranny");
                }
                if (troj1.pravouhly())
                {
                    Console.WriteLine("trojuhlenik je pravouhly");
                }
            }
            else
            {
                Console.WriteLine("Trojuhelnik neni mozne sestrojit");
            }

            //cviceni ctyri
            Console.WriteLine();
            Console.WriteLine("CV 4:");
            Potravina banan = new Potravina("banan",100 , 94);
            Console.WriteLine(banan.ToString());
            Console.WriteLine(banan.EnHod+"kcal je: "+banan.KcalToKj()+"Kj");
            Console.WriteLine("Banán tvoří "+banan.procenta()+ "% z denního minimálního kalorického příjmu");

            */
        }
    }
}