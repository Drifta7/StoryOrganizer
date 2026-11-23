namespace StoryOrganizer
{
    public class Relationship
    {
        public Character? From { get; set; }
        public Character? To { get; set; }
        public RelationshipType Type { get; set; }
        public string? Description { get; set; }
        public bool IsSecret { get; set; } // hidden from reader until revealed 

    }
    public enum RelationshipType
    {
        Unknown,
        Family,
        Romantic,
        Friend,
        Mentor,
        Rival,
        Employer,
        Associates,
        Enemy,
        Acquaintances,
        Toxic,
        CoDependent,
        Abusive,
        Sexual,
        LongDistance,
    }
}
