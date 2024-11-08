using Microsoft.EntityFrameworkCore;
using TodoServerApp.Components.Pages;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
	public class MSSQLDataService(ApplicationDbContext context) : IDataService
	{
		public async Task DeleteTaskAsync(int id)
		{
			var taskItem = await context.TaskItems.FirstAsync(x => x.Id == id);
			context.TaskItems.Remove(taskItem);
			await context.SaveChangesAsync();
		}

		public async Task<TaskItem> GetTaskAsync(int id)
		{
			return await context.TaskItems.FirstAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<TaskItem>> GetAllTasksAsync()
		{
			return await context.TaskItems.ToArrayAsync();
		}

		public async Task SaveTaskAsync(TaskItem taskItem)
		{
			if (taskItem.Id == 0)
			{
				taskItem.CreatedDate = DateTime.Now;
				await context.TaskItems.AddAsync(taskItem);
			}
			else
			{
				var existingTask = await context.TaskItems.FindAsync(taskItem.Id);
				if (existingTask != null)
				{
					// Обновление только определенных полей
					existingTask.Title = taskItem.Title;
					existingTask.Description = taskItem.Description;
					existingTask.FinishDate = taskItem.FinishDate;
					existingTask.idPerformer = taskItem.idPerformer ?? null;
				}
			}
			await context.SaveChangesAsync();
		}

		public async Task<IEnumerable<PerformerItem>> GetAllPerformerAsync()
		{
			return await context.PerformerItems.ToArrayAsync();
		}

		public async Task SavePerformerAsync(PerformerItem performerItem)
		{
			context.PerformerItems.Update(performerItem);
			await context.SaveChangesAsync();
		}

		public async Task<PerformerItem> GetPerformerAsync(int id)
		{
			return await context.PerformerItems.FirstAsync(x => x.Id == id);
		}

		public async Task DeletePerformerAsync(int id)
		{
			var performerItem = await context.PerformerItems.FirstAsync(x => x.Id == id);
			context.PerformerItems.Remove(performerItem);
			await context.SaveChangesAsync();
		}
	}
}
