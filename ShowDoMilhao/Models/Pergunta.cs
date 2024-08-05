namespace ShowDoMilhao.Models;

public class Pergunta
{

    public int Id { get; set; }
    public string? Enunciado { get; set; }
    public List<Alternativa> Alternativas { get; set; }

}