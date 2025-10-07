namespace smartphone.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Acessando App Store...");
            Thread.Sleep(3000);
            Console.WriteLine($"Pesquisando {nomeApp}...");
            Thread.Sleep(1000);
            Console.WriteLine($"Baixando {nomeApp}...");
            Thread.Sleep(6000);
            Console.WriteLine($"{nomeApp} instalado com sucesso!\nPressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}