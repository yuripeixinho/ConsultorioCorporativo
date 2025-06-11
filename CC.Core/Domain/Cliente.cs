namespace CC.Core.Domain;

public class Cliente
{
    public int ClienteId { get; set; }
    public required string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public char Sexo { get; set; }
    public string? Telefone { get; set; }
    public string? Documento { get; set; }
}
