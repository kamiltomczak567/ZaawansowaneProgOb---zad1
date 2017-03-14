using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cwiczenia1
{
    class Program
    {
        ////////////////////////////////// KLASA SAMOCHÓD /////////////////////////////
        class Samochód
        {
            // Marka, LiczbaKol, Predkosc, Kolor, Rocznik
            // metody : Metody: Jedz (z podaniem predkosci), Hamuj

            private string Marka;
            private int LiczbaKol;
            public int Predkosc;
            private string Kolor;
            private int Rocznik;

            public void Jedz(int pred)
            {
                Console.WriteLine(this.Kolor + " samochod marki " + this.Marka + "jedzie z predkoscia " + this.Predkosc + "\n" + "Domyślna ilość kół używanych jednocześnie w samochodzie to " + this.LiczbaKol);
            }

            public void Hamuj()
            {
                Console.WriteLine("Hamuje");
            }

            public Samochód(string Marka, int LiczbaKol, int Predkosc, string Kolor, int Rocznik)
            {
                this.Marka = Marka;
                this.LiczbaKol = LiczbaKol;
                this.Predkosc = Predkosc;
                this.Kolor = Kolor;
                this.Rocznik = Rocznik;
            }

        }

        ////////////////////////////////// KLASA SAMOCHÓD END /////////////////////////////

        class KontoWBanku
        {
            public string ImiePosiadacza, NazwiskoPosiadacza, NumerKontaBankowego, CzyAktywne;
            public double FunduszeNaKoncie;
            public int Id;

            public KontoWBanku(string ImiePosiadacza, string NazwiskoPosiadacza, string NumerKontaBankowego, double FunduszeNaKoncie, int Id, string CzyAktywne)
            {
                this.ImiePosiadacza = ImiePosiadacza;
                this.NazwiskoPosiadacza = NazwiskoPosiadacza;
                this.NumerKontaBankowego = NumerKontaBankowego;
                this.FunduszeNaKoncie = FunduszeNaKoncie;
                this.Id = Id;
                this.CzyAktywne = "tak";
            }

            public void wypłaćPieniądze(double wypłać)
            {
                zmieńFunduszeKonta(this.FunduszeNaKoncie - wypłać);
            }

            public void zmieńFunduszeKonta(double funduszeNaKoncie)
            {
                this.FunduszeNaKoncie = funduszeNaKoncie;
            }

            public void usuńKonto() { }

            public void wpłaćPieniądze(double wypłać)
            {
                zmieńFunduszeKonta(this.FunduszeNaKoncie + wypłać);
            }
        }


        public class StandardowyCzłowiek
        {

            private string Imię;
            private int Wiek;
            public static int IlośćKościSzkieletowych = 250;
            private string MiejscePochodzenia;
            public static int IlośćHromosomów = 40;

            public StandardowyCzłowiek(string Imię, int Wiek, string MiejscePochodzenia)
            {
                this.Imię = Imię;
                this.Wiek = Wiek;
                this.MiejscePochodzenia = MiejscePochodzenia;
            }

            public int pobierzWiek()
            {
                return this.Wiek;
            }

            public string pobierzImię()
            {
                return this.Imię;
            }

            public string pobierzMiejsce()
            {
                return this.MiejscePochodzenia;
            }

        }



        static void Main(string[] args)
        {
            ///ZAD1///
            /*     List<Samochód> ListaPojazdow = new List<Samochód>();
                  Samochód Audi = new Samochód("Audi", 4, 90, "czarny", 2012);
                  Samochód Volkswagen = new Samochód("VW", 4, 120, "biały", 2000);
                  Samochód BMW = new Samochód("BMW", 4, 90, "różowy", 2014);
                  Samochód Cadilac = new Samochód("Cadilac", 4, 140, "niebieski", 2016);
                  ListaPojazdow.Add(Audi);
                  ListaPojazdow.Add(Volkswagen);
                  ListaPojazdow.Add(BMW);
                  ListaPojazdow.Add(Cadilac);

                 // for (int i = 0; i < ListaPojazdow.Count; i++ ) {
                  //    Console.WriteLine(ListaPojazdow[i].Kolor + " samochod marki " + ListaPojazdow[i].Marka + " jedzie z predkoscia " + ListaPojazdow[i].Predkosc + "\nDomyślna ilość kół używanych jednocześnie w samochodzie to " + ListaPojazdow[i].LiczbaKol + "\n");
                //  }
        
                  foreach(Samochód sam in ListaPojazdow){
                      sam.Jedz(sam.Predkosc);
                  }*/

            //END ZAD1///

            //ZAD2///

            /*     List<KontoWBanku> ListaKontWBanku = new List<KontoWBanku>();

                 KontoWBanku klient1 = new KontoWBanku("Kamil","Tomczak","774444",200,1,"TAK");
                 KontoWBanku klient2 = new KontoWBanku("Damian", "Damian", "774446", 100, 2,"TAK");
                 KontoWBanku klient3 = new KontoWBanku("Piotr", "Piotrek", "774444", 200, 3,"TAK");
                 KontoWBanku klient4 = new KontoWBanku("Andrzej", "Marynata", "774444", 200, 4,"TAK");

                 ListaKontWBanku.Add(klient1);
                 ListaKontWBanku.Add(klient2);
                 ListaKontWBanku.Add(klient3);
                 ListaKontWBanku.Add(klient4);

                 foreach (KontoWBanku konto in ListaKontWBanku)
                 {
                     Console.WriteLine("\n"+ konto.ImiePosiadacza + " " + konto.NazwiskoPosiadacza + " " + konto.NumerKontaBankowego + " " + konto.FunduszeNaKoncie +"\n");
                 }

                 Console.WriteLine("Które konto wybierasz?");

                 int wybor = Convert.ToInt32(Console.ReadLine());
            
                 Console.WriteLine("Wybrałeś konto nr " + wybor);

                 foreach (KontoWBanku konto in ListaKontWBanku)
                 {
                     if (wybor == konto.Id) {
                        // Console.WriteLine("KONTO NR "+konto.Id);
                         Console.WriteLine("WYBIERZ OPCJĘ ");
                         Console.WriteLine("Wciśnij 1 jeżeli chcesz dodać pieniądze na konto");
                         Console.WriteLine("Wciśnij 2 jeżeli chcesz dodać odsetki");
                         Console.WriteLine("Wciśnij 3 jeżeli chcesz ustawić konto do usunięcia");
                         int dokonaj = Convert.ToInt32(Console.ReadLine());
                         if (dokonaj == 1) {
                             Console.WriteLine("Podaj kwotę do wpłacenia");
                             int kwota = Convert.ToInt32(Console.ReadLine());
                             konto.wpłaćPieniądze(kwota);
                             Console.WriteLine("Na Twoim koncie jest " + konto.FunduszeNaKoncie + " zł");
                         }
                         if (dokonaj == 2)
                         {
                             Console.WriteLine("Podaj odsetki w %");
                             double odsetki = Convert.ToInt32(Console.ReadLine());
                             odsetki = (odsetki / 100) * konto.FunduszeNaKoncie + konto.FunduszeNaKoncie;
                             //konto.wpłaćPieniądze((odsetki/1000) * konto.FunduszeNaKoncie);
                             Console.WriteLine("Na Twoim koncie jest " + odsetki + " zł");
                         }
                         if (dokonaj == 3) {
                             Console.WriteLine("Które konto chcesz usunac");
                             konto.CzyAktywne = "nie";
                             Console.WriteLine("Ustawione konto do usuniecia to " + konto.Id);                       
                         }
                
                     }
		        
                 }   */
            // END ZAD 2//

            //ZAD 3//

            List<StandardowyCzłowiek> ListaStandardowyCzłowiek = new List<StandardowyCzłowiek>();
            StandardowyCzłowiek człowiek1 = new StandardowyCzłowiek("Kamil", 24, "Kolonia");
            StandardowyCzłowiek człowiek2 = new StandardowyCzłowiek("Marcin", 23, "Dusseldorf");
            StandardowyCzłowiek człowiek3 = new StandardowyCzłowiek("Komar", 22, "Kolonia");

            ListaStandardowyCzłowiek.Add(człowiek1);
            ListaStandardowyCzłowiek.Add(człowiek2);
            ListaStandardowyCzłowiek.Add(człowiek3);

            List<string> listaNajczęstszych = new List<string>();

            int sredniaObiektów = 0;
            Console.WriteLine("Wszystkie imiona z listy to ");
            foreach (StandardowyCzłowiek standard in ListaStandardowyCzłowiek)
            {

                sredniaObiektów = (sredniaObiektów + standard.pobierzWiek());
                Console.WriteLine(standard.pobierzImię());

                string skadpochodzi = standard.pobierzMiejsce();
                listaNajczęstszych.Add(skadpochodzi);



            }

            var najczęsciej = (from naj in listaNajczęstszych where naj != null group naj by naj into grp orderby grp.Count() descending select grp.Key).First();
            Console.WriteLine("NAJCZESTSZE MIASTO " + najczęsciej);

            sredniaObiektów = sredniaObiektów / ListaStandardowyCzłowiek.Count;
            Console.WriteLine("Srednia wieku to " + sredniaObiektów);

            Console.WriteLine("ILOSC HROMOSOMOW " + StandardowyCzłowiek.IlośćHromosomów);
            Console.WriteLine("ILOSC KOSCI " + StandardowyCzłowiek.IlośćKościSzkieletowych);




            //END ZAD 3//

            Console.ReadKey();

        }
    }
}
