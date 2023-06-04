using MauiKassasystem.Model;
using MauiKassasystem.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKassasystem.Services
{
    public class passwortServices
    {
         public string Password = "";
         public static bool IsAuthenticated = false;

        static public Zugangsdaten adminzugangsdaten = new Zugangsdaten { AdminEmail = "test@test.com", AdminPassword = "123" };

        //Löscht das alte Passwort aus der Liste und speichert das neue
        static public void SaveNewPassword()
        {
            if (LoginAdmin.Password == LoginAdmin.MasterPassword)
            {
                if (LoginAdmin.ArePasswordsMatching())
                {
                    adminzugangsdaten.AdminPassword = LoginAdmin.NewPassword;
                    IsAuthenticated = false; // Log out the user
                    LoginAdmin.IsResettingPassword = false; // Reset the password reset state
                    LoginAdmin.NewPassword = ""; // Reset the password input fields
                    LoginAdmin.ConfirmNewPassword = "";
                    LoginAdmin.ShowPasswordMismatchError = false;
                    LoginAdmin.Password = "";
                }
                else
                {
                    LoginAdmin.ShowPasswordMismatchError = true;
                }
            }
        }
    } 
}
