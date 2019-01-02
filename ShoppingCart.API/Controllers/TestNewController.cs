using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.BAL.Interfaces;
using ShoppingCart.DTO.DTO;

namespace ShoppingCart.API.Controllers
{
    [Produces("application/json")]
    [Route("api/TestNew")]
    public class TestNewController : Controller
    {
        IUserRoleService _userRoleService;
        public TestNewController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet]
        public IEnumerable<UserRoleDTO> Get()
        {
            return _userRoleService.GetAllUserRoles();
        }
        [HttpDelete]
        public string Delete(int roleid)
        {
            //    _unitOfWork.userRoleRepository.Delete(roleid);
            //    _unitOfWork.Commit();
            return "deleted";
        }
        [HttpPost]
        public string AddEditUser([FromBody]UserRoleDTO value)
        {
            try
            {
                if (value.RoleId < 1)
                    _userRoleService.SaveUserRole(value);
                //else
                // _userRoleService.userRoleRepository.Update(value);


            }
            catch (System.Exception)
            {

                throw;
            }

            return "Data Saved";
        }
    }
}