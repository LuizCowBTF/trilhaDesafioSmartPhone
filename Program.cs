using System.Net.Mail;
using trilhaDesafioSmartPhone.Models;


Console.WriteLine("SmartPhone Nokia: ");

Smartphone nokia = new Nokia(numero:"+552122220001", modelo:"proMax", imei:"1000101101", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Candy Crush Saga");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone IPhone: ");

Smartphone iphone = new Iphone(numero:"+552199990009", modelo:"proALL", imei:"1111101101", memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Clash Royale");

