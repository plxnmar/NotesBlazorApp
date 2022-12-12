using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesBlazorApp.Shared
{
    public class Note
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string? Title { get; set; }
        public string? Details { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ChangedDate { get; set; }
        public int? ColorCardId { get; set; }
        public ColorCard? ColorCard { get; set; }
    }
}
