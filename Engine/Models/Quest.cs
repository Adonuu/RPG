﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<ItemQuantity> ItemsToComplete { get; set; } = new List<ItemQuantity>();
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; } = new List<ItemQuantity>();

        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete, int rewardExperiencePoints, int rewardGold, List<ItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }
    }
}
