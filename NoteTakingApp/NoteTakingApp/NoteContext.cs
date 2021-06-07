using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    public class NoteContext : DbContext
    {

        public NoteContext() : base("NoteDatabae")
        {

        }

        public DbSet<Note> Note { get; set; }
    }
}
