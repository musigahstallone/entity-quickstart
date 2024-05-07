using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Threading.Tasks;
using entity_quickstart;

var mongoDatabase = new MongoClient("mongodb://localhost:27017").GetDatabase("CatalogDB");

// Setup DbContextOptions for ProductContext with MongoDB
var dbOptions = new DbContextOptionsBuilder<CatalogContext>()
    .UseMongoDB(mongoDatabase.Client, mongoDatabase.DatabaseNamespace.DatabaseName)
    .Options;

// Create ProductContext using the DbContextOptions
using var context = new CatalogContext(dbOptions);

// Retrieve all products from MongoDB
var products = await context.Products.ToListAsync();
var brandss = await context.Brands.ToListAsync();

// var byPrice = products.Where(x => x.Price < 50).Select(p => p);
// var distinctProducts = byPrice.Select(p => p.Price);


// Extract distinct brands from products
var distinctBrands = products.Select(p => p.Brand).Distinct().Select(brandName => brandName );

var theCount = distinctBrands.Count();

foreach (var item in distinctBrands.OrderBy(b => b))
Console.WriteLine(item);

