namespace Smartphones.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"Numero: {numero} Modelo: {modelo} IMEI: {imei} Memoria {memoria}");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}");
        }
    }
}
