namespace API5_1.Classes;

public class Animal
{
    private static int maxId_ { get; set; } = 0;
    public int Id { get;  }
    public string Name { get; }
    public Category AnimCategory { get; }
    public double Weight { get; }
    public Color AnimColor { get; }
    public ICollection<Visit> Visits { get; set; } = new List<Visit>();

    public Animal(int id,string name, Category category, double weight, Color color)
    {
        Id = id;
        Name = name;
        AnimCategory = category;
        Weight = weight;
        AnimColor = color;
    }

    public Animal(AnimalProp animalProp)
    {
        Id = maxId_;
        maxId_ += 1;
        Name = animalProp.Name;
        AnimCategory = animalProp.AnimCategory;
        Weight = animalProp.Weight;
        AnimColor = animalProp.AnimColor;
    }
}