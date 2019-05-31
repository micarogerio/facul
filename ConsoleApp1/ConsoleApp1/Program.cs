using System;

namespace ConsoleApp1
{
    class Program
    {
        const string _separador = "-------------------------------------------------------------------------------------------";
        const string _mensagemErro = "Opsss! Você errou. Mas não fique triste, ainda resta uma chance.";
        const string _mensagemErroFatal = "Poxa, você esgotou suas tentativas. Agora vamos para a próxima pergunta:";
        const string _mensagemAcerto = "Parabéns! Você acertou ;)";
        const string _mensagemProximaPergunta = "Próxima pergunta!";

        #region Perguntas
        const string perguntaUm = "QUAL O COMANDO PARA EXIBIR MENSAGENS?";
        const string perguntaDois = "QUAL O COMANDO PARA DESVIO DE FLUXO NA EXECUÇÃO DE PROGRAMAS?";
        const string perguntaTres = "QUAL O COMANDO PARA RECEBER DADOS PELO TECLADO?";
        const string perguntaQuatro = "QUAL O COMANDO PARA INICIAR A DECLARAÇÃO DE VARIÁVEIS?";
        const string perguntaCinco = "QUAL O COMANDO PARA CRIAR LAÇOS DE REPETIÇÃO CONTADOS?";
        #endregion

        #region Respostas
        const char _checkRespostaUm = 'E';
        const char _checkRespostaDois = 'S';
        const char _checkRespostaTres = 'L';
        const char _checkRespostaQuatro = 'V';
        const char _checkRespostaCinco = 'P';
        #endregion

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

            int pontuacaoTotal = 0;

            pontuacaoTotal += LacoPerguntas(perguntaUm, _checkRespostaUm);
            Console.ReadLine();

            Console.WriteLine(_mensagemProximaPergunta);
            pontuacaoTotal += LacoPerguntas(perguntaDois, _checkRespostaDois);
            Console.ReadLine();

            Console.WriteLine(_mensagemProximaPergunta);
            pontuacaoTotal += LacoPerguntas(perguntaTres, _checkRespostaTres);
            Console.ReadLine();

            Console.WriteLine(_mensagemProximaPergunta);
            pontuacaoTotal += LacoPerguntas(perguntaQuatro, _checkRespostaQuatro);
            Console.ReadLine();

            pontuacaoTotal += LacoPerguntas(perguntaCinco, _checkRespostaCinco);
            Console.ReadLine();

            Console.WriteLine("Chegamos ao final! Agora vamos checar sua pontuação:");
            Console.ReadLine();
            Console.WriteLine(_separador);

            VerificaPontuacao(pontuacaoTotal);

            Console.ReadLine();
            Console.WriteLine("The End!");

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

        private static int LacoPerguntas(string pergunta, char resposta)
        {
            string opcoes =
                "As opções de respostas são essas: " +
                "\n"
                + "\n(L) LEIA"
                + "\n(E) ESCREVA"
                + "\n(P) PARA"
                + "\n(S) SE"
                + "\n(V) VAR" +
                "\n"
                + "\nAgora insira a letra escolhida e aperte 'Enter':";

            ExibePergunta(pergunta, opcoes);

            int primeiraChance = 10;
            int segundaChance = 5;
            int pontuacao = 0;

            char respostaUser = (char)Console.ReadLine().ToUpper().ToCharArray()[0];
            bool verificaPerguntaUm = VerificaResposta(resposta, respostaUser);

            if (verificaPerguntaUm != true)
            {
                Console.WriteLine(_mensagemErro);
                Console.ReadLine();
                ExibePergunta(pergunta, opcoes);
                respostaUser = (char)Console.ReadLine().ToUpper().ToCharArray()[0];
                verificaPerguntaUm = VerificaResposta(resposta, respostaUser);

                if (verificaPerguntaUm == true)
                {
                    pontuacao = segundaChance;
                    Console.WriteLine();
                    Console.WriteLine(_mensagemAcerto);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(_mensagemErroFatal);
                }
            }
            else
            {
                pontuacao = primeiraChance;
                Console.WriteLine();
                Console.WriteLine(_mensagemAcerto);
            }

            return pontuacao;
        }

        private static void VerificaPontuacao(int pontuacaoTotal)
        {
            if (pontuacaoTotal == 50)
            {
                Console.WriteLine("EXCELENTE! VOCÊ ATINGIU 50 PONTOS!");
                Console.WriteLine();
                Console.WriteLine("Ora, ora... Parece que temos um xeroque rolmes aqui! kkkkk Acertou todas as perguntas logo na primeira tentativa!");
            }
            if (35 <= pontuacaoTotal && pontuacaoTotal <= 49)
            {
                Console.WriteLine($"ÓTIMO! VOCÊ ATINGIU {pontuacaoTotal} PONTOS!");
                Console.WriteLine();
                Console.WriteLine("Parabéns, você se saiu muito bem! Keep Going!");
            }
            if (20 <= pontuacaoTotal && pontuacaoTotal <= 34)
            {
                Console.WriteLine($"BOM! VOCÊ ATINGIU {pontuacaoTotal} PONTOS!");
                Console.WriteLine();
                Console.WriteLine("Convenhamos que podemos melhorar por aqui, né?");
            }
            if (5 <= pontuacaoTotal && pontuacaoTotal <= 19)
            {
                Console.WriteLine($"REGULAR! VOCÊ ATINGIU {pontuacaoTotal} PONTOS!");
                Console.WriteLine();
                Console.WriteLine("Estude mais e volte para conseguir uma pontuação melhor.");
            }
            if (pontuacaoTotal < 5)
            {
                Console.WriteLine($"PÉSSIMO! VOCÊ ATINGIU {pontuacaoTotal} PONTOS!");
                Console.WriteLine();
                Console.WriteLine("Que resultado horrível! Decepcionante.");
            }
        }
    }
}
