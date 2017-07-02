using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieMVC.BL;
using MovieMVC.Entitys;
using MovieMVC.Models;
using System.Web.Http.Results;


namespace Movie_API.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public List<User> GetAllCustomers()
        {
            UserModel model = new UserModel();
            List<User> users = UserBL.getUsers();
            return users;
        }
    }
}
