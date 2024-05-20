using Bapp.Components.Layout;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Dane
{
    class Konta
    {
        const string connectionUri="mongodb://127.0.0.1:27017/";
        MongoClient Mclient = new MongoClient(connectionUri);
        public string id {get; set;} = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
    }
}
