using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazlab.Models
{
    internal class Kullanicilar
    {
        public Kullanicilar(int kullanici_Id, string kullanici_Adi, string kullanici_Sifre, string kullanici_Rol)
        {
            Kullanici_Id = kullanici_Id;
            Kullanici_Adi = kullanici_Adi;
            Kullanici_Sifre = kullanici_Sifre;
            Kullanici_Rol = kullanici_Rol;
        }

        public int Kullanici_Id { get; set; }
        public string Kullanici_Adi { get; set; }

        public string Kullanici_Sifre { get; set; }

        public string Kullanici_Rol { get; set; }

        
    }
}
