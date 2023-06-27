using Microsoft.EntityFrameworkCore;

namespace aula20_as
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MeuContexto _context;

        public UsuarioRepository(MeuContexto context)
        {
            _context = context;
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios
                .Include(u => u.Emprestimos)
                .ThenInclude(e => e.Livro)
                .ToList();
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios
                .Include(u => u.Emprestimos)
                .ThenInclude(e => e.Livro)
                .FirstOrDefault(u => u.Id == id);
        }

        public void Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
