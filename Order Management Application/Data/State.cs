using System.Collections.Generic;

namespace Order_Management_Application.Data
{
    public class State
    {
        public State()
        {
            StateList = new List<string>();
            for(int i = 1; i <= 5; i++)
            {
                StateList.Add("State " + i);
            }
        }
        public List<string> StateList { get; set; }
    }
}
