using System.Collections.Generic;
using System.ComponentModel;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory = new List<string>();

        public Player(string name, int health) 
        {
            Name = name;
            Health = health;
        }
        
        public void PickUpItem(string item)
        {

        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
    }
}

