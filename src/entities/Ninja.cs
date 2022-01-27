namespace Project2.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string TypeHero, int HP, int MP)
         : base(Name, Level, TypeHero, HP, MP)
         {
            this.Name = Name;
            this.Level = Level;
            this.TypeHero = TypeHero;
            this.MP = MP;
            this.HP = HP;

         }
        public override string Attack(int Bonus, Hero Person)
        {             
            if (Bonus > 6)
            {
                this.MP -= 10;
                return this.Name+" Atacou com kunai superefetiva! Bonus de "+ Bonus;
            }
            else
            {
                this.MP -= 8;
                return this.Name+ " Atacou com kunai fraca. Bonus de "+ Bonus;
            };
        
        }
    }
}