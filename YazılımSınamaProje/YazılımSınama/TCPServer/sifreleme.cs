using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TCPServer
{
    public class sifreleme
    {
        public string StringToBinary(string data)//string veriyi binary veriye çeviriyor
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public string BinaryToString(string data)//binary veriyi string veriye çeviriyor
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public string SHA_256_sifreleme(string deger)
        {
            SHA256 sha = SHA256.Create();
            byte[] degerBytes = Encoding.UTF8.GetBytes(deger);
            byte[] shaBytes = sha.ComputeHash(degerBytes);
            return HashToByte(shaBytes);
        }

        public string HashToByte(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte item in hash)
            {
                result.Append(item.ToString("x2"));

            }

            return result.ToString();
        }
        public string keys(string metinBinary)
        {
            string key = "yazılımsınamas";
            string tempkey, keyBinary;
            string sifreliMetin = "";
            char[] yeniSifreliMetin = new char[16];
            tempkey = key;

            for (int i = 0; i < 4; i++)
            {
                keyBinary = StringToBinary(tempkey.Substring(0, 2));

                sifreliMetin = "";
                for (int j = 0; j < 16; j++)// XOR işlemi 
                {
                    sifreliMetin += keyBinary[j] ^ metinBinary[j];

                }

                if (i == 0)//Karma işlemi uygulanıyor
                {
                    yeniSifreliMetin[7] = sifreliMetin[0];
                    yeniSifreliMetin[4] = sifreliMetin[1];
                    yeniSifreliMetin[6] = sifreliMetin[2];
                    yeniSifreliMetin[12] = sifreliMetin[3];
                    yeniSifreliMetin[1] = sifreliMetin[4];
                    yeniSifreliMetin[5] = sifreliMetin[5];
                    yeniSifreliMetin[10] = sifreliMetin[6];
                    yeniSifreliMetin[2] = sifreliMetin[7];
                    yeniSifreliMetin[9] = sifreliMetin[8];
                    yeniSifreliMetin[11] = sifreliMetin[9];
                    yeniSifreliMetin[3] = sifreliMetin[10];
                    yeniSifreliMetin[15] = sifreliMetin[11];
                    yeniSifreliMetin[8] = sifreliMetin[12];
                    yeniSifreliMetin[14] = sifreliMetin[13];
                    yeniSifreliMetin[0] = sifreliMetin[14];
                    yeniSifreliMetin[13] = sifreliMetin[15];
                    string strDonustur = new string(yeniSifreliMetin);//char dizisi halindeki veri tekrar string hale getiriliyor.
                    metinBinary = strDonustur;
                }
                else
                {
                    metinBinary = sifreliMetin;
                }
                tempkey = tempkey.Substring(2, tempkey.Length - 2);    //keyin ilk 2 hanesi siliniyor
            }
            return sifreliMetin;    //şifrelenen ilk 2 karakter geri gönderiliyor
        }
        public string SPN16(string mesaj)    //spn sifreleme işlemlerinin başladığı method.
        {
            string tempmesaj = mesaj;
            string mesajbinary;
            string sifrelimesaj = "";

            for (int i = 0; i < mesaj.Length / 2; i++)  //2 karakter şeklinde ilerlendiği için metin uzunluğunun yarısı kadar dönüyor
            {
                mesajbinary = StringToBinary(tempmesaj.Substring(0, 2)); //metinin ilk iki karakteri çekilip binary hale getiriliyor
                sifrelimesaj += keys(mesajbinary);  //binary hale getirilen 2 karakter keys fonksiyonuna gönderiliyor
                tempmesaj = tempmesaj.Substring(2, tempmesaj.Length - 2);  //burada metnin ilk iki karakteri siliniyor

            }
            return sifrelimesaj;    //metnin şifrelenmiş hali formda gösterilmek üzere geri gönderiliyor.

        }
    }
}
