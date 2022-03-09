namespace RPG.src.entities
{
    public class Wizard : Warriors
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " atacou com sua magia";
        }

        public virtual string Attack(int Bonus)
        {
            if (Bonus > 6)
	        {
	            return this.Name + " lançou magia super efetiva com bonus de " + Bonus;
	        }
	        else
	        {
	            return this.Name + " lançou uma magia com força fraca com bonus de " + Bonus;
            }

        }
    }
}