using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MilitaryElite
{
   public class Mission:IMission
   {
       private string state;
        public Mission(string codeName,string State)
        {
            this.CodeName = codeName;
            this.State = State;
        }
        public string CodeName { get; protected set; }

        public string State
        {
            get => state;
            set
            {
                if (value== "inProgress"||value== "Finished")
                {
                    state = value;
                }
            }
        }

        public void CompleteMission()
        {
            state = "Finished";
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
