using System;
using System.Collections.Generic;
using System.Text;

namespace PS.domain
{
    public class Provider:Concept
    {
        
        
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 5 && value.Length <= 20) password = value;
                else Console.WriteLine("le mdp doit avour une taille 5 -> 20");
            }
        }
            private string confirmpassword;
        public string ConfirmPassword
        {
            get { return confirmpassword; }
            set
            {
                if (!value.Equals(Password))
                    Console.WriteLine("password nest pas valide");
                else
                    confirmpassword = value;
            }
        }
    
        public string UserName { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("UserName:"+ UserName+ "IsApproved: "+IsApproved);
        }
        public static void SetIsApproved (Provider P)
        {
            P.IsApproved = P.Password.CompareTo(P.ConfirmPassword) == 0;
        }
        public static void SetIsApproved (string password, string ConfirmPassword, bool isapproved)
        {
            isapproved = password.CompareTo(ConfirmPassword) == 0;
        }
        
    }
}
