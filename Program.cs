using System.Runtime.InteropServices;

class Program
{
    public static void Main(string[] args){

        Ex01 ex01= new Ex01();
        ex01.Executar();

        Ex02 ex02= new Ex02();
        ex02.Executar();

        Ex03 ex03 = new Ex03();
        ex03.Executar();

        //resposta da questão 03 : noma = 77;

        //4) Descubra a lógica e complete o próximo elemento:
        //a) 1, 3, 5, 7, 9
        //b) 2, 4, 8, 16, 32, 64, 128
        //c) 0, 1, 4, 9, 16, 25, 36, 49
        //d) 4, 16, 36, 64, 100
        //e) 1, 1, 2, 3, 5, 8, 100
        //f) 2,10, 12, 16, 17, 18, 19, 20

        //reposta da questão 05:
        //eu ligaria o Interruptor A e deixaria ligado por um tempo. e depois desligava,
        //depois eu ligaria o interruptor B e deixaria ligada.
        //iria até a primeira sala se a lampada estivese queten e desligada seria , a lampadado interruptor A.
        //iria para outra sala se a lampada estiver acessa seria a lampada do interruptor a que esta ligado,
        //se a lampada estiver apagada seria do interrupto C que não foi acionado em nenhum momento.

    }
}
