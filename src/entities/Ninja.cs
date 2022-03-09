namespace RPG.src.entities
{
    public class Ninja : Warriors
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou com sua espada ninja";
        }
    }
}