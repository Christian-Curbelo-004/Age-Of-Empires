using System;
using CreateBuildings;

namespace ArcherCenter
{
    public class Archer : Buildings
    {
        public Archer(int endurence, int constructionspeed)
             : base(endurence, constructionspeed)
        {
        }
        public override void Build(int resourceValue)
        {
            Console.WriteLine($"Creando Archer center con {resourceValue} recursos");
        }
        public void CreateArcherCenter()
        {
            Console.WriteLine("Archer Center creado!");
        }
    }
}
