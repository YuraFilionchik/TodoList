using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TodoList.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public static string AnonymousUserMail = "anon@mail.com";
        public static string AnonymousUserPassword = "password";
      }

}
