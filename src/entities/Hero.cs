
namespace Project2.src.entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string TypeHero, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.TypeHero = TypeHero;
            this.MP = MP;
            this.HP = HP;

        }

        protected Hero(string name, int level, string typeHero)
        {
            Name = name;
            Level = level;
            TypeHero = typeHero;
        }

        public string Name;
        public int Level;
        public string TypeHero;
        public int HP;
        public int MP;

        public override string ToString()
        {
            return this.Name+ " "+this.TypeHero+" "+ this.Level+" "+this.MP+" "+this.HP;
        }

        public virtual string Attack(int Bonus, Hero Person){
            return this.Name+" Atacou com sua espada";
        }

    }
}