﻿using System;
using System.Collections.Generic;
using System.Text;
using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Procedures
{
   public class Work:Procedure
    {
        public Work()
        {
            this.RobotsProcedure = new List<IRobot>();
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);
            robot.Energy -= 6;
            robot.Happiness += 12;
            this.RobotsProcedure.Add(robot);
        }
    }
}
