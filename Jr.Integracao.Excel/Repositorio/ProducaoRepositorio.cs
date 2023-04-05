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

        public async Task<Producao> Insert(Producao dto)
        {
            _context.Producoes.Add(dto);
            await _context.SaveChangesAsync();
            return dto;
        }

       
    }
}
