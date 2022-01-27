namespace Project2.src.entities
{
    public class Knigth : Hero
    {
        public Knigth(string Name, int Level, string TypeHero, int HP, int MP)
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
                Person.HP -= Bonus;
                this.MP += 20;
                return this.Name+" Atacou com espada superefetiva! Bonus de "+ Bonus;
            }
            else
            {
                this.MP += 10;
                return this.Name+ "Atacou com espada fraca. Bonus de "+ Bonus;
            };
        }
    }
}