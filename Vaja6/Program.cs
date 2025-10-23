﻿using System.IO;

namespace vaja6 {

    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

        //neki podatki//
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        //pridobi id//
        public int Id {
            get
            {
                return id;
            }
        }

        //pridobi ime//
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        //pridobi geslo//
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        //ne vem kaj je to//
        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
