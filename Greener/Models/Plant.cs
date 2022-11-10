using Google.Cloud.Firestore;

namespace Greener.Models
{
    [FirestoreData]
    public class Plant
    {
        public string Id { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string LatinName { get; set; }
        [FirestoreProperty]
        public string SoilType { get; set; }
        [FirestoreProperty]
        public List<string>? Watered { get; set; }
        [FirestoreProperty]
        public List<string>? Feritilized { get; set; }
        [FirestoreProperty]
        public List<string>? Cutting { get; set; }
        [FirestoreProperty]
        public string? Obtained { get; set; }
    }
}
