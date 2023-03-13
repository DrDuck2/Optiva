using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class CareTaker
    {
        private List<Memento> previousStates;
        
        public CareTaker()
        {
            previousStates = new List<Memento>();
        }

        public void AddState(Memento memento)
        {
            previousStates.Add(memento);
        }
        public void RemoveState(Memento memento)
        {
            previousStates.Remove(memento);
        }
        public void ClearStates()
        {
            previousStates.Clear();
        }

        public List<Memento> GetPreviousStates()
        {
            return previousStates;
        }
    }
}
