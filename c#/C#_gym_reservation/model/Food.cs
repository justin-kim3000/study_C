using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_project.model
{
    internal class Food
    {
        string type;
        string eat;
        string name;
        string calorie;
        string carbohydrate;
        string fat;
        string protein;
        string menu;
        

        public Food(string type, string eat, string name, string calorie, string carbohydrate, string fat,
            string protein, string menu)
        {
            this.type = type;
            this.eat = eat;
            this.name = name;
            this.calorie = calorie;
            this.carbohydrate = carbohydrate;
            this.fat = fat;
            this.protein = protein;
            this.menu = menu;
            
        }

        public string Type { get => type; set => type = value; }
        public string Eat { get => eat; set => eat = value; }
        public string Name { get => name; set => name = value; }
        public string Calorie { get => calorie; set => calorie = value; }
        public string Carbohydrate { get => carbohydrate; set => carbohydrate = value; }
        public string Fat { get => fat; set => fat = value; }
        public string Protein { get => protein; set => protein = value; }
        public string Menu { get => menu; set => menu = value; }
    }
}
