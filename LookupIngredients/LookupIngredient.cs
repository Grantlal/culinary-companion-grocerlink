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

        public string lookUp(string ingredients)
        {
            MongoClient dbClient = new MongoClient(connectionString);
            var CCDatabase = dbClient.GetDatabase(databaseName);
            var asinCollection = CCDatabase.GetCollection<BsonDocument>(collectionName);

            /*var ingredientFilter = Builders<BsonDocument>.Filter.ElemMatch<BsonValue>(
                "Ingredients", new BsonDocument { { "Ingredient", ingredients } });*/
            var filter = Builders<BsonDocument>.Filter.Eq("Ingredient", ingredients.ToLower());

            var secondDocument = asinCollection.Find(filter).FirstOrDefault().ToString();
            var endString = "";
            foreach (var instance in secondDocument)
            {
                endString += instance.ToString();
            }
            var finalString = endString.Substring(58, 10);
            return finalString;
        }

    }
}
