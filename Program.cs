using System;
using TP_MODUL9_103022400084;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();
        config.UbahSatuan();
        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + config.satuan_suhu + ": ");
        double suhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hari = Convert.ToInt32(Console.ReadLine());
        bool suhuValid = false;

        if (config.satuan_suhu == "celcius")
        {
            if (suhu >= 36.5 && suhu <= 37.5)
            {
                suhuValid = true;
            }
        }
        else
        {
            if (suhu >= 97.7 && suhu <= 99.5)
            {
                suhuValid = true;
            }
        }

        bool hariValid = false;
        if (hari < config.batas_hari_demam)
        {
            hariValid = true;
        }

        if (suhuValid && hariValid)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }
    }
}