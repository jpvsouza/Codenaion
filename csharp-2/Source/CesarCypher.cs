using System;
using System.Collections.Generic;
using System.Linq;

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
                    message.ToLower();
                    foreach (char letra in message)
                    {
                        if(letra == 121)
                        {
                            cripto.Add('a');
                        }
                        else if (letra == 122)
                        {
                            cripto.Add('b');
                        }
                        else if (letra > 99 && letra <123)
                        {
                            cripto.Add(Convert.ToChar(letra + 2));
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
                }
                return cripto.ToString();
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
                    cryptedMessage.ToLower();
                    foreach (char letra in cryptedMessage)
                    {
                        if (letra == 97)
                        {
                            cripto.Add('y');
                        }
                        else if (letra == 98)
                        {
                            cripto.Add('z');
                        }
                        else if (letra > 98 && letra < 123)
                        {
                            cripto.Add(Convert.ToChar(letra - 2));
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
                return cripto.ToString();
            }
        }
    }
}
