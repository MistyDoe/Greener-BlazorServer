using Google.Cloud.Firestore;
using Greener.Interface;
using Greener.Models;
using Newtonsoft.Json;

namespace Greener.DAT
{
    public class PlantDAT : IPlant
    {
        string projectId;
        FirestoreDb firestoreDb;

        public PlantDAT ( )
        {
            string dbFilePath = "C:\\Users\\migli\\source\\greener---the-palnt-manager-firebase-adminsdk-7vhar-5ca5a2aaee.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", dbFilePath);
            projectId = "greener---the-palnt-manager";
            firestoreDb = FirestoreDb.Create(projectId);

        }
        public async void AddPlant (Plant plant)
        {
            try
            {
                CollectionReference collectionReference = firestoreDb.Collection("Plants");
                await collectionReference.AddAsync(plant);
            }
            catch ( Exception )
            {

                throw;
            }
        }

        public async Task<List<Plant>> AllPlants ( )
        {
            try
            {
                Query allPlantsQ = firestoreDb.Collection("Plants");
                QuerySnapshot allPlantsSnap = await allPlantsQ.GetSnapshotAsync();
                List<Plant> plants = new List<Plant>();
                foreach ( DocumentSnapshot document in allPlantsSnap.Documents )
                {
                    if ( document.Exists )
                    {
                        Dictionary<string, object> dictionary = document.ToDictionary();
                        string json = JsonConvert.SerializeObject(dictionary);
                        Plant newPlant = JsonConvert.DeserializeObject<Plant>(json);
                        newPlant.Id = document.Id;
                        plants.Add(newPlant);

                    }
                }
                List<Plant> sortedPlants = plants.OrderBy(n => n.Name).ToList();
                return sortedPlants;
            }
            catch ( Exception )
            {

                throw;
            }
        }

        public async void RemovePlant (string Id)
        {
            try
            {
                DocumentReference documentReference = firestoreDb.Collection("Plants").Document(Id);
                await documentReference.DeleteAsync();
            }
            catch ( Exception )
            {

                throw;
            }
        }

        public async void UpdtePlant (Plant plant)
        {
            try
            {
                DocumentReference documentReference = firestoreDb.Collection("Plamts").Document(plant.Id);
                await documentReference.SetAsync(plant, SetOptions.Overwrite);
            }
            catch ( Exception )
            {

                throw;
            }
        }
    }
}
