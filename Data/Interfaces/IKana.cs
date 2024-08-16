using KanaTrainer.Data.Models;

namespace KanaTrainer.Data.Interfaces
{
    public interface IKana
    {
        public Task<Kana> GetByIdAsync(Guid id);
        public Task<List<Kana>> GetAllAsync();
        public Task<List<Kana>> GetAllOfType(string type);
        public Task AddAsync(Kana kana);
        public Task EditAsync(Kana kana);
        public Task DeleteAsync(int id);
    }
}
