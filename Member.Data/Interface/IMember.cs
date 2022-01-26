using System;
using System.Collections.Generic;
using System.Text;
using Member.Data.Model;

namespace Member.Data.Interface
{
    public interface IMember
    {
        List<Member.Data.Model.Member> GetAllMember();
        string GetMember(int id);
    }
}
