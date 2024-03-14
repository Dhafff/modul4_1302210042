using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string a;

        KodeBuah kodeBuah = new KodeBuah();

        Console.WriteLine("========================================================");
        Console.WriteLine("Selamat datang. Macam-macam buah yang ada di pengecekan:");

        Console.WriteLine();
        Console.WriteLine("| 1. Apel   | 2. Aprikot | 3. Alpukat    |");
        Console.WriteLine("| 4. Pisang | 5. Paprika | 6. Blackberry |");
        Console.WriteLine("| 7. Ceri   | 8. Kelapa  | 9. Jagung     |");
        Console.WriteLine();

        Console.Write("Masukan buah yang ingin di cari kodenya: ");
        a = Console.ReadLine();
        Console.WriteLine();

        if (a == "Apel")
        {
            string buah = "Apel";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Aprikot")
        {
            string buah = "Aprikot";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Alpukat")
        {
            string buah = "Alpukat";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Pisang")
        {
            string buah = "Pisang";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Paprika")
        {
            string buah = "Paprika";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Blackberry")
        {
            string buah = "Blackberry";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Ceri")
        {
            string buah = "Ceri";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Kelapa")
        {
            string buah = "Kelapa";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else if (a == "Jagung")
        {
            string buah = "Jagung";
            string kode_buah = kodeBuah.getBuah(buah);
            Console.WriteLine($"Kode buah untuk buah {buah} adalah {kode_buah}");
        }
        else
        {
            Console.WriteLine("Maaf, buah yang anda cari tidak ada dalam tabel");
        }

        Console.WriteLine("========================================================");
    }
}

public class KodeBuah
{
    public Dictionary<string, string> kodeBuahTable = new Dictionary<string, string>
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"},
    };

    public string getBuah(string buah) {
        if (kodeBuahTable.ContainsKey(buah))
        {
            return kodeBuahTable[buah];
        } else
        {
            return "gaada buahnya";
        }
    }
}