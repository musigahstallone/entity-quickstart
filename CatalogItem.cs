using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace entity_quickstart;

public class CatalogItem
{
    // [BsonRepresentation(BsonType.ObjectId)]
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? PictureFileName { get; set; }

    public string? Type { get; set; }

    public string? Brand { get; set; }
}


public class CatalogBrand
{
    public int Id { get; set; }

    [Required]
    public string? Brand { get; set; }
}