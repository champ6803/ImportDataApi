﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ImportDataApi.Models
{
    public class Profile
    {
       [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string type_account { get; set; }
        public int experience { get; set; }
        public int age { get; set; }
        public string computer_lang { get; set; }
        public string position { get; set; }
        public string location { get; set; }
        public int salary { get; set; }
    }
}
