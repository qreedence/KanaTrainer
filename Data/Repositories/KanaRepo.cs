using KanaTrainer.Data.Interfaces;
using KanaTrainer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KanaTrainer.Data.Repositories
{
    public class KanaRepo : IKana
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public KanaRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task AddAsync(Kana kana)
        {
            await _applicationDbContext.Kanas.AddAsync(kana);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var kana = await _applicationDbContext.Kanas.FindAsync(id);
            if (kana != null)
            {
                _applicationDbContext.Kanas.Remove(kana);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task EditAsync(Kana kana)
        {
            if (kana != null)
            {
                _applicationDbContext.Kanas.Update(kana);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Kana>> GetAllAsync()
        {
            return await _applicationDbContext.Kanas.ToListAsync();
        }

        public async Task<List<Kana>> GetAllOfType(string type)
        {
            return await _applicationDbContext.Kanas.Where(x => x.KanaType == type).ToListAsync();
        }

        public async Task<Kana> GetByIdAsync(Guid id)
        {
            return await _applicationDbContext.Kanas.FirstOrDefaultAsync(k => k.Id == id);
        }
    }
}
