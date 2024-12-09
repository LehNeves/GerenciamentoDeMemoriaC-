namespace GerenciamentoDeMemoria;

internal record UsuarioDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }

    public virtual bool Equals(UsuarioDto dto)
    {
        if(this.Nome == dto.Nome && this.Email == dto.Email)
        {
            return true;
        }
        return false;
    }
}
