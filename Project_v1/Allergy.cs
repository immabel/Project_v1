namespace Project_v1
{
    public class Allergy
    {
        public readonly int id;
        public string Name { get; protected set; }

        public Allergy(int id, string name)
        {
            this.id = id;
            Name = name;
        }

        public override string ToString() => Name;
    }
}