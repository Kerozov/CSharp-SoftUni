using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;
using RobotService.Core.Contracts;
using RobotService.Models.Garages;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Procedures;
using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IGarage garage;
        private IProcedure procedureChip;
        private IProcedure procedureCharge;
        private IProcedure procedurePolish;
        private IProcedure procedureRest;
        private IProcedure procedureTeach;
        private IProcedure procedureWork;


        public Controller()
        {
            procedureChip = new Chip();
            procedureCharge = new Charge();
            procedurePolish = new Polish();
            procedureRest = new Rest();
            procedureTeach = new TechCheck();
            procedureWork = new Work();
            garage = new Garage();
        }
        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            IRobot robot;
            if (robotType == "HouseholdRobot")
            {
                robot = new HouseholdRobot(name, energy, happiness, procedureTime);
            }
            else if (robotType == "WalkerRobot")
            {
                robot = new WalkerRobot(name, energy, happiness, procedureTime);
            }
            else if (robotType == "PetRobot")
            {
                robot = new PetRobot(name, energy, happiness, procedureTime);
            }
            else
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InvalidRobotType, robotType));
            }
            garage.Manufacture(robot);
            return String.Format(OutputMessages.RobotManufactured, robot.Name);
        }

        public string Chip(string robotName, int procedureTime)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot currRobot = garage.Robots[robotName];


            procedureChip.DoService(currRobot, procedureTime);
            return String.Format(OutputMessages.ChipProcedure, robotName);
        }

        public string TechCheck(string robotName, int procedureTime)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot currRobot = garage.Robots[robotName];

            procedureTeach.DoService(currRobot, procedureTime);
            return String.Format(OutputMessages.TechCheckProcedure, robotName);
        }

        public string Rest(string robotName, int procedureTime)
        {

            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot currRobot = garage.Robots[robotName];

            procedureRest.DoService(currRobot, procedureTime);
            return String.Format(OutputMessages.RestProcedure, robotName);
        }

        public string Work(string robotName, int procedureTime)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot currRobot = garage.Robots[robotName];

            procedureWork.DoService(currRobot, procedureTime);
            return String.Format(OutputMessages.WorkProcedure, robotName,procedureTime);
        }

        public string Charge(string robotName, int procedureTime)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot currRobot = garage.Robots[robotName];

            procedureCharge.DoService(currRobot, procedureTime);
            return String.Format(OutputMessages.ChargeProcedure, robotName);
        }

        public string Polish(string robotName, int procedureTime)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot currRobot = garage.Robots[robotName];

            procedurePolish.DoService(currRobot, procedureTime);
            return String.Format(OutputMessages.PolishProcedure, robotName);
        }

        public string Sell(string robotName, string ownerName)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            IRobot currRobot = garage.Robots[robotName];
            garage.Sell(robotName, ownerName);
            if (currRobot.IsChipped)
            {
                return String.Format(OutputMessages.SellChippedRobot, ownerName);
            }
            else
            {
                return String.Format(OutputMessages.SellNotChippedRobot, ownerName);

            }
        }

        public string History(string procedureType)
        {
            var sb= new StringBuilder();
            if (procedureType == "Chip")
            {
                sb.AppendLine(procedureChip.History());
            }
            else if (procedureType == "Charge")
            {
                sb.AppendLine(procedureCharge.History());
            }
            else if (procedureType == "Rest")
            {
                sb.AppendLine(procedureRest.History());
            }
            else if (procedureType == "Polish")
            {
                sb.AppendLine(procedurePolish.History());
            }
            else if (procedureType == "Work")
            {
                sb.AppendLine(procedureWork.History());
            }
            else if (procedureType == "TechCheck")
            {
                sb.AppendLine(procedureTeach.History());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
