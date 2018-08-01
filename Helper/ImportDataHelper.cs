using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImportDataApi.Models;
using ImportDataApi.Libraries;

namespace ImportDataApi.Helper
{
    public class ImportDataHelper
    {
        public async Task<Profile> InsertData(Profile p)
        {
           return await new ImportDataLibrary().InsertData(p);
        }
      
    }
}