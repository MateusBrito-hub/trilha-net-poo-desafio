using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123", "1111111111", "Modelo 1", 32);
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();
nokia.Ligar();


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("123", "22222222", "Modelo 2", 16);
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();
iphone.Ligar();