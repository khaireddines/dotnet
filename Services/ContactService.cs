using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ExerciceOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciceOne.Service;

public class ContactService
{
    private readonly IMongoCollection<Contact> _contactCollection;

    public ContactService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        var mongoClient = new MongoClient(
            mongoDBSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            mongoDBSettings.Value.DataBaseName);

        _contactCollection = mongoDatabase.GetCollection<Contact>(
            mongoDBSettings.Value.ContactCollection);
    }
    public async Task<List<Contact>> GetAsync() =>
        await _contactCollection.Find(_ => true).Limit(500).ToListAsync();

    public List<Contact> GetAll() =>
        _contactCollection.Find(_ => true).Limit(500).ToList();
    
}