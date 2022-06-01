using System;
using System.IO;

namespace GESTDOC.Utilis
{
    public partial class Base64
    {
        public static byte[] Generar(string A)
        {
            byte[] arreglo = null;
            arreglo = File.ReadAllBytes(A);
            return arreglo;
        }
        public static string enc64(byte[] buffer, int longitud, string separador)
        {
            string returnValue = enc64(buffer), h = "";
            int y = 0;
            while (y < returnValue.Length)
            {
                h += returnValue.Substring(y, (y + longitud) > returnValue.Length ? returnValue.Length - y : longitud) + separador;
                y += longitud;
            }
            return h;
        }
        public static string enc64(byte[] buffer)
        {
            string returnValue = System.Convert.ToBase64String(buffer);
            return returnValue;
        }
        public string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
        public string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }
    }
}
