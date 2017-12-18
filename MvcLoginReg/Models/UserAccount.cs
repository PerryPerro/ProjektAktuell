using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcLoginReg.Repositories;

namespace MvcLoginReg.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Birthdate is required")]
        public string Born { get; set; }
        [Required(ErrorMessage = "Looking for is required")]
        public string Looking { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Password is required")]
        public string ConfirmPassword { get; set; }

        public List<UserAccount> GetUserAccount(UserAccount user)
        {
              MyDbContext db = new MyDbContext();

            var usr = db.userAccount.ToList();

            return usr;

        }

    }

}