using TodoServerApp.Components.Pages;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
	public class MemoryDataService : IDataService
	{
		private static IEnumerable<TaskItem> Tasks { get; set; } = [
			new() { Id = 1, Title = "Задача 1", Description = "Описание задача 1", CreatedDate =  DateTime.Now},
			new() { Id = 2, Title = "Задача 2", Description = "Описание задача 2", CreatedDate =  DateTime.Now},
			new() { Id = 3, Title = "Задача 3", Description = "Описание задача 3", CreatedDate =  DateTime.Now},
			new() { Id = 4, Title = "Задача 4", Description = "Описание задача 4", CreatedDate =  DateTime.Now},
		];

		private static IEnumerable<PerformerItem> Performeres { get; set; } = [
			new() { Id = 1, Surname = "Корнилов", Name = "Кирилл", Pantronymic =  "Андреевич"},
			new() { Id = 2, Surname = "Яковлев", Name = "Лев", Pantronymic =  "Данилович"},
			new() { Id = 3, Surname = "Калугин", Name = "Игорь", Pantronymic =  "Степанович"},
			new() { Id = 4, Surname = "Иванов", Name = "Давид", Pantronymic =  "Львович"},
		];

		public Task DeleteTaskAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<TaskItem> GetTaskAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<TaskItem>> GetAllTasksAsync()
		{
			await Task.Delay(1000);
			return await Task.FromResult(Tasks);
		}

		public Task SaveTaskAsync(TaskItem item)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<PerformerItem>> GetAllPerformerAsync()
		{
			await Task.Delay(1000);
			return await Task.FromResult(Performeres);
		}

		public Task SavePerformerAsync(PerformerItem item)
		{
			throw new NotImplementedException();
		}

		public Task<PerformerItem> GetPerformerAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task DeletePerformerAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}