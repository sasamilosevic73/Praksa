using System;

namespace ConsoleApp1
{
    class Program
    {
        /*  Na programskom jeziku C# napisati funkciju koja umeće prosleđeni string, koji se prenosi kao parametar funkcije, 
                u zadatoj rečenici. Prosleđeni string se umeće na zadatu poziciju koja se prenosi kao parametar funkcije. 
                U glavnom programu uneti rečenicu i string koji se umeće. Ubaciti string nakon svakog razmaka u rečenici. 
                Prikazati rečenicu pre i nakon modifikovanja.
            */

        static void umetnutiString(string recenica, string uRec)// f-ja je void(ne vraca) koja prima dva parametra tipa string nad kojima manipulisemo
        {
            for (int i = 0; i < recenica.Length; i++)// for petljom prolazimo kroz celi string
                if (recenica[i] == ' ')//postavlajamo uslov da trazimo indeks razmaka/blanko
                    recenica = recenica.Insert(i + 1, uRec);//umecemo string uRec nakon znaka razmaka/blanko i ponovo upisujemo u string recenica
            Console.WriteLine(recenica);// ispis promenljive recenica tipa string u konzolu
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu.");// ispis konzole za unos korisnika
            string recenica = Console.ReadLine();// unosimo recenicu koju treba formatirati
            Console.WriteLine("Unesite rec koju umecemo u recenicu");// ispis konzole za unos korisnika
            string uRec = Console.ReadLine();// unosimo rec koju umecemo u datu recenicu
            Console.WriteLine("Recenica nakon poziva f-je:");// ispis konzole nakon poziva f-je
            umetnutiString(recenica, uRec);// poziv f-je koja ubacuje string uRec u string recenica
            
        }
    }
}
