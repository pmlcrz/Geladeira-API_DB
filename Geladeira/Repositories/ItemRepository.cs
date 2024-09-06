using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geladeira.Data;
using Geladeira.Models;
using Microsoft.EntityFrameworkCore;

namespace Geladeira.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly GeladeiraContext _context;

        public ItemRepository(GeladeiraContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetAllAsync()
        {
            return await _context.Item.ToListAsync();
        }

        public async Task<Item> GetByIdAsync(int id)
        {
            var itemExistente = await _context.Item.FindAsync(id);
            if (itemExistente is null)
                return null;
            return itemExistente;
        }


        public async Task AddAsync(Item item)
        {
            await _context.Item.AddAsync(item);
            await _context.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(Item item)
        {
            _context.Item.Update(item);
            await _context.SaveChangesAsync();
        }
        
        public async Task DeleteAsync(int id)
        {
            var item = await _context.Item.FindAsync(id);
            if (item != null)
            {
                _context.Item.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
