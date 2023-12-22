using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia(numero: "1234-5678", modelo: "N456", imei: "11111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Instagram");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone(numero: "9123-4567", modelo: "I123", imei: "22222", memoria: 64);
        iphone.Ligar();
        iphone.InstalarAplicativo("Apple Music");
    }
}