
/*
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/


using System;
using System.Collections.Generic;


namespace Generic_Adventure_Game {
    internal class Program {

        public static Boolean NightmareMode = false;
        public static List<Item> Inventory = new List<Item> {};
        public static List<HealItem> HealInventory = new List<HealItem> {};
        public static List<Weapon> WeaponInventory = new List<Weapon> {};
        public static List<Tool> ToolInventory = new List<Tool> {};

        public static void Main(string[] args) {
            // cool different modes
            try {
                if (args[0] == "veryhardnightmaremode") {
                    NightmareMode = true;
                    Console.WriteLine("Very Hard Nightmare Mode Activated!");
                }
                if (args[0] == "test") {
                    Inventory.Add(new Item("Example Item"));
                    HealInventory.Add(new HealItem("Example Heal", 1, 10));
                    ToolInventory.Add(new Tool("Example Tool", 10));
                    WeaponInventory.Add(new Weapon("Example Weapon", 10));

                    Console.WriteLine(WeaponInventory[0].Name);
                    Console.WriteLine(ToolInventory[0].Use());
                }
            } catch(Exception exception) {
                if (!exception.GetType().Equals(new IndexOutOfRangeException().GetType())) {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
    
}