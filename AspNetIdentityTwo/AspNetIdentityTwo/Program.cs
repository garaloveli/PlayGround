using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspNetIdentityTwo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userName = "utest@belatrixsf.com";
            string password = "Hamtaro@2017";


            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var creationRes = userManager.Create(new IdentityUser(userName), password);

            Console.WriteLine("User created : {0}", creationRes);
        }
    }
}
