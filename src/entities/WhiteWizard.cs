namespace Project2.src.entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string TypeHero, int HP, int MP)
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
                this.MP -= 30;
                return this.Name+" Atacou com magia superefetiva! Bonus de "+ Bonus;
            }
            else
            {
                this.MP -= 20;

                return this.Name+ "Atacou com magia fraca. Bonus de "+ Bonus;
            };
        }
    }
}