using Greener.Models;

namespace Greener.Interface
{
    public interface IPlant
    {
        public Task<List<Plant>> AllPlants ( );
        public void AddPlant (Plant plant);
        public void UpdtePlant (Plant plant);
        public void RemovePlant (string Id);
    }
}
