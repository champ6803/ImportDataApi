using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using ImportDataApi.Models;

namespace ImportDataApi.DAL
{
    public class ImportDataDAL
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Profile> col;

        public ImportDataDAL()
        {
            this.client = new MongoClient("mongodb://champ6803:www12345@clusteratsdev-shard-00-00-lxs0q.mongodb.net:27017,clusteratsdev-shard-00-01-lxs0q.mongodb.net:27017,clusteratsdev-shard-00-02-lxs0q.mongodb.net:27017/admin?ssl=true");
            this.db = client.GetDatabase("ats");
            this.col = this.db.GetCollection<Profile>("profile");
        }

        public async Task InsertData(Profile p)
        {
            await this.col.InsertOneAsync(p);
        }

    }
}