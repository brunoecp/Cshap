using DBConnection.Models;

namespace DBConnection.Persistence.Repository
{
    public interface IAlunoRepository
    {

        Alunos GetById(int id);
        IEnumerable<Alunos> GetAll();
        void add(Alunos entity);
        void remove(Alunos entity);
        void update(Alunos entity);
    }
}
