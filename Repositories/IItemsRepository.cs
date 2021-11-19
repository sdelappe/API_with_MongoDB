using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IItemsRepository
    {
        // the -Async suffix indicates that these are asynchronous methods
        // they return tasks<of items>, which tells the program that a task is running, and it doesn't need
        // to wait until the Item is returned to move on
        // Asynchronous programming is common when interacting with outside party services since they
        // can be demanding on resources and take time
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);
    }
}