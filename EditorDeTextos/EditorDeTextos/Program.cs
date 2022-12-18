namespace EditorDeTextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");            
            Console.WriteLine("1 - Abrir arquivo");            
            Console.WriteLine("2 - Criar arquivo");            
            Console.WriteLine("0 - Sair");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Criar();break;
                default: Menu(); break;
            }            
        }

        static void Abrir()
        {

        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair) ");
            Console.WriteLine("---------------------");
            string texto = "";

            // enquanto o comando for diferente de 'ESC'
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

            }
        }       
    }
}
