using System;
using System.Collections.Generic;
using System.Text;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;

namespace RobotService.Models.Garages
{
    public class Garage:IGarage
    {
        private const int Capacity = 10;
        private IDictionary<string, IRobot> robots;

        public Garage()
        {
            this.robots = new Dictionary<string, IRobot>();
        }


        public IReadOnlyDictionary<string, IRobot> Robots { get=>(IReadOnlyDictionary<string,IRobot>) robots; }
        public void Manufacture(IRobot robot)
        {
            if (robots.Count==Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            if (robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingRobot, robot.Name));
            }
            robots.Add(robot.Name,robot);
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot,robotName));
            }

            var currRobot = robots[robotName];
            currRobot.IsBought = true;
            currRobot.Owner = ownerName;
            robots.Remove(robotName);
        }
    }
}
