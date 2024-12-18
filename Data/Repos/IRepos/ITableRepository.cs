﻿using Labb1Restaurant.Models;

namespace Labb1Restaurant.Data.Repos.IRepos
{
    public interface ITableRepository
    {
        Task<IEnumerable<Table>> GetAllTablesAsync();
        Task<Table> GetTableByIdAsync(int tableId);
        Task<IEnumerable<Booking>> GetTableBookingConnectionByIdAsync(int tableId);

        Task<IEnumerable<Table>> GetAvailableTablesAsync(int guestAttending);

        Task AddTableAsync(Table table);

        Task UpdateTableAsync(Table table);

        Task DeleteTableAsync(Table table);
    }
}
