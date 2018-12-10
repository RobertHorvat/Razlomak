using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba3_12
{
    class Razlomak: IComparable<Razlomak>,IEquatable<Razlomak>
    {
        private int brojnik, nazivnik;

        public Razlomak(int brojnik,int nazivnik)
        {
            this.brojnik = brojnik;
            this.nazivnik = nazivnik;
        }

        public void ZadajBrojnik(int brojnik)
        {
            this.brojnik = brojnik;
        }

        public void ZadajNazivnik(int nazivnik)
        {
            this.nazivnik = nazivnik;
        }

        public int VratiBrojnik()
        {
            return brojnik;
        }

        public int VratiNazivnik()
        {
            return nazivnik;
        }

        public float PretvoriUFloat()
        {
            return (float)brojnik / (float)nazivnik;
        }

        public string Ispravan()
        {
            if (nazivnik != 0)
                return "Nazivnik je ispravan";
            else
                return "Nazivnik neispravan";
        }

        private int nzd()
        {
            int djelitelj = 0;
            if(brojnik<nazivnik)
            {
                for (int N = brojnik; N > 0; N--) 
                {
                    if(brojnik%N==0 && nazivnik%N==0)
                    {
                        djelitelj = N;
                        break;
                    }



                }
            }
            else if (brojnik > nazivnik)
            {
                for (int N = nazivnik; N > 0; N--)
                {
                    if (brojnik % N == 0 && nazivnik % N == 0)
                    {
                        djelitelj = N;
                        break;
                    }


                }
            }
            return djelitelj;
        }

        //private int nzm(int a,int b)
        //{
        //    int t;
        //    while (b != 0)
        //    { 
        //        t = b;
        //        b = a % b;
        //        a = t;
        //    }
        //    return a;

        //}

        public void SkratiRazlomak()
        {
            int skraceniBrojnik, skraceniNazivnik;
            skraceniBrojnik = brojnik / nzd();
            skraceniNazivnik = nazivnik / nzd();
            Console.WriteLine("Skraceni razlomak iznosi: {0} / {1}", skraceniBrojnik, skraceniNazivnik);
        }

        

        public int CompareTo(Razlomak other)
        {
            //throw new NotImplementedException();
            if (PretvoriUFloat() > other.PretvoriUFloat())
                return 1;
            else if (PretvoriUFloat() < other.PretvoriUFloat())
                return -1;
            else
                return 0;
        }

        public bool Equals(Razlomak other)
        {
            //throw new NotImplementedException();
            return nazivnik == other.VratiNazivnik() && brojnik == other.VratiBrojnik();
        }

        public override bool Equals(object obj)
        {
            return Equals((Razlomak)obj);
        }
    }
}
