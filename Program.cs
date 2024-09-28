using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99999", modelo: "Nokia 3210", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "589564", modelo: "Iphone X", imei: "542895618", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");