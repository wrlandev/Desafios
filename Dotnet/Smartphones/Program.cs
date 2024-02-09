using Smartphones.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Nokia(numero: "789101", modelo: "Modelo 2", imei: "2222222", memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");