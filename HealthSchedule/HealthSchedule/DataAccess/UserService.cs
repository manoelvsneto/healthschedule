using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSchedule.DataAccess
{
    public class UserService
    {
        public RestService restService;

        public UserService()
        {
            restService = new RestService();
        }

        public bool InsertUser(dynamic user)
        {
            dynamic result = restService.Execute("/user", user, RestSharp.Method.POST);
            return result.Data;
        }
    }
}
