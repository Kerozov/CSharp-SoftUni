using System;
using System.Collections.Generic;
using System.Text;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;

namespace RobotService.Models.Procedures
{
   public class Chip:Procedure
    {

        public Chip()
        {
            this.RobotsProcedure = new List<IRobot>();
        }

        //TODO:FirstCondition
        public override void DoService(IRobot robot, int procedureTime)
        {
            if (robot.IsChipped)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.AlreadyChipped, robot.Name));
            }
            base.DoService(robot, procedureTime);
            robot.Happiness -= 5;
            robot.IsChipped = true;
            this.RobotsProcedure.Add(robot);
        }
    }
}
