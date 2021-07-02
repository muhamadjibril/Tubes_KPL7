using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKPL_7
{
    class Class2
    {
        public enum Kegiatan { Game, Produktif, Pekerjaan, RumahTangga };
        public static string[] Olahraga = { "Tenis", "voly", "Karate", "Berenang"};

        public static string getOlahraga(Kegiatan kegiatan)
        {
            return Olahraga[(int)kegiatan];
        }
    }
}
