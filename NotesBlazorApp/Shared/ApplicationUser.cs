﻿using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace NotesBlazorApp.Shared
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Note> Notes { get; set; }

        public ApplicationUser()
        {
            Notes = new List<Note>();
        }
    }
}