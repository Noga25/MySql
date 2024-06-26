﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get(int Questions)
        {
            DataBaseMananger dbman = new DataBaseMananger();
            string Question = dbman.GetQuestion(Questions);
            return new string[] {Question};
        }

         //GET api/values/5
        //public string Get()
        //{
        //    DataBaseMananger dbman = new DataBaseMananger();
        //    string Name = dbman.GetPlayerName(1);
        //    return Name;
        //}

        public void Set(int IdPlayer, string Name)
        {
            DataBaseMananger dbman = new DataBaseMananger();
            dbman.SetPlayerName(IdPlayer, Name);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
