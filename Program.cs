﻿
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



namespace Generic_Adventure_Game {
    internal class Program {

        public static Boolean NightmareMode = false;
        public static List<Item> Inventory = new List<Item> {};

        public static void Main(string[] args) {
            // cool different modes
            if (args[0] == "veryhardnightmaremode") {
                NightmareMode = true;
                Console.WriteLine("Very Hard Nightmare Mode Activated!");
            }
            if (args[0] == "test") {
                Inventory.Add(new Item("Example Item"));
                Inventory.Add(new HealItem("Example Heal", 1, 10));
                Inventory.Add(new Tool("Example Tool", 10));
                Inventory.Add(new Weapon("Example Weapon", 10));
            }
        }
    }
    
}