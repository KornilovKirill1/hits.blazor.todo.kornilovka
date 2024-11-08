using TodoServerApp.Components.Pages;

namespace TodoServerApp.Data.Interfaces
{
	public interface IDataService
	{
		Task<IEnumerable<TaskItem>> GetAllTasksAsync();
		Task SaveTaskAsync(TaskItem item);
		Task<TaskItem> GetTaskAsync(int id);
		Task DeleteTaskAsync(int id);
		Task<IEnumerable<PerformerItem>> GetAllPerformerAsync();
		Task SavePerformerAsync(PerformerItem item);
		Task<PerformerItem> GetPerformerAsync(int id);
		Task DeletePerformerAsync(int id);
	}
}
