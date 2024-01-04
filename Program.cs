using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia ");
Smartphone nokia = new Nokia (numero: "11 999998888", Modelocelular: "Nolia C2", Imeicelular: "1223123123123123", Memoriacelular: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "12 988889999", Modelocelular: "Iphone X", Imeicelular: "112254151115111", Memoriacelular: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
