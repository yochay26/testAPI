using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Member.Data.Interface;
using Member.Data.Model;
using Member.Data.Repository;

namespace testApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberApiController : ControllerBase
    {
       private IMember  members = new MembersRepository();

        [HttpGet("GetAllMembers")]
        public ActionResult<IEnumerable<Member.Data.Model.Member>> GetAllMembers()
        {
            return members.GetAllMember();
        }
        [HttpGet("GetMemberById/{id}")]
        public ActionResult<string> GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}