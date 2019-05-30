using System;

namespace ConsoleApp1
{
    class Program
    {
        const string _separador = "-------------------------------------------------------------------------------------------";
        const string _mensagemErro = "Opsss! Você errou. Mas não fique triste, ainda resta uma chance. Vamos lá:";
        const string _mensagemErroFatal = "Poxa, você esgotou suas tentativas. Agora vamos para a próxima pergunta";
        const string _mensagemAcerto = "Parabéns! Você acertou, próxima pergunta:";

        static void Main(string[] args)
        {
            Console.WriteLine(_separador);

            ExecutarQuiz();

            Console.ReadKey();
        }

        //Atividade MAPA - Jogo com cinco perguntas sobre a disciplina

        private static void ExecutarQuiz()
        {
            Console.WriteLine("Olá, vamos começar o jogo? Para prosseguir aperte 'Enter'.");
            Console.ReadLine();
            Console.WriteLine(_separador);
            Console.WriteLine("São cinco perguntas. Se você acertar na primeira tentativa ganha 10 pontos.");
            Console.WriteLine("Se acertar na segunda tentativa ganha 5 pontos. Sim, são duas chances! :)");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine(_separador);
            Console.WriteLine("Para responder basta inserir a letra correspondente a opção escolhida.");
            Console.ReadLine();

            string perguntaUm = "QUAL O COMANDO PARA EXIBIR MENSAGENS?";
            char checkRespostaUm = 'E';
            string perguntaDois = "QUAL O COMANDO PARA DESVIO DE FLUXO NA EXECUÇÃO DE PROGRAMAS?";
            string perguntaTres = "QUAL O COMANDO PARA RECEBER DADOS PELO TECLADO?";
            string perguntaQuatro = "QUAL O COMANDO PARA INICIAR A DECLARAÇÃO DE VARIÁVEIS?";
            string perguntaCinco = "QUAL O COMANDO PARA CRIAR LAÇOS DE REPETIÇÃO CONTADOS?";
            string opcoes =
                "As opções de respostas são essas: " +
                "\n"
                + "\n(L) LEIA"
                + "\n(E) ESCREVA"
                + "\n(P) PARA"
                + "\n(S) SE"
                + "\n(V) VAR" +
                "\n"
                +"\nAgora insira a letra escolhida e aperte 'Enter':";

            ExibePergunta(perguntaUm, opcoes);

            int primeiraChance = 10;
            int segundaChance = 5;
            int pontuacao = 0;

            char respostaUm = (char)Console.ReadLine().ToUpper().ToCharArray()[0];
            bool verificaPerguntaUm = VerificaResposta(checkRespostaUm, respostaUm);

            if(verificaPerguntaUm != true)
            {
                ExibePergunta(perguntaUm, opcoes);
                respostaUm = (char)Console.ReadLine().ToUpper().ToCharArray()[0];
                verificaPerguntaUm = VerificaResposta(checkRespostaUm, respostaUm);
            }


            Console.ReadLine();

            //Console.WriteLine("Pergunta");
            //Console.WriteLine(perguntaDois);

            //Console.WriteLine("Pergunta");
            //Console.WriteLine(perguntaTres);
            //Console.WriteLine("Pergunta");
            //Console.WriteLine(perguntaQuatro);

            //Console.WriteLine("Pergunta");
            //Console.WriteLine(perguntaCinco);
        }

        private static bool VerificaResposta(char respostaCerta, char respostaEscolhida)
        {
            return respostaCerta == respostaEscolhida ? true : false;
        }

        private static void ExibePergunta(string pergunta, string opcoes)
        {
            Console.WriteLine("Vamos lá!");
            Console.ReadLine();
            Console.WriteLine(_separador);
            Console.WriteLine("Pergunta:");
            Console.WriteLine(pergunta);
            Console.WriteLine();
            Console.WriteLine(opcoes);
            Console.WriteLine(_separador);
        }
    }
}
