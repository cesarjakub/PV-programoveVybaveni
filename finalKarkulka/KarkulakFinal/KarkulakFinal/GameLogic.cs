using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarkulakFinal
{
    public class GameLogic
    {
        private Karkulka ka;
        private Policko[,] mapa;
        private int x;
        private int y;
        private bool vino;
        private bool babovka;
        private bool kviti;
        private bool houby;


        public bool Kviti { get { return kviti; } set { kviti = value; } }
        public bool Houby { get { return houby; } set { houby = value; } }
        public bool Vino { get { return vino; } set { vino = value; } }
        public bool Babovka { get { return babovka; } set { babovka = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public Policko[,] Mapa
        {
            get { return mapa; }
            set { mapa = value; }
        }

        public GameLogic()
        {
            mapa = new Policko[16, 16];
            newMap();
            add();
        }

        #region
        public void newMap()
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    mapa[i, j] = new Policko(Typ.VYHLIDKA);
                }
            }
        }

        public void add()
        {
            addKarkulka();
            addBab();
            addVlk();
            addLouka();
            addPrekazka();
            addKoren();
        }

        public void addKarkulka()
        {
            Random rand = new Random();
            int x = rand.Next(0, 16);
            int y = rand.Next(0, 16);
            mapa[x, y].Typ = Typ.DOMOV;
            mapa[x, y].Karkulka = new Karkulka();
            this.X = x;
            this.Y = y;
        }
        public void addBab()
        {
            Random rand = new Random();
            int x = rand.Next(0, 16);
            int y = rand.Next(0, 16);
            if (mapa[x,y].Typ == Typ.VYHLIDKA)
            {
                mapa[x, y].Typ = Typ.BABICKA;
            }
            else
            {
                addBab();
            }
        }
        public void addLouka()
        {
            Random rand = new Random();
            for (int i = 0; i < 2; i++)
            {
                int x = rand.Next(0, 16);
                int y = rand.Next(0, 16);
                if (mapa[x, y].Typ == Typ.VYHLIDKA)
                {
                    mapa[x, y].Typ = Typ.LOUKA;
                }
                else
                {
                    addLouka();
                }
            }
        }
        public void addVlk()
        {
            Random rand = new Random();
            int x = rand.Next(0, 16);
            int y = rand.Next(0, 16);
            if (mapa[x, y].Typ == Typ.VYHLIDKA)
            {
                mapa[x, y].Typ = Typ.VLK;
            }
            else
            {
                addVlk();
            }
        }
        public void addPrekazka()
        {
            for (int i = 0; i < 12; i++)
            {
                Random rand = new Random();
                int x = rand.Next(0, 16);
                int y = rand.Next(0, 16);
                if (mapa[x, y].Typ == Typ.VYHLIDKA)
                {
                    mapa[x, y].Typ = Typ.PREKAZKA;
                }
                else
                {
                    addPrekazka();
                }
            }
            
        }
        public void addKoren()
        {
            for(int i = 0; i < 3; i++)
            {
                Random rand = new Random();
                int x = rand.Next(0, 16);
                int y = rand.Next(0, 16);
                if (mapa[x, y].Typ == Typ.VYHLIDKA)
                {
                    mapa[x, y].Typ = Typ.BLUDNY_KOREN;
                }
                else
                {
                    addKoren();
                }
            }
        }
        #endregion 

        public void pohniSe(Smer smer)
        {
            ka = mapa[X, Y].Karkulka;
            Vino = ka.Vino;
            Babovka = ka.Babovka;
            switch (smer)
            {
                case Smer.VLEVO:
                    mapa[X, Y].Karkulka = null;
                    X += 0;
                    Y += -1;
                    mapa[X, Y].Karkulka = ka;
                    break;
                case Smer.VPRAVO:
                    mapa[X, Y].Karkulka = null;
                    X += 0;
                    Y += 1;
                    mapa[X, Y].Karkulka = ka;
                    break;
                case Smer.NAHORU:
                    mapa[X, Y].Karkulka = null;
                    X += -1;
                    Y += 0;
                    mapa[X, Y].Karkulka = ka;
                    break;
                case Smer.DOLU:
                    mapa[X, Y].Karkulka = null;
                    X += 1;
                    Y += 0;
                    mapa[X, Y].Karkulka = ka;
                    break;
            }
        }

        public void checkWhereIam()
        {
            if (mapa[X, Y].Typ == Typ.BABICKA)
            {
                if (mapa[X, Y].Karkulka.Vino && mapa[X, Y].Karkulka.Babovka || Kviti && Houby || Kviti && mapa[X, Y].Karkulka.Vino ||
                    Kviti && mapa[X, Y].Karkulka.Babovka || mapa[X, Y].Karkulka.Vino && Houby || Houby && mapa[X, Y].Karkulka.Babovka)
                {
                    Console.WriteLine("SUPRR!!!!! \nVYHRÁLI JSTE");
                    Environment.Exit(0);
                }
                else if(!Vino || !Kviti)
                {
                    Console.WriteLine("Chybí vám víno");
                }
                else if (!Babovka || !Houby)
                {
                    Console.WriteLine("Chybí vám bábovka");
                }
            }

            if (mapa[X, Y].Typ == Typ.VYHLIDKA)
            {
                Console.WriteLine("Stojíte na Vyhlídce");
                Console.WriteLine("Koukáte se na lesy, která jsou zbarvené do tmavě zelené \n" +
                    "koukáte se na rybníček. Na hladině se odráží barevné spektrum lesa \n" +
                    "polétají nad ním kolibříci a motýli");
            }

            if (mapa[X, Y].Typ == Typ.BLUDNY_KOREN)
            {
                Random rand = new Random();
                int tempX = rand.Next(0, 16);
                int tempY = rand.Next(0, 16);
                if (mapa[tempX, tempY].Typ == Typ.VYHLIDKA)
                {
                    mapa[X, Y].Karkulka = null;
                    mapa[tempX, tempY].Karkulka = ka;
                    X = tempX;
                    Y = tempY;
                    //mapa[X, Y].Karkulka.Babovka = Babovka;
                    //mapa[X, Y].Karkulka.Vino = Vino;
                    Console.WriteLine("+-----------------------------------------------+");
                    Console.WriteLine("Stoupli jste na Bludny koren, který vás přenesl na náhodné místo na poli");
                    Console.WriteLine();
                    vypis();
                    Console.WriteLine();
                }
                
            }

            if (mapa[X, Y].Typ == Typ.LOUKA)
            {
                if (!mapa[X, Y].Karkulka.Babovka && !mapa[X, Y].Karkulka.Vino)
                {
                    Houby = true;
                    Console.WriteLine("Nazbiral jste houby");
                    Console.WriteLine();
                }
                else if(!mapa[X, Y].Karkulka.Babovka && mapa[X, Y].Karkulka.Vino)
                {
                    Houby = true;
                    Console.WriteLine("Nazbiral jste houby");
                    Console.WriteLine();
                }
                else if (!mapa[X, Y].Karkulka.Vino)
                {
                    Kviti = true;
                    Console.WriteLine("Nazbiral jste kvítí");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Mate všechno");
                }
                mapa[X, Y].Typ = Typ.VYHLIDKA;
            }

            if (mapa[X, Y].Typ == Typ.PREKAZKA)
            {
                Console.WriteLine("Narazili jste na mokřinu.\n" +
                                  "Mokřina hodi kostkou poté hází karkulka \n" +
                                  "pokud hodíte víc než mokřina můžete pokračovat dále. \n" +
                                  "Pokud hodí mokřina víc, tak vám sebere jeden dárek z košíku");
                DiceRoll roll = new DiceRoll();
                int mokrina = roll.hodKostkou();
                int karkul = roll.hodKostkou();
                mokrina += 7;
                if (karkul == mokrina)
                {
                    Console.WriteLine("Mokřina hodina: " + mokrina);
                    Console.WriteLine("Karkulka hodina: " + karkul);
                    Console.WriteLine("Remíza, ale mokřina byla hodná a pustila tě hrát dál");
                }
                if (karkul > mokrina)
                {
                    Console.WriteLine("Mokřina hodina: " + mokrina);
                    Console.WriteLine("Karkulka hodina: " + karkul);
                    Console.WriteLine("Blahopřeji pokračuj dále");

                }
                if (mokrina > karkul)
                {
                    Console.WriteLine("Mokřina hodina: " + mokrina);
                    Console.WriteLine("Karkulka hodina: " + karkul);
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("karkulka prohrála, ale pomohl ji myslivec\n" +
                        "Karkulka mu dala jeden z dárků pro babičku");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("Karkulka ma u sebe: ");
                    Console.WriteLine("víno: " + Vino + "\nbábovku: " + Babovka + "\nhouby: " + Houby + "\nkvítí: " + Kviti);
                    Console.WriteLine("--------------------------------------------");
                    if (!Vino && !Babovka && !Houby && !Kviti)
                    {
                        Console.WriteLine("Nemate co dat myslivci");
                        Console.WriteLine("Prohrál jste :(");
                        Console.WriteLine("Konec hry!!!!!!!!!!!!!!!");
                        Environment.Exit(0);
                    }

                    
                    if (Vino && Babovka || !Babovka && Vino)
                    {
                        Console.WriteLine("Ztratili jste Víno");
                        mapa[X,Y].Karkulka.Vino = false;
                    }
                    else if (!Vino && Babovka)
                    {
                        Console.WriteLine("Ztratili jste Babovku");
                        mapa[X, Y].Karkulka.Babovka = false;
                    }

                    else if (Houby && Vino || !Houby && Vino)
                    {
                        Console.WriteLine("Ztratili jste Víno");
                        mapa[X, Y].Karkulka.Vino = false;
                    }
                    else if (Houby && !Vino)
                    {
                        Console.WriteLine("Ztratili jste Houby");
                        Houby = false;
                    }

                    else if (Kviti && Vino || !Kviti && Vino)
                    {
                        Console.WriteLine("Ztratili jste Víno");
                        mapa[X, Y].Karkulka.Vino = false;
                    }
                    else if (Kviti && !Vino)
                    {
                        Console.WriteLine("Ztratili jste Kvítí");
                        Kviti = false;
                    }


                    else if (Houby && Kviti || !Houby && Kviti)
                    {
                        Console.WriteLine("Ztratili jste Kvítí");
                        Kviti = false;
                    }
                    else if (!Kviti && Houby)
                    {
                        Console.WriteLine("Ztratili jste Houby");
                        houby = false;
                    }

                    else if (Babovka && Kviti || !Babovka && Kviti)
                    {
                        Console.WriteLine("Ztratili jste Kvítí");
                        Kviti = false;
                    }
                    else if (!Kviti && Babovka)
                    {
                        Console.WriteLine("Ztratili jste Babovku");
                        mapa[X, Y].Karkulka.Babovka = false;
                    }

                    else if (Houby && Babovka || !Houby && Babovka)
                    {
                        Console.WriteLine("Ztratili jste Babovka");
                        mapa[X, Y].Karkulka.Babovka = false;    
                    }
                    else if (!Babovka && Houby)
                    {
                        Console.WriteLine("Ztratili jste Houby");
                        houby = false;
                    }

                }
            }

            if (mapa[X, Y].Typ == Typ.VLK)
            {
                if (Houby && Kviti)
                {
                    Console.WriteLine("Karkulka narazila na Vlka. \n" +
                   "a protože jste byla na louce dvakrát, tak Vlk sežeral babičku a prohráli jste");
                    Console.WriteLine("Neeee!!!!! \nPROHRÁLI JSTE");
                    Environment.Exit(0);
                }
                mapa[X, Y].Typ = Typ.VYHLIDKA;
                addVlk();
            }
        }

        public void inventory()
        {
            Console.WriteLine("karkulka ma u sebe:");
            Console.WriteLine("víno: " + mapa[X, Y].Karkulka.Vino + "\nbábovku: " + mapa[X, Y].Karkulka.Babovka + "\nhouby: " + Houby + "\nkvítí: " + Kviti);
        }

        public void vypis()
        {
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for(int j = 0; j < mapa.GetLength(1); j++)
                {
                    Console.Write(mapa[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}