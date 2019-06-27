using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime theDateTime)
        {
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - theDateTime.Year;
            // Go back to the year the person was born in case of a leap year
            if (theDateTime.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}