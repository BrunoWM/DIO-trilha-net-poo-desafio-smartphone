using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Iphone:");
Iphone iphone = new Iphone("62970707070", "iphone 24", "12345", 32);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine("----------------------------");
Console.WriteLine("Testando Nokia:");
Nokia nokia = new Nokia("62960606060", "nokia 1100", "98765", 250);
nokia.Ligar();
nokia.InstalarAplicativo("jogo da cobrinha");


