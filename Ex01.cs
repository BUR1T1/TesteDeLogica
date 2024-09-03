class Ex01
{
    public void Executar(){
          Console.Write("digite um numero: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (PertenceAFibonacci(num))
            {
                Console.WriteLine($"{num} está na  sequência de fibonacci.");
            }
            else
            {
                Console.WriteLine($"{num} não está na sequência de fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("entrada inválida. Por favor, insira um numero inteiro.");
        }
    }

    static bool PertenceAFibonacci(int num)
    {
        if (num < 0)
        {
            return false;
        }

        int a = 0, b = 1;

        while (a <= num)
        {
            if (a == num)
            {
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }

}