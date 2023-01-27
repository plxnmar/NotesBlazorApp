using NotesBlazorApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesBlazorApp.Shared.ViewModels
{
	public class NoteViewModel
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Details { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ChangedDate { get; set; }
		public int? ColorCardId { get; set; }
		public ColorViewModel? ColorCard { get; set; }
	}
}
