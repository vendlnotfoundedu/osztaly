using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace osztaly
{
    internal class Auto
    {
        private int gyartasiEv;
        public string Marka { get; set; }
        public string Modell { get; set; }
        public int GyartasiEv
        {
            get { return gyartasiEv; }
            set { if (value > 1886 && value <= 2026)
                {
                    gyartasiEv = value;
                }
                else gyartasiEv = 0;
            }
        }
        public Auto(int GyartasiEv, string modell, string marka)
        {
            this.GyartasiEv = GyartasiEv;
            Modell = modell;
            Marka = marka;
        }
        public void KiirAdatok()
        {
            Console.WriteLine($"{Marka} {Modell} - Gyártási év: {GyartasiEv}");
        }
    }
}
