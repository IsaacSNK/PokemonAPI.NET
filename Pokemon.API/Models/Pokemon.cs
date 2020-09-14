using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Pokemon.API.Models
{
    [BsonIgnoreExtraElements]
    public class PokemonModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string name { get; set; }
    }
}