using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExerciceOne.Models;

public class Contact
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public int index { get; set; }
    public string guid { get; set; }
    public bool isActive { get; set; }
    public string balance { get; set; }
    public string picture { get; set; }
    public int age { get; set; }
    public string eyeColor { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public string company { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string address { get; set; }
    public string about { get; set; }
    public string registered { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public List<string> tags { get; set; }
    public List<object> friends { get; set; }
    public string greeting { get; set; }
    public string favoriteFruit { get; set; }
    
}