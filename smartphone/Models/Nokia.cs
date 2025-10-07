namespace smartphone.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Acessando Play Store...");
            Thread.Sleep(5000);
            Console.WriteLine($"Pesquisando {nomeApp}...");
            Thread.Sleep(2000);
            Console.WriteLine($"Baixando {nomeApp}...");
            Thread.Sleep(10000);
            Console.WriteLine($"{nomeApp} instalado com sucesso!\nPressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}