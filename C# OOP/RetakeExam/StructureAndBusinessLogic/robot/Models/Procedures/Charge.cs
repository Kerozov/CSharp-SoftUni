﻿using System;
using System.Collections.Generic;
using System.Text;
using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Procedures
{
   public class Charge:Procedure
    {
        public Charge()
        {
                this.RobotsProcedure = new List<IRobot>();
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot,procedureTime);
            robot.Happiness += 12;
            robot.Energy += 10;
            this.RobotsProcedure.Add(robot);
        }
    }
}
