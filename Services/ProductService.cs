
using ESun.Data;
using ESun.Models;
using Microsoft.EntityFrameworkCore;

namespace ESun.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<LikeList>> GetUserLikes(string userId)
        {
            return await _context.LikeLists
                .Include(l => l.Product)
                .Include(l => l.User)
                .Where(l => l.UserID == userId)
                .ToListAsync();
        }

        public async Task<LikeList?> GetLikeById(int id)
        {
            return await _context.LikeLists
                .Include(l => l.Product)
                .Include(l => l.User)
                .FirstOrDefaultAsync(l => l.SN == id);
        }

        public async Task AddLikeAsync(LikeList like)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                _context.LikeLists.Add(like);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task UpdateLikeAsync(LikeList like)
        {
            _context.LikeLists.Update(like);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLikeAsync(int id)
        {
            var like = await _context.LikeLists.FindAsync(id);
            if (like != null)
            {
                _context.LikeLists.Remove(like);
                await _context.SaveChangesAsync();
            }
        }
    }
}
