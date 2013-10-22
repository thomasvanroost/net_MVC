using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace imdleaderboard.Models
{
    public class UserModel
    {
        private mvcleadermodelDataContext dc = new mvcleadermodelDataContext();

        public List<User> selectAll() 
        {
            var result = (from u in dc.Users
                         select u).ToList(); // Tolist() maakt er een lijst van.
            return result;
        }
    }
}