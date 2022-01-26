using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Member.Data.Interface;
using Member.Data.Model;
using Newtonsoft.Json;

namespace Member.Data.Repository
{
    public class MembersRepository : IMember
    {
        List<Model.Member> lisMembers = new List<Model.Member>
        {
            new Model.Member{MemberId=1, FirstName="Kirtesh", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=2, FirstName="Nitya", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=3, FirstName="Dilip", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=4, FirstName="Atul", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=5, FirstName="Swati", LastName="Shah", Address="Vadodara" },
            new Model.Member{MemberId=6, FirstName="Rashmi", LastName="Shah", Address="Vadodara" },
        };
        public List<Model.Member> GetAllMember()
        {
            return lisMembers;
        }

        public string GetMember(int id)
        {
            return JsonConvert.SerializeObject(lisMembers.FirstOrDefault(x=>x.MemberId == id));
        }
    }
}
