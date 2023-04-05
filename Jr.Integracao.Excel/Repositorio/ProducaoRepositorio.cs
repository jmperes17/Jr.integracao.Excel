using Jr.Integracao.Excel.Model.Base;
using Jr.Integracao.Excel.Model.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Jr.Integracao.Excel.Repositorio
{
    public class ProducaoRepositorio
    {
        private readonly Context _context;

        public ProducaoRepositorio(Context context)
        {
            _context = context;

        }
        public async  Task<Producao> Atualizar(Producao dto)
        {
            _context.Producoes.Update(dto);
            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<Producao> BuscarPorId(long id)
        {
            Producao producao = await _context.Producoes.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Producao();
            return producao;
        }

        public async Task<IEnumerable<Producao>> BuscarTodos()
        {
            List<Producao> products = await _context.Producoes.ToListAsync();
            return products;
        }

        public async Task<Producao> Criar(Producao dto)
        {
            _context.Producoes.Add(dto);
            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<bool> Deletar(long id)
        {
            try
            {
                Producao producao = await _context.Producoes.Where(p => p.Id == id).FirstOrDefaultAsync() ?? new Producao();
                if (producao.Id <= 0) return false;
                _context.Producoes.Remove(producao);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
