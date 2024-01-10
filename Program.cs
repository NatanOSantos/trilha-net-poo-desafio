using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Nokia nokia = new Nokia("123456", "Nokia 3310", "123456789012345", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Criando um objeto Iphone
        Iphone iphone = new Iphone("654321", "Iphone 13", "543210987654321", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}