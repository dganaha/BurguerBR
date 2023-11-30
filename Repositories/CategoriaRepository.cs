using BurguerBR.Context;
using BurguerBR.Models;
using BurguerBR.Repositories.Interfaces;

namespace BurguerBR.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
