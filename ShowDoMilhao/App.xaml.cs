using ShowDoMilhao.Models;

namespace ShowDoMilhao
{
    public partial class App : Application
    {
        static List<Pergunta> perguntas_faceis = new()
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
        static List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 21,
                Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MILANENSE" },
                    new Alternativa {Correta = false, Descricao = "MILANOSO" },
                    new Alternativa {Correta = false, Descricao = "MILISTA" },
                    new Alternativa {Correta = false, Descricao = "MILANÊS" }
                }
            },

            new Pergunta
            {
                Id = 22,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CARPINTEIRO" },
                    new Alternativa {Correta = false, Descricao = "RELOJOEIRO" },
                    new Alternativa {Correta = false, Descricao = "CONFEITEIRO" },
                    new Alternativa {Correta = false, Descricao = "BOMBEIRO" }
                }
            },

            new Pergunta
            {
                Id = 23,
                Enunciado = "O que é um oboé?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VUCÃO" },
                    new Alternativa {Correta = false, Descricao = "COMIDA" },
                    new Alternativa {Correta = false, Descricao = "INSTRUMENTO MUSICAL" },
                    new Alternativa {Correta = false, Descricao = "TRIBO INDÍGENA" }
                }
            },

            new Pergunta
            {
                Id = 24,
                Enunciado = "O que é gôndola?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "EMBARCAÇÃO" },
                    new Alternativa {Correta = false, Descricao = "BRINQUEDO" },
                    new Alternativa {Correta = false, Descricao = "MÚSICA" },
                    new Alternativa {Correta = false, Descricao = "SÍMBOLO" }
                }
            },

            new Pergunta
            {
                Id = 25,
                Enunciado = "Sashimi é um prato originário de qual país?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "JAPÃO" },
                    new Alternativa {Correta = false, Descricao = "CHINA" },
                    new Alternativa {Correta = false, Descricao = "ÍNDIA" },
                    new Alternativa {Correta = false, Descricao = "INDONÉSIA" }
                }
            },

            new Pergunta
            {
                Id = 26,
                Enunciado = "Peroba é uma espécie de?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "INSETO" },
                    new Alternativa {Correta = false, Descricao = "ÁRVORE" },
                    new Alternativa {Correta = false, Descricao = "VERME" },
                    new Alternativa {Correta = false, Descricao = "VERDURA" }
                }
            },

            new Pergunta
            {
                Id = 27,
                Enunciado = "O alpinismo é praticado em que lugar?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MAR" },
                    new Alternativa {Correta = false, Descricao = "MONTANHA" },
                    new Alternativa {Correta = false, Descricao = "RIO" },
                    new Alternativa {Correta = false, Descricao = "PRAIA" }
                }
            },

            new Pergunta
            {
                Id = 28,
                Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "PARIS" },
                    new Alternativa {Correta = false, Descricao = "COPENHAGUE" },
                    new Alternativa {Correta = false, Descricao = "ROMA" },
                    new Alternativa {Correta = false, Descricao = "LONDRES" }
                }
            },

            new Pergunta
            {
                Id = 29,
                Enunciado = "Qual é o ponto mais alto da Terra?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "EVEREST" },
                    new Alternativa {Correta = false, Descricao = "MONTE SINAI" },
                    new Alternativa {Correta = false, Descricao = "MONTE CASTELO" },
                    new Alternativa {Correta = false, Descricao = "MONT BLANC" }
                }
            },

            new Pergunta
            {
                Id = 30,
                Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "TÂMISA" },
                    new Alternativa {Correta = false, Descricao = "SENA" },
                    new Alternativa {Correta = false, Descricao = "RENO" },
                    new Alternativa {Correta = false, Descricao = "AUBE" }
                }
            },

            new Pergunta
            {
                Id = 31,
                Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "TÂMISA" },
                    new Alternativa {Correta = false, Descricao = "SENA" },
                    new Alternativa {Correta = false, Descricao = "RENO" },
                    new Alternativa {Correta = false, Descricao = "AUBE" }
                }
            },

            new Pergunta
            {
                Id = 32,
                Enunciado = "Qual é a raça do personagem principal do filme “Beethoven”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "FILA" },
                    new Alternativa {Correta = false, Descricao = "PASTOR ALEMÃO" },
                    new Alternativa {Correta = false, Descricao = "POODLE" },
                    new Alternativa {Correta = false, Descricao = "SÃO-BERNARDO" }
                }
            },

            new Pergunta
            {
                Id = 33,
                Enunciado = "Qual cantor ficou conhecido como “O rei da voz”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ORLANDO SILVA" },
                    new Alternativa {Correta = false, Descricao = "VICENTE CELESTINO" },
                    new Alternativa {Correta = false, Descricao = "FRANCISCO ALVES" },
                    new Alternativa {Correta = false, Descricao = "CARLOS GALHARDO" }
                }
            },

            new Pergunta
            {
                Id = 34,
                Enunciado = "Qual é a sigla da Organização das Nações Unidas?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ONU" },
                    new Alternativa {Correta = false, Descricao = "FMI" },
                    new Alternativa {Correta = false, Descricao = "CIA" },
                    new Alternativa {Correta = false, Descricao = "OTAN" }
                }
            },

            new Pergunta
            {
                Id = 35,
                Enunciado = "Segundo a crença popular, a mula-sem-cabeça é mulher de quem?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "COROINHA" },
                    new Alternativa {Correta = false, Descricao = "PADRE" },
                    new Alternativa {Correta = false, Descricao = "SACRISTÃO" },
                    new Alternativa {Correta = false, Descricao = "BISPO" }
                }
            },

            new Pergunta
            {
                Id = 36,
                Enunciado = "Que atriz protagonizou o filme “Titanic”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CAMERON DIAZ" },
                    new Alternativa {Correta = false, Descricao = "KATE WINSLET" },
                    new Alternativa {Correta = false, Descricao = "BRIDGET FONDA" },
                    new Alternativa {Correta = false, Descricao = "CATHERINE ZETTA JONES" }
                }
            },

            new Pergunta
            {
                Id = 37,
                Enunciado = "No filme, quem era parceiro de crimes da Bonnie?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "BILL" },
                    new Alternativa {Correta = false, Descricao = "CLYDE" },
                    new Alternativa {Correta = false, Descricao = "JAMES" },
                    new Alternativa {Correta = false, Descricao = "BUTCH" }
                }
            },

            new Pergunta
            {
                Id = 38,
                Enunciado = "Qual é a moeda oficial da Alemanha?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "LIRA" },
                    new Alternativa {Correta = false, Descricao = "MARCO" },
                    new Alternativa {Correta = false, Descricao = "FRANCO" },
                    new Alternativa {Correta = false, Descricao = "LIBRA" }
                }
            },

            new Pergunta
            {
                Id = 39,
                Enunciado = "Nas histórias do Snoopy, qual é o nome do passarinho?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "PIU-PIU" },
                    new Alternativa {Correta = false, Descricao = "WOODSTOCK" },
                    new Alternativa {Correta = false, Descricao = "CANARINHO" },
                    new Alternativa {Correta = false, Descricao = "ROUXINOL" }
                }
            },

            new Pergunta
            {
                Id = 40,
                Enunciado = "Que país europeu tem como atração a tourada?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ESPANHA" },
                    new Alternativa {Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa {Correta = false, Descricao = "FRANÇA" },
                    new Alternativa {Correta = false, Descricao = "ALEMANHA" }
                }
            }
            };
        static List<Pergunta> perguntas_dificeis = new()
    {
            new Pergunta
{
    Id = 41,
    Enunciado = "Qual é o nome do maior oceano do planeta?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "OCEANO ATLÂNTICO" },
        new Alternativa {Correta = false, Descricao = "OCEANO ÁRTICO" },
        new Alternativa {Correta = false, Descricao = "OCEANO ANTÁRTICO" },
        new Alternativa {Correta = true, Descricao = "OCEANO PACÍFICO" }
    }
},

            new Pergunta
{
    Id = 42,
    Enunciado = "Qual é a capital do Japão?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "PEQUIM" },
        new Alternativa {Correta = false, Descricao = "SEOUL" },
        new Alternativa {Correta = false, Descricao = "TAIPEI" },
        new Alternativa {Correta = true, Descricao = "TÓQUIO" }
    }
},

            new Pergunta
{
    Id = 43,
    Enunciado = "Quem escreveu a peça 'Hamlet'?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "GEORGE BERNARD SHAW" },
        new Alternativa {Correta = false, Descricao = "HENRIK IBSEN" },
        new Alternativa {Correta = false, Descricao = "Tennessee WILLIAMS" },
        new Alternativa {Correta = true, Descricao = "WILLIAM SHAKESPEARE" }
    }
},

            new Pergunta
{
    Id = 44,
    Enunciado = "Qual é o menor país do mundo em termos de área?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "MÔNACO" },
        new Alternativa {Correta = false, Descricao = "SAN MARINO" },
        new Alternativa {Correta = false, Descricao = "LIECHTENSTEIN" },
        new Alternativa {Correta = true, Descricao = "VATICANO" }
    }
},

            new Pergunta
{
    Id = 45,
    Enunciado = "Qual é a fórmula química da água?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "H2O2" },
        new Alternativa {Correta = false, Descricao = "CO2" },
        new Alternativa {Correta = false, Descricao = "CH4" },
        new Alternativa {Correta = true, Descricao = "H2O" }
    }
},

            new Pergunta
{
    Id = 46,
    Enunciado = "Qual é o principal ingrediente da paella?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "CARNES" },
        new Alternativa {Correta = false, Descricao = "PESCADOS" },
        new Alternativa {Correta = false, Descricao = "FEIJÃO" },
        new Alternativa {Correta = true, Descricao = "ARROZ" }
    }
},

            new Pergunta
{
    Id = 47,
    Enunciado = "Quem foi o primeiro homem a pisar na Lua?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "BUZZ ALDRIN" },
        new Alternativa {Correta = false, Descricao = "MICHAEL COLLINS" },
        new Alternativa {Correta = false, Descricao = "JOHN GLENN" },
        new Alternativa {Correta = true, Descricao = "NEIL ARMSTRONG" }
    }
},

            new Pergunta
{
    Id = 48,
    Enunciado = "Qual é a moeda oficial dos Estados Unidos?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "EURO" },
        new Alternativa {Correta = false, Descricao = "LIBRA" },
        new Alternativa {Correta = false, Descricao = "YEN" },
        new Alternativa {Correta = true, Descricao = "DÓLAR" }
    }
},

            new Pergunta
{
    Id = 49,
    Enunciado = "Qual é a capital da França?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "LONDRES" },
        new Alternativa {Correta = false, Descricao = "BERLIM" },
        new Alternativa {Correta = false, Descricao = "MADRI" },
        new Alternativa {Correta = true, Descricao = "PARIS" }
    }
},

            new Pergunta
{
    Id = 50,
    Enunciado = "Qual é o nome do famoso relógio de Londres?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "BIG BEN" },
        new Alternativa {Correta = false, Descricao = "TIMES TOWER" },
        new Alternativa {Correta = false, Descricao = "LONDON CLOCK" },
        new Alternativa {Correta = true, Descricao = "ELISABETH TOWER" }
    }
},

            new Pergunta
{
    Id = 51,
    Enunciado = "Qual é o nome da primeira missão espacial a pousar na superfície de Marte?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "APOLLO 11" },
        new Alternativa {Correta = false, Descricao = "VOYAGER 1" },
        new Alternativa {Correta = false, Descricao = "SPIRIT" },
        new Alternativa {Correta = true, Descricao = "CURIOSITY" }
    }
},

            new Pergunta
{
    Id = 52,
    Enunciado = "Qual é o principal gás responsável pelo efeito estufa?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "OZÔNIO" },
        new Alternativa {Correta = false, Descricao = "HIDROGÊNIO" },
        new Alternativa {Correta = false, Descricao = "NITROGÊNIO" },
        new Alternativa {Correta = true, Descricao = "DÍÓXIDO DE CARBONO" }
    }
},

            new Pergunta
{
    Id = 53,
    Enunciado = "Qual é a peça de vestuário tradicional escocês?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "CAMISA" },
        new Alternativa {Correta = false, Descricao = "CALÇA" },
        new Alternativa {Correta = false, Descricao = "SUÉTER" },
        new Alternativa {Correta = true, Descricao = "KILT" }
    }
},

            new Pergunta
{
    Id = 54,
    Enunciado = "Qual é o animal símbolo da Austrália?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "LEÃO" },
        new Alternativa {Correta = false, Descricao = "ELEFANTE" },
        new Alternativa {Correta = false, Descricao = "TIGRE" },
        new Alternativa {Correta = true, Descricao = "CANGURU" }
    }
},

            new Pergunta
{
    Id = 55,
    Enunciado = "Qual é a maior cidade do Brasil em termos de população?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO" },
        new Alternativa {Correta = false, Descricao = "BELO HORIZONTE" },
        new Alternativa {Correta = false, Descricao = "SALVADOR" },
        new Alternativa {Correta = true, Descricao = "SÃO PAULO" }
    }
},

            new Pergunta
{
    Id = 56,
    Enunciado = "Quem é o autor da obra 'Dom Casmurro'?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "JOSÉ DE ALENCAR" },
        new Alternativa {Correta = false, Descricao = "MACHADO DE ASSIS" },
        new Alternativa {Correta = false, Descricao = "ALUIZIO AZEVEDO" },
        new Alternativa {Correta = true, Descricao = "MACHADO DE ASSIS" }
    }
},

            new Pergunta
{
    Id = 56,
    Enunciado = "Quem é o autor da obra 'Dom Casmurro'?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "JOSÉ DE ALENCAR" },
        new Alternativa {Correta = false, Descricao = "MACHADO DE ASSIS" },
        new Alternativa {Correta = false, Descricao = "ALUIZIO AZEVEDO" },
        new Alternativa {Correta = true, Descricao = "MACHADO DE ASSIS" }
    }
},

            new Pergunta
{
    Id = 57,
    Enunciado = "Qual é a capital da Alemanha?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "VIENA" },
        new Alternativa {Correta = false, Descricao = "AMSTERDÃ" },
        new Alternativa {Correta = false, Descricao = "BRUXELAS" },
        new Alternativa {Correta = true, Descricao = "BERLIM" }
    }
},

            new Pergunta
{
    Id = 58,
    Enunciado = "Quem disse a frase: “Vim, vi e venci”?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "JÚLIO CÉSAR" },
        new Alternativa {Correta = false, Descricao = "CALÍGULA" },
        new Alternativa {Correta = false, Descricao = "NERA" },
        new Alternativa {Correta = true, Descricao = "MARCO ANTÔNIO" }
        }
    },

            new Pergunta
{
    Id = 59,
    Enunciado = "Qual é a capital da Alemanha?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "VIENA" },
        new Alternativa {Correta = false, Descricao = "AMSTERDÃ" },
        new Alternativa {Correta = false, Descricao = "BRUXELAS" },
        new Alternativa {Correta = true, Descricao = "BERLIM" }
    }
},



            new Pergunta
{
    Id = 60,
    Enunciado = "Quais são os naipes vermelhos do baralho?",
    Alternativas = new()
    {
        new Alternativa {Correta = false, Descricao = "OUROS E COPAS" },
        new Alternativa {Correta = false, Descricao = "COPAS E PAUS" },
        new Alternativa {Correta = false, Descricao = "PAUS E OUROS" },
        new Alternativa {Correta = true, Descricao = "ESPADAS E PAUS" }
        }
    }
    };
        static List<Pergunta> perguntas_finais = new()
        {
            new Pergunta
            {
            Id = 61,
            Enunciado = "Qual é o nome verdadeiro do Batman?",
            Alternativas = new()
            {
                new Alternativa {Correta = false, Descricao = "BRUCE WAYNE" },
                new Alternativa {Correta = false, Descricao = "DEXTER" },
                new Alternativa {Correta = false, Descricao = "CLARK KENT" },
                new Alternativa {Correta = true, Descricao = "LEX LUTOR" }
        }
    },
            new Pergunta
            {
            Id = 62,
            Enunciado = "Qual é o nome da embarcação típica do litoral nordestino brasileiro?",
            Alternativas = new()
            {
                new Alternativa {Correta = false, Descricao = "SUBMARINO" },
                new Alternativa {Correta = false, Descricao = "JET SKI" },
                new Alternativa {Correta = false, Descricao = "JANGADA" },
                new Alternativa {Correta = true, Descricao = "LANCHA" }
        }
    },
            new Pergunta
            {
            Id = 63,
            Enunciado = "Em que estado norte-americano fica a cidade de Miami?",
            Alternativas = new()
            {
                new Alternativa {Correta = false, Descricao = "ALASCA" },
                new Alternativa {Correta = false, Descricao = "NOVA YORK" },
                new Alternativa {Correta = false, Descricao = "FLÓRIDA" },
                new Alternativa {Correta = true, Descricao = "CALIFÓRNIA" }
        }
    },
            new Pergunta
            {
            Id = 64,
            Enunciado = "Qual é a capital do Iraque?",
            Alternativas = new()
            {
                new Alternativa {Correta = false, Descricao = "BELÉM" },
                new Alternativa {Correta = false, Descricao = "BAGDÁ" },
                new Alternativa {Correta = false, Descricao = "BEIRUTE" },
                new Alternativa {Correta = true, Descricao = "BUDAPESTE" }
        }
    },
            new Pergunta
            {
            Id = 65,
            Enunciado = "Qual é o nome do cachorro de Charlie Brown?",
            Alternativas = new()
            {
                new Alternativa {Correta = false, Descricao = "PLUTO" },
                new Alternativa {Correta = false, Descricao = "FLOQUINHO" },
                new Alternativa {Correta = false, Descricao = "BALEIA" },
                new Alternativa {Correta = true, Descricao = "SNOOPY" }
        }
    }
};

        public static Pergunta getRandomPerguntaFacil()
        {
            Random r = new Random();

            int Sorteado = r.Next(1, perguntas_faceis.Count);

            return perguntas_faceis[Sorteado];
        }

        public static Pergunta getRandomPerguntaMedia()
        {
            Random r = new Random();

            int Sorteado = r.Next(1, perguntas_medias.Count);

            return perguntas_medias[Sorteado];
        }

        public static Pergunta getRandomPerguntaDificil()
        {
            Random r = new Random();

            int Sorteado = r.Next(1, perguntas_dificeis.Count);

            return perguntas_dificeis[Sorteado];

        static Pergunta getRandomPerguntaFinal()
        {
                Random r = new Random();

                int Sorteado = r.Next(1, perguntas_finais.Count);

                return perguntas_finais[Sorteado];
            }
        }


        public App()
        {

            MainPage = new AppShell();
        }
    }
}
