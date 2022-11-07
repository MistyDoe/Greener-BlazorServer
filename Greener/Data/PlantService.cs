using Greener.DTOs;

namespace Greener.Data
{
    public class PlantService
    {
        public Task<List<Plant>> AddPlant (AddPantDTO plant)
        {

            var plant = new Plant()
            {
                Id = new Guid(),
            };

            return Ok
        }

    }
}
