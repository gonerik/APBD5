using API5_1.Classes;

namespace API5_1.Services;

public interface IMockDB
{
    public ICollection<Animal> GetAll();
    public void Add(AnimalProp animalProp);
    public bool Replace(AnimalProp animalProp, int id);
    public bool Remove(int id);
    public Animal Get(int id);
    public bool AddVisit(Visit visit, int id);

    public ICollection<Visit> GetVisits(int id);
}