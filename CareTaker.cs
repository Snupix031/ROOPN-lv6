using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    class CareTaker
    {
        private int i;
        private List<Memento> previousState;
        public Memento PreviousState { get; set; }


        public CareTaker() { this.previousState = new List<Memento>(); i = previousState.Count - 1; }
        public CareTaker(List<Memento> previousState)
        {
            this.previousState = previousState;
            i = previousState.Count - 1;
        }
        public Memento Undo()
        {
            --i;
            if (i < 0) return null;
            return previousState[i];
        }

        public void AddPreviousState(Memento state) { previousState.Add(state); i = previousState.Count - 1; }

        public Memento Redo()
        {
            ++i;
            if (i > previousState.Count - 1) return null;
            return previousState[i];
        }
    }
}
