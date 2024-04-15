using API5_1.Classes;

namespace API5_1.Services;

public class MockDB : IMockDB
{
    private ICollection<Animal> _animals;

    public MockDB()
    {
        _animals = new List<Animal>
        {
            new Animal(0,"Catty", Category.Cat, 4.5, Color.Black),
            new Animal(1,"Dogy", Category.Dog, 6.5, Color.White)
        };
    }

    public ICollection<Animal> GetAll()
    {
        return _animals;
    }

    public void Add(AnimalProp animalProp)
    {
        _animals.Add(new Animal(animalProp));
    }

    public bool Replace(AnimalProp animalProp, int id)
    {
        var animalToPut = new Animal(id, animalProp.Name, animalProp.AnimCategory, animalProp.Weight,
            animalProp.AnimColor);
        var animalToRemove = _animals.FirstOrDefault(e => e.Id == id);
        if (animalToRemove is not null)
        {
            _animals.Remove(animalToRemove);
            _animals.Add(animalToPut);
            return true;
        }

        return false;
    }

    public bool Remove(int id)
    {
        
        var animalToRemove = _animals.FirstOrDefault(e => e.Id==id);
        if (animalToRemove is not null)
        {
            _animals.Remove(animalToRemove);
            return true;
        }

        return false;
    }

    public Animal Get(int id)
    {
        return _animals.FirstOrDefault(e => e.Id == id);
    }

    public bool AddVisit(Visit visit, int id)
    {
        var animal = _animals.FirstOrDefault(e => e.Id==id);
        if (animal is not null)
        {
            animal.Visits.Add(visit);
            return true;
        }

        return false;
    }

    public ICollection<Visit> GetVisits(int id)
    {
        return _animals.FirstOrDefault(e => e.Id == id).Visits;
    }
}