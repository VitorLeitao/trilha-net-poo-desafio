using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        // Testando Nokia
        Nokia nokia = new Nokia("123456", "Nokia Tijolao", "000000", 64);
        TestarSmartphone(nokia, "Jogo da cobrinha");

        // Testando Iphone
        Iphone iphone = new Iphone("789012", "iPhone 13", "1111", 256);
        TestarSmartphone(iphone, "TikTok");

    }

    // FUnção para testar TODAS as funções
    static void TestarSmartphone(Smartphone smartphone, string nomeApp)
    {
        Console.WriteLine($"Informações do smartphone - Modelo: {smartphone.Modelo}, Memória: {smartphone.Memoria}GB");
        smartphone.Ligar();
        smartphone.ReceberLigacao();
        smartphone.InstalarAplicativo(nomeApp);
        Console.WriteLine();
    }
}