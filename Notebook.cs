using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    class Notebook
    {
        private List<Note> notes;
        public Notebook()
        {
            this.notes = new List<Note>();
        }

        public Notebook(List<Note> notes)
        {
            this.notes = new List<Note>(notes.ToArray());
        }

        public void AddNote(Note note)
        {
            this.notes.Add(note);
        }
        public void RemoveNote(Note note)
        {
            this.notes.Remove(note);
        }
        public void Clear()
        {
            int i = 0;
            foreach (Note note in notes)
            {
                this.notes.RemoveAt(i);
            }
        }
        public int Count { get { return this.notes.Count; } }
        public Note this[int index] { get { return this.notes[index]; } }
        public Iterator GetIterator() { return new Iterator(this); }
    }
}
