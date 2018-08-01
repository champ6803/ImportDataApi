using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImportDataApi.Models;
using ImportDataApi.DAL;

namespace ImportDataApi.Libraries
{
    public class ImportDataLibrary
    {
       ImportDataDAL imDAL = new ImportDataDAL();
       public async Task<Profile> InsertData(Profile p)
       {
        Profile pro = new Profile();
            pro.fullname = p.fullname;
            pro.position = p.position;
            pro.location = p.location;
            pro.salary = p.salary;
            pro.type_account = p.type_account;
            pro.age = p.age;
            pro.email = p.email;
            pro.computer_lang = p.computer_lang;
            await imDAL.InsertData(pro);
            return  pro;
       }
        
    }
}