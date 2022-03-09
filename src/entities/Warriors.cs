namespace RPG.src.entities
{
    public abstract class Warriors
    {
        public Warriors(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou o oponente.";
        }
        public string Name;

        public int Level;

        public string HeroType;
    }
}