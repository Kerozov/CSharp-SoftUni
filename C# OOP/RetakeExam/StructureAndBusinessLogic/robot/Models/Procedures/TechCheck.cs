﻿using System;
using System.Collections.Generic;
using System.Text;
using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Procedures
{
   public class TechCheck:Procedure
    {
        public TechCheck()
        {
            this.RobotsProcedure = new List<IRobot>();
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);
            robot.Energy -= 8;
            if (robot.IsChecked)
            {
                robot.Energy -= 8;
            }
            else
            {
                robot.IsChecked = true;
            }
        }
    }
}
