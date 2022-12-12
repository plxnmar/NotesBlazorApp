using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesBlazorApp.Shared
{
    public class ColorCard
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Note> Notes { get; set; }

        public ColorCard()
        {
            Notes = new List<Note>();
        }
    }
}
