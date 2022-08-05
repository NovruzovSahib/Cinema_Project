using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaProject
{
    internal class Cinema
    {
        int UmumiYersayi;
        double bosyersayi;
        double Qazanc;
        int ZalNo;
        const double azyasliusaq = 5;
        const double axsam = 8;
        const double seher = 6;
        int axsamsayi;
        int sehersayi;
        int endirimsayi;
        
        public Cinema(int Zalno_, int yersayi_)
        {
            UmumiYersayi = yersayi_;
            ZalNo = Zalno_;
            bosyersayi = UmumiYersayi;
            Qazanc = 0;
        }

        public void Biletsat(bool axsamseans, bool seherseans, bool Azyasli)
        {
            bosyersayi--;
            if (axsamseans)
            {
                Qazanc += axsam;
            }
            else if (seherseans)
            {
                Qazanc += seher;
            }
            else if (Azyasli)
            {
                Qazanc += azyasliusaq;

            }

            if (bosyersayi < 0)
            {
                bosyersayi = 0;
            }
         
        }
            public void Pulmiqdarsayi(bool axsamsay, bool sehersay, bool endirimlisay)
            {

                if (axsamsay)
                {
                    axsamsayi++;
                }
                else if (sehersay)
                {
                    sehersayi++;
                }
                else if (endirimlisay)
                {
                    endirimsayi++;
                }
                    
            }


        public void Biletinlegvi(bool legv_axsam,bool legv_seher, bool legv_azyasli) 
        {
            bosyersayi++;
            if (legv_axsam)
            {
                Qazanc -= axsam;
            }
            else if (legv_seher)
            {
                Qazanc -= seher;
            }
            else if (legv_azyasli)
            {
                Qazanc -= azyasliusaq;

            }
          
        }
        public double Bosyersayi()
        {
            return bosyersayi;
        }
        public double Qazancim() 
        {
            return Qazanc;
        }

        public int Axsammiqdar()
        {
            return axsamsayi;
        }
        public int Sehermiqdar()
        {
            return sehersayi;
        }
        public int Endirimmiqdar()
        {
            return endirimsayi;
        }
      
    }
}
