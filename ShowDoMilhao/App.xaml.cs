using ShowDoMilhao.Models;

namespace ShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é nome ao estado dá água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa {Correta = false, Descricao = "GASOSO" },
                    new Alternativa {Correta = false, Descricao = "SÓLIDO" },
                    new Alternativa {Correta = false, Descricao = "VAPOROSO" },
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARGARIDA" },
                    new Alternativa {Correta = false, Descricao = "MINNIE" },
                    new Alternativa {Correta = false, Descricao = "A PEQUENA SEREIA"},
                    new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO" },
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUCA" },
                    new Alternativa {Correta = false, Descricao = "NEGRINHO DO PASTOREIO" },
                    new Alternativa {Correta = false, Descricao = "BOITATÁ" },
                    new Alternativa {Correta = false, Descricao = "SACI-PERERÊ" }
                }
            },
            new Pergunta
                            {
                Id = 4,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MONSTRO" },
                    new Alternativa {Correta = false, Descricao = "GORILA" },
                    new Alternativa {Correta = false, Descricao = "PRINCÍPE" },
                    new Alternativa {Correta = false, Descricao = "SAPO" },
                }
            },
            new Pergunta
                            {
                Id = 5,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ROMEU" },
                    new Alternativa {Correta = false, Descricao = "ORFEU" },
                    new Alternativa {Correta = false, Descricao = "HAMLET" },
                    new Alternativa {Correta = false, Descricao = "IAGO" },
                }
            },
            new Pergunta
                            {
                Id = 6,
                Enunciado = "Como se chama o lugar onde são armazenadas as balas de um revólver?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CANO" },
                    new Alternativa {Correta = false, Descricao = "TAMBOR" },
                    new Alternativa {Correta = false, Descricao = "AGULHA" },
                    new Alternativa {Correta = false, Descricao = "GATILHO" },
                }
            },
            new Pergunta
                            {
                Id = 7,
                Enunciado = "Qual personagem da turma da Mônica tem apenas cinco fios de cabelo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MÔNICA" },
                    new Alternativa {Correta = false, Descricao = "CEBOLINHA" },
                    new Alternativa {Correta = false, Descricao = "CASCÃO" },
                    new Alternativa {Correta = false, Descricao = "MAGALI" },
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "O churrasco é considerado umacomida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CEARÁ" },
                    new Alternativa {Correta = false, Descricao = "RIO GRANDE SO SUL" },
                    new Alternativa {Correta = false, Descricao = "PARÁ" },
                    new Alternativa {Correta = false, Descricao = "MARANHÃO" },
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem foi o criador dos personagens Pedrinho, Narizinho e Emília?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MAURÍCIO DE SOUSA" },
                    new Alternativa {Correta = false, Descricao = "ZIRALDO" },
                    new Alternativa {Correta = false, Descricao = "MONTEIRO LO" },
                    new Alternativa {Correta = false, Descricao = "SACI-PERERÊ" },
                }
            },
            new Pergunta
                            {
                Id = 10,
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "SUTÃO DE BRUNEI" },
                    new Alternativa {Correta = false, Descricao = "AKIO MORITA" },
                    new Alternativa {Correta = false, Descricao = "BILL GATES" },
                    new Alternativa {Correta = false, Descricao = "PRÍNCIPE CHARLES" },
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o nome dado ao pneu reserva do carro?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CALOTA" },
                    new Alternativa {Correta = false, Descricao = "ESTEPE" },
                    new Alternativa {Correta = false, Descricao = "MACACO" },
                    new Alternativa {Correta = false, Descricao = "CHAVE DE RODA" }
                }
            },
            new Pergunta
                        {
            Id = 12,
            Enunciado = "Qual é o nome do cachorro medroso do Salsicha, dos desenhos animados?",
            Alternativas = new()
            {
                new Alternativa {Correta = false, Descricao = "FLOQUINHIO" },
                new Alternativa {Correta = false, Descricao = "RIN-TIN-TIN" },
                new Alternativa {Correta = false, Descricao = "LASSIE" },
                new Alternativa {Correta = false, Descricao = "SCOOBY-DOO" },
            }
        },
            new Pergunta
                            {
                Id = 13,
                Enunciado = "Qual é a pedra preciosa mais dura encontrada na natureza?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ESMERALDA" },
                    new Alternativa {Correta = false, Descricao = "RUBI" },
                    new Alternativa {Correta = false, Descricao = "PÉROLA" },
                    new Alternativa {Correta = false, Descricao = "DIAMANTE" }
                }
                },
            new Pergunta
                            {
                Id = 14,
                Enunciado = "Como se chama o lugar onde se guardam vinhos?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ADEGA" },
                    new Alternativa {Correta = false, Descricao = "BIBLIOTECA" },
                    new Alternativa {Correta = false, Descricao = "SÓTÃO" },
                    new Alternativa {Correta = false, Descricao = "SALA" },
            }
                },
            new Pergunta
                            {
                Id = 15,
                Enunciado = "Qual cantor ficou conhecido como “o rei do rock”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "FRANK SINATRA" },
                    new Alternativa {Correta = false, Descricao = "LITTLE RICHARD" },
                    new Alternativa {Correta = false, Descricao = "ELVIS PRESLEY" },
                    new Alternativa {Correta = false, Descricao = "RICHIE VALENS" },
            }
                },
            new Pergunta
                            {
                Id = 16,
                Enunciado = "Quem é o inimigo do Piu-Piu nos desenhos animados?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "FÉLIX" },
                    new Alternativa {Correta = false, Descricao = "TOM" },
                    new Alternativa {Correta = false, Descricao = "FRAJOLA" },
                    new Alternativa {Correta = false, Descricao = "MINGAU" },
            }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Quantos dias tem um ano bissexto?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "364" },
                    new Alternativa {Correta = false, Descricao = "365" },
                    new Alternativa {Correta = false, Descricao = "366" },
                    new Alternativa {Correta = false, Descricao = "367" },
            }
            },
            new Pergunta
                            {
                Id = 18,
                Enunciado = "Qual é o réptil que muda de cor conforme o lugar em que está?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "SAPO" },
                    new Alternativa {Correta = false, Descricao = "CAMALEÃO" },
                    new Alternativa {Correta = false, Descricao = "LAGARTO" },
                    new Alternativa {Correta = false, Descricao = "JACARÉ" },
            }
            },
            new Pergunta
                            {
                Id = 19,
                Enunciado = "Qual é a duração de cada tempo de uma partida de futebol?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "45 MINUTOS" },
                    new Alternativa {Correta = false, Descricao = "90 MINUTOS" },
                    new Alternativa {Correta = false, Descricao = "120 MINUTOS" },
                    new Alternativa {Correta = false, Descricao = "150 MINUTOS" },
            }
            },
            new Pergunta
                            {
                Id = 20,
                Enunciado = "Onde fica o centro da indústria cinematográfica nos EUA?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "NOVA YORK" },
                    new Alternativa {Correta = false, Descricao = "LAS VEGAS" },
                    new Alternativa {Correta = false, Descricao = "NEW ORLEANS" },
                    new Alternativa {Correta = false, Descricao = "HOLLYWOOD" }
                }
            }
        };


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
