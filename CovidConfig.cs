using System;
using System.IO;
using Newtonsoft.Json;

namespace TP_MODUL9_103022400084
{
    internal class CovidConfig
    {
        public string satuan_suhu;
        public int batas_hari_demam;
        public string pesan_ditolak;
        public string pesan_diterima;

        public CovidConfig()
        {
            config();
        }

        public void config()
        {
            string path = "covid_config.json";

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                dynamic data = JsonConvert.DeserializeObject(json);

                if ((string)data.satuan_suhu == "CONFIG1")
                {
                    satuan_suhu = "celcius";
                }
                else
                {
                    satuan_suhu = "celcius";
                }

                if ((string)data.batas_hari_demam == "CONFIG2")
                {
                    batas_hari_demam = 14;
                }
                else
                {
                    batas_hari_demam = 14;
                }

                if ((string)data.pesan_ditolak == "CONFIG3")
                {
                    pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                }
                else
                {
                    pesan_ditolak = "";
                }

                if ((string)data.pesan_diterima == "CONFIG4")
                {
                    pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
                }
                else
                {
                    pesan_diterima = "";
                }
            }
            else
            {
                satuan_suhu = "celcius";
                batas_hari_demam = 14;
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            }
        }

        public void UbahSatuan()
        {
            if (satuan_suhu == "celcius")
            {
                satuan_suhu = "fahrenheit";
            }
            else
            {
                satuan_suhu = "celcius";
            }
        }
    }
}
