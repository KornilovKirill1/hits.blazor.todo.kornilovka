﻿using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> Tasks { get; } = [
            new() { Id = 1, Title = "Задача 1", Description = "Описание задача 1", CreatedDate =  DateTime.Now},
            new() { Id = 2, Title = "Задача 2", Description = "Описание задача 2", CreatedDate =  DateTime.Now},
            new() { Id = 3, Title = "Задача 3", Description = "Описание задача 3", CreatedDate =  DateTime.Now},
			new() { Id = 4, Title = "Задача 4", Description = "Описание задача 4", CreatedDate =  DateTime.Now},
		];

        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }
    }
}
