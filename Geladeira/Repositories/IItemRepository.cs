using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geladeira.Models;

namespace Geladeira.Repositories
{
    public interface IItemRepository
    {
       Task<IEnumerable<Item>> GetAllAsync();
        Task<Item> GetByIdAsync(int id);
        Task AddAsync(Item item);
        Task UpdateAsync(Item item);
        Task DeleteAsync(int id);
    }
}