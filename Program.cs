using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "M1", imei: "11111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "456", modelo: "M2", imei: "22222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");