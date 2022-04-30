using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBWebApi.Models;

public class Event
{
    public Event(string title, string description, DateTime takesPlaceOn)
    {
        Title = title;
        Description = description;
        TakesPlaceOn = takesPlaceOn;
    }

    [BsonId]
    public ObjectId Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime TakesPlaceOn { get; set; }
}
