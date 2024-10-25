using System.Reflection.Metadata;

namespace _5m05consPalindrom
{
    internal class Program
    {
    // nazwa: czyPalindrom
    // opis: Sprawdza, czy podane słowo jest palindromem, porównując jego odwrotność z oryginałem.
    // parametry:

    // slowo: string - słowo do sprawdzenia
    // zwracany typ i opis: bool - zwraca true, jeśli słowo jest palindromem, w przeciwnym razie false
    // autor: Dominik Kołodziej

        private static bool czyPalindrom(string slowo)
        {
            slowo = slowo.ToLower();
            string w = "";
            foreach (var c in slowo)
                w = c + w;
            return w == slowo;
        }
    // nazwa: czyPalindrom2
    // opis: Sprawdza, czy podane słowo jest palindromem, porównując znaki od początku i końca słowa.
    // parametry:

    // slowo: string - słowo do sprawdzenia
    // zwracany typ i opis: bool - zwraca true, jeśli słowo jest palindromem, w przeciwnym razie false
    // autor: Dominik Kołodziej
        private static bool czyPalindrom2(string slowo)
        {
            slowo = slowo.ToLower();
            for (int i = 0; i < slowo.Length / 2; i++)
                if (slowo[i] != slowo[slowo.Length - 1 - i])
                    return false;
            return true;
        }
    // nazwa: czyPalindrom
    // opis: Sprawdza, czy podana liczba jest palindromem, konwertując ją na string i wykorzystując metodę czyPalindrom.
    // parametry:

    // n: int - liczba do sprawdzenia
    // zwracany typ i opis: bool - zwraca true, jeśli liczba jest palindromem, w przeciwnym razie false
    // autor: Dominik Kołodziej
        private static bool czyPalindrom(int n)
        {
            return czyPalindrom(n.ToString());
        }
    // nazwa: czyPalindrom3
    // opis: Sprawdza, czy podane zdanie jest palindromem, ignorując znaki interpunkcyjne i spacje.
    // parametry:

    // slowo: string - zdanie do sprawdzenia
    // zwracany typ i opis: bool - zwraca true, jeśli zdanie jest palindromem, w przeciwnym razie false
    // autor: Dominik Kołodziej
        private static bool czyPalindrom3(string slowo)
        {
            string s = " .,?!";
            string w = "";
            foreach (var c in slowo)
                if (s.IndexOf(c) == -1)
                    w += c;
            return czyPalindrom(w);
        }
        // nazwa: Main
    // opis: Metoda główna aplikacji, która pobiera od użytkownika słowo i liczbę, a następnie sprawdza, czy są one palindromami, wykorzystując różne metody do ich weryfikacji.
    // parametry: brak
    // zwracany typ i opis: brak
    // autor: Dominik Kołodziej
        static void Main(string[] args)
        {
            Console.Write("poaj słowo: ");
            //string slowo = Console.ReadLine();  
            string slowo = "kajak";
            if (czyPalindrom2(slowo))
                Console.WriteLine($"{slowo} to jest palindrom");
            else
                Console.WriteLine($"{slowo} to nie jest palindrom");
            
            
            Console.WriteLine("Podaj liczbę");
            //int liczba = int.Parse(Console.ReadLine());
            int liczba = 34234234;
            if (czyPalindrom(liczba))
                Console.WriteLine($"{liczba} to jest palindrom");
            else
                Console.WriteLine($"{liczba} to nie jest palindrom");
            
            slowo = "Zakopane na pokaz.";
            if (czyPalindrom3(slowo))
                Console.WriteLine($"{slowo} to jest palindrom");
            else
                Console.WriteLine($"{slowo} to nie jest palindrom");
            

    }
}