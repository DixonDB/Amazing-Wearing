using Amazing.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazing.RepoDB
{
    public class AppSettings
    {
        public static string ApiFirebase = "https://amazing-ce8f1-default-rtdb.firebaseio.com/";
        private static string KeyAplication = "AIzaSyBLE_Fll_D44fbiqPt2asT-zpKDwVJdGAU";


        public static ResponseAuthentication oAuthentication { get; set; }
        private static string ApiUrlGoogleApis = "https://identitytoolkit.googleapis.com/v1/";

        public static string ApiAuthentication(string tipo)
        {
            if (tipo == "LOGIN")
                return ApiUrlGoogleApis + "accounts:signInWithPassword?key=" + KeyAplication;
            else if (tipo == "SIGNIN")
                return ApiUrlGoogleApis + "accounts:signUp?key=" + KeyAplication;
            else
                return "";
        }
    }
}
