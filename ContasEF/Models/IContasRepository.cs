namespace ContasEF.Models
{
    public interface IContasRepository : IRepository<ContaLuz>
    {
        ContaLuz GetMenor();
        ContaLuz GetMaior();
    }
}