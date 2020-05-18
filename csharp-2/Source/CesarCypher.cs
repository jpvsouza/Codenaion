using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        public string Crypt(string message)
        {
            //97 ate 122 letras
            //48 ate 57 numeros
            //32 espaco
            if (message == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                char[] frase = message.ToCharArray();
                List<char> cripto = new List<char>();

                if (frase.Count() == 0)
                {
                    return message; //vazio
                }
                else
                {
                 
                    foreach (char letra in message.ToLower())
                    {
                        if(letra == 120)
                        {
                            cripto.Add('a');
                        }
                        else if (letra == 121)
                        {
                            cripto.Add('b');
                        }
                        else if (letra == 122)
                            {
                            cripto.Add('c');
                        }
                        else if (letra > 96 && letra <120)
                        {
                            cripto.Add(Convert.ToChar(letra + 3));
                        }
                        else if (letra == 32 ||letra > 47 && letra < 58)
                        {
                            cripto.Add(letra);
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }

                    string retorno = string.Empty;
                    foreach (var codigo in cripto)
                    {
                        retorno += codigo.ToString();
                    }
                    return retorno;
                }
                
            }
        }

        public string Decrypt(string cryptedMessage)
        {
            if (cryptedMessage == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                char[] frase = cryptedMessage.ToCharArray();
                List<char> cripto = new List<char>();

                if (frase.Count() == 0)
                {
                    return cryptedMessage; //vazio
                }
                else
                {
                    foreach (char letra in cryptedMessage.ToLower())
                    {
                        if (letra == 97)
                        {
                            cripto.Add('x');
                        }
                        else if (letra == 98)
                        {
                            cripto.Add('y');
                        }
                        else if (letra == 99)
                        {
                            cripto.Add('z');
                        }
                        else if (letra > 99 && letra < 123)
                        {
                            cripto.Add(Convert.ToChar(letra - 3));
                        }
                        else if (letra == 32 || letra > 47 && letra < 58)
                        {
                            cripto.Add(letra);
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }
                }
                string retorno = string.Empty;
                foreach (var codigo in cripto)
                {
                    retorno += codigo.ToString();
                }
                return retorno;
            }
        }
    }
}
