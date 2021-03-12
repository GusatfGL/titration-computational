using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pwd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Password: ");
            //string pwd = Console.ReadLine();
            //Console.WriteLine("Do you want to manually set the encryption key (y/n)?");
            //string choice = Console.ReadLine();
            //if (choice.ToLower() == "y" || choice.ToLower() == "yes")
            //{

            //}
            //else
            //{

            //}
            try
            {
                //Create a TCP connection to a listening TCP process.  
                //Use "localhost" to specify the current computer or  
                //replace "localhost" with the IP address of the   
                //listening process.    
                TcpClient TCP = new TcpClient("127.0.0.1", 11000);

                //Create a network stream from the TCP connection.   
                NetworkStream NetStream = TCP.GetStream();

                //Create a new instance of the RijndaelManaged class  
                // and encrypt the stream.  
                RijndaelManaged RMCrypto = new RijndaelManaged();

                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                //Create a CryptoStream, pass it the NetworkStream, and encrypt   
                //it with the Rijndael class.  
                CryptoStream CryptStream = new CryptoStream(NetStream,
                RMCrypto.CreateEncryptor(Key, IV),
                CryptoStreamMode.Write);

                //Create a StreamWriter for easy writing to the   
                //network stream.  
                StreamWriter SWriter = new StreamWriter(CryptStream);

                //Write to the stream.  
                SWriter.WriteLine("Hello World!");

                //Inform the user that the message was written  
                //to the stream.  
                Console.WriteLine("The message was sent.");

                //Close all the connections.  
                SWriter.Close();
                CryptStream.Close();
                NetStream.Close();
                TCP.Close();
            }
            catch
            {
                //Inform the user that an exception was raised.  
                Console.WriteLine("The connection failed.");
            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
