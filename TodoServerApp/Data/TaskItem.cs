using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
		public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        [AllowNull]
        public DateTime? FinishDate { get; set; }
		public int? idPerformer { get; set; }
		[ForeignKey(nameof(idPerformer))]
		public PerformerItem PerformerItem { get; set; }

    }
}
