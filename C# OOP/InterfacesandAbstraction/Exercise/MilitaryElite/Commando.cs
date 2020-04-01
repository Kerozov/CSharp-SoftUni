using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MilitaryElite
{
  public  class Commando:ISpecialisedSoldier,IMission
  {
      private string state;
        private string _codeName;
        public List<Mission> Missions { get;  set; }
        public string Id { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public decimal Salary { get;  set; }
        public string Corps { get;  set; }
        public List<string> CodeName { get;  set; }
        public string State
        {
            get => state;
            set
            {
                if (value == "inProgress" || value == "Finished")
                {
                    state = value;
                }
            }
        }

        public void CompleteMission()
        {
            state = "Finished";
        }

        public Commando(string id,string firstName,string lastName,decimal salary,string corps,List<Mission>missions) 
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            this.Missions = new List<Mission>();
            this.Missions = missions;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine($"Missions:");
            if (Missions.Count!=0&&Missions!=null)
            {
                foreach (var mission in Missions)
                {
                    sb.AppendLine($" {mission.ToString()}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        string IMission.CodeName => _codeName;
    }
}
