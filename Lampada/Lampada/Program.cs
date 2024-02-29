namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // INSTÂNCIA DE UM OBJETO
            Lampada lampada1 = new Lampada();

            //Chamando o método para Ligar a Lamp1
            lampada1.ligar();
            lampada1.cor();

            //Chamando o método para verificar se a lamp1 está ligada
            Console.WriteLine("A lâmpada está ligada? " + lampada1.estaLigada());
            Console.WriteLine("A lâmpada é de que cor? " + lampada1.estaCor());

        }
    }
}