namespace HeistExercise
{
    public class Heister
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public Heister(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = int.Parse(skillLevel);
            CourageFactor = decimal.Parse(courageFactor);
        }
    }
}