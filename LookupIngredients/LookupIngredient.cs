using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GrocerLink.LookupIngredients
{
    public class LookupIngredient
    {
        public LookupIngredient() { }

        private readonly string connectionString = "mongodb+srv://Grant:Turtle@cluster0-knqq3.mongodb.net/test?retryWrites=true&w=majority";
        private readonly string databaseName = "CulinaryCompanion";
        private readonly string collectionName = "IngredientASIN";

        public string lookUp(List<string> ingredients)
        {
            MongoClient dbClient = new MongoClient(connectionString);
            var CCDatabase = dbClient.GetDatabase(databaseName);
            var asinCollection = CCDatabase.GetCollection<BsonDocument>(collectionName);

            var ingredientFilter = Builders<BsonDocument>.Filter.ElemMatch<BsonValue>(
                "Ingredients", new BsonDocument { { "Ingredient", ingredients.FirstOrDefault() } });
            //var firstDocument = asinCollection.Find(ingredientFilter).ToList().FirstOrDefault();
            var secondDocument = asinCollection.Find(new BsonDocument()).ToList();
            //var results = firstDocument.Any<BsonDocument>(x => x.Ingredient == "Chicken Breast");

            //Console.WriteLine(firstDocument.ToString());
            var endString = "";
            foreach (var instance in secondDocument)
            {
                endString += instance.ToString();
            }
            return endString;
        }

    }
}
