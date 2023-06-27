namespace aula20_as
{
    public interface IAutorService
    {
        List<Autor> GetAllAutores();
        Autor GetAutorById(int id);
        void CreateAutor(Autor autor);
        void UpdateAutor(Autor autor);
        void DeleteAutor(int id);
    }
}
