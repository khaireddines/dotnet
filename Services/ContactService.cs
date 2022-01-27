using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ExerciceOne.Models;

public class ExerciseService
{
    private readonly IMongoCollection<Contact> _contactCollection;

    public ExerciseService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        var mongoClient = new MongoClient(
            mongoDBSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            mongoDBSettings.Value.DataBaseName);

        _contactCollection = mongoDatabase.GetCollection<Contact>(
            mongoDBSettings.Value.ContactCollection);
    }
    public async Task<List<Contact>> GetAsync() =>
        await _contactCollection.Find(_ => true).ToListAsync();
    
}