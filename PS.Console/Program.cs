using PS.domain;
using System;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Provider P1 = new Provider
            {
                UserName = "Provider1",
                Password = "123456",
                ConfirmPassword = "12345",
                IsApproved = false




            };
            P1.GetDetails();
            Provider.SetIsApproved(P1);
            P1.GetDetails();
            Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
            P1.GetDetails();
        }
    }
}
