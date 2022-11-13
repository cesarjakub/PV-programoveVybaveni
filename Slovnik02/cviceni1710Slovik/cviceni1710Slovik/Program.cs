namespace cviceni1710Slovik
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Slovnik slovnik = new Slovnik();
            //cesko-anglicky
            slovnik.Add(new Slovo(new List<string>() {"ahoj"}), new Slovo(new List<string>() {"hello","hi"}));
            slovnik.Add(new Slovo(new List<string>() { "hrbitov" }), new Slovo(new List<string>() { "cemetery", "churchyard", "graveyard" }));

            //anglicko-cesky
            slovnik.Add(new Slovo(new List<string>() { "key" }), new Slovo(new List<string>() { "klic"}));
            slovnik.Add(new Slovo(new List<string>() { "translator" }), new Slovo(new List<string>() { "prekladac"}));

            string vypis = slovnik.ToString();
            Console.WriteLine(vypis);

            
        }
    }
}