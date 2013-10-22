using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace imdleaderboard.Models
{
    public class SkillModel
    {
        mvcleadermodelDataContext dc = new mvcleadermodelDataContext();

        public List<Skill> selectAll()
        {
            var result = from s in dc.Skills
                         select s;
            return result.ToList();
        }
    }
}