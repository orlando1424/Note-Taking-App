using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTakingApp : Form
    {

       
        public NoteTakingApp()
        {
            InitializeComponent();
        }

        

        private void NoteTakingApp_Load(object sender, EventArgs e)
        {
            

            using (var ctx = new NoteContext())
                dataGridView1.DataSource = ctx.Note.ToList();

            dataGridView1.Columns[0].Visible = false;
          
        }

        

        private void newMetroButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Clear();
            messageTextBox.Clear();
        }

        

        private void saveMetroButton_Click(object sender, EventArgs e)
        {
            // use new instance of context
            using (var ctx = new NoteContext())
            {
                // this part adds the note with the data from the title and message textbox
                var note = new Note() { Title = titleTextBox.Text, Message = messageTextBox.Text };

                // adds the note to the table in the database
                ctx.Note.Add(note);

                // make sure to save changes 
                ctx.SaveChanges();

                // update the datagrid view so that the new note is showing 
                dataGridView1.DataSource = ctx.Note.ToList();

            }
        }

        

        private void readMetroButton_Click(object sender, EventArgs e)
        {
            int index;
            //index = (dataGridView1.SelectedRows != null) ? dataGridView1.SelectedRows[0].Index : -1;
            //Equiv VVV

            // check to see if an index is actually selected
            if (dataGridView1.SelectedRows != null)
                index = dataGridView1.SelectedRows[0].Index;
            else
                index = -1;

            // if the index is greater than -1 than go ahead and read the values 
            if (index > -1)
            {
                titleTextBox.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                messageTextBox.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            }
        }

  

        private void deleteMetroButton_Click(object sender, EventArgs e)
        {
            // check for the selected row 
            int index = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            // new instance of the context 
            using (var ctx = new NoteContext())
            {
                // use the remove method and a lambda expression to grab the NoteID and remove it from the database 
                ctx.Note.Remove(ctx.Note.SingleOrDefault(n => n.NoteID == index));
                ctx.SaveChanges();
                dataGridView1.DataSource = ctx.Note.ToList();
            }
        }
    }
}
