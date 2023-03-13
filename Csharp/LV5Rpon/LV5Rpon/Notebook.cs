using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public class Notebook
    {
        private List<Note> notes;
        private ITheme theme; //Novo dodano za 7 zadatak
        public Notebook(ITheme theme) //Novi konstruktor za 7 zadatak
        { 
            this.notes = new List<Note>();
            this.theme = theme; //Novo dodano za 7 zadatak
        }

        //public Notebook() { this.notes = new List<Note>(); } //stari konstruktor

        public void AddNote(Note note) 
        {
            note.Theme = theme; //Novo dodano za 7 zadatak
            this.notes.Add(note); 
        }

        public void ChangeTheme(ITheme theme)
        {
            foreach(Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach(Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
