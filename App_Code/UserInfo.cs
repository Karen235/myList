using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// UserInfo 的摘要描述
/// </summary>



    public class UserInfo
    {
        public UserInfo(string firstName, string lastName, string email, string address, string contact)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            Contact = contact;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
    }
