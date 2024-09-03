class Ex02{

    public  void Executar(){

           Console.Write("Digite uma string para verificar a ocorrência da letra 'a': ");
        string entrada = Console.ReadLine();

        int contagem = ContarOcorrenciasDeA(entrada);
        
        if (contagem > 0)
        {
            Console.WriteLine($"A letra 'a' ocorre {contagem} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não ocorre na string.");
        }
    }

    public static int ContarOcorrenciasDeA(string texto)
    {
        int contagem = 0;

        if (!string.IsNullOrEmpty(texto))
        {
            foreach (char c in texto)
            {
                if (c == 'a' || c == 'A')
                {
                    contagem++;
                }
            }
        }

        return contagem;
    }
}
    