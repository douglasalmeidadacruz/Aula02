public static class Exercicio5
{
    public static void Executar()
    {
        string nome = " ";
        string estiloMusical = " ";
        string artistaFavorito = " ";

        Console.Write("Qual seu nome?: ");
        nome = Console.ReadLine()!;
        Console.Clear();

        Console.Write("Qual seu estilo musical favorito?: ");
        estiloMusical = Console.ReadLine()!;
        Console.Clear();

        Console.Write("Qual seu artista favorito?: ");
        artistaFavorito = Console.ReadLine()!;

        Console.WriteLine($"Eu sou o {nome}, curto o estilo musical \"{estiloMusical}\" e meu artista favorito é \"{artistaFavorito}\". ");;
    }
}