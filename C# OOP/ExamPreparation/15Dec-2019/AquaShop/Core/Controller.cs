using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Fish;
using AquaShop.Utilities.Messages;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private ICollection<IAquarium> aquariums;

        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType == "FreshwaterAquarium")
            {
                aquariums.Add(new FreshwaterAquarium(aquariumName));
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquariums.Add(new SaltwaterAquarium(aquariumName));
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            return String.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType == "Ornament")
            {
                decorations.Add(new Ornament());
            }
            else if (decorationType == "Plant")
            {
                decorations.Add(new Plant());
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            return String.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            if (decorations.FindByType(decorationType) != null)
            {
                foreach (var aquarium in aquariums)
                {
                    if (aquarium.Name == aquariumName)
                    {
                            var decoration = decorations.FindByType(decorationType);
                            aquarium.AddDecoration(decoration);
                            decorations.Remove(decoration);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration,
                    decorationType));
            }
            return String.Format(OutputMessages.EntityAddedToAquarium,decorationType,aquariumName);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium aqurium = aquariums.First(a=>a.Name==aquariumName);
         
            if (fishType == "FreshwaterFish")
            {
                if (aqurium.GetType().Name!= "FreshwaterAquarium")
                {
                throw new InvalidOperationException(OutputMessages.UnsuitableWater);
                }
                aqurium.AddFish(new FreshwaterFish(fishName,fishSpecies,price));
            }
            else if (fishType == "SaltwaterFish")
            {
                if (aqurium.GetType().Name != "SaltwaterAquarium")
                {
                    throw new InvalidOperationException(OutputMessages.UnsuitableWater);
                }
                aqurium.AddFish(new SaltwaterFish(fishName,fishSpecies,price));
            }
            else
            {
            throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            return String.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
        }

        public string FeedFish(string aquariumName)
        {
             aquariums.First(a=>a.Name==aquariumName).Feed();
            return String.Format(OutputMessages.FishFed, aquariums.First(a => a.Name == aquariumName).Fish.Count);
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aqurium = aquariums.First(a => a.Name == aquariumName);
            decimal sum = 0;
            foreach (var fish in aqurium.Fish)
            {
                sum += fish.Price;
            }

            sum += aqurium.Decorations.Sum(d => d.Price);
            return $"The value of Aquarium {aquariumName} is {sum:F2}.";
        }

        public string Report()
        {
            var sb = new StringBuilder();
            foreach (var a in aquariums)
            {
                sb.AppendLine(a.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
