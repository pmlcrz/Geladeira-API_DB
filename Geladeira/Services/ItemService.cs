using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geladeira.Models;
using Geladeira.Repositories;

namespace Geladeira.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        
        public async Task<IEnumerable<Item>> GetAllItemsAsync()
        {
            return await _itemRepository.GetAllAsync();
        }
        
        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await _itemRepository.GetByIdAsync(id);
        }
        
        public async Task AddItemAsync(Item item)
        {
            await _itemRepository.AddAsync(item);
        }
        
        public async Task UpdateItemAsync(Item item)
        {
            await _itemRepository.UpdateAsync(item);
        }
        
        public async Task DeleteItemAsync(int id)
        {
            await _itemRepository.DeleteAsync(id);
        }
    }
}
