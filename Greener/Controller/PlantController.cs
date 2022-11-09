//using Greener.DAT;
//using Greener.DTOs;
//using Greener.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Greener.Controller
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PlantController : ControllerBase
//    {
//        PlantDAT objPlant = new PlantDAT();
//        // GET: api/<PlantController>
//        [HttpGet]
//        public List<Plant> Get ( )
//        {

//            return objPlant.AllPlants().Result.ToList();
//        }


//        [HttpPost]
//        public void Post ([FromBody] AddPantDTO addPlantDto)
//        {
//            Plant newPlant = new Plant()
//            {
//                Id = new Guid().ToString(),
//                Name = addPlantDto.Name,
//                LatinName = addPlantDto.LatinName,
//                Watered = addPlantDto.Watered,
//                SoilType = addPlantDto.SoilType,
//                Obtained = addPlantDto.Obtained
//            };
//            objPlant.AddPlant(newPlant);
//        }

//        // PUT api/<PlantController>/5
//        [HttpPut("{id}")]
//        public void Put (int id, [FromBody] Plant plant)
//        {
//            objPlant.UpdtePlant(plant);
//        }

//        // DELETE api/<PlantController>/5
//        [HttpDelete("{id}")]
//        public void Delete (string id)
//        {
//            objPlant.RemovePlant(id);
//        }
//    }
//}
