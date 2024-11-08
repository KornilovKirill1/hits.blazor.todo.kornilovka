using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public virtual DbSet<TaskItem> TaskItems { get; set; }
		public virtual DbSet<PerformerItem> PerformerItems { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<PerformerItem>().HasData([
						new () { Id = 1, Surname = "Корнилов", Name = "Кирилл", Pantronymic =  "Андреевич"},
						new () { Id = 2, Surname = "Яковлев", Name = "Лев", Pantronymic =  "Данилович"},
						new() { Id = 3, Surname = "Калугин", Name = "Игорь", Pantronymic = "Степанович" },
						new() { Id = 4, Surname = "Иванов", Name = "Давид", Pantronymic = "Львович" },
					]);
			builder.Entity<TaskItem>().HasData([
					new() { Id = 1, Title = "Задача 1", Description = "Описание задача 1", CreatedDate =  DateTime.Now, idPerformer = 1},
					new() { Id = 2, Title = "Задача 2", Description = "Описание задача 2", CreatedDate =  DateTime.Now},
					new() { Id = 3, Title = "Задача 3", Description = "Описание задача 3", CreatedDate =  DateTime.Now, idPerformer = 3},
					new() { Id = 4, Title = "Задача 4", Description = "Описание задача 4", CreatedDate =  DateTime.Now},
				]);
		}
	}
}
