using System;
using System.IO;

namespace PolyTrade_WebApp
{
    public class StoreData
    {
        private string filePath = @"C:\Users\daash\OneDrive - Otago Polytechnic\Studio2\Sprint1\PolyTrade_Studio2\RegisterData.txt";

        public bool ValidateUser(string Username, string Password)
        {
            if (!File.Exists(filePath))
                return false;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|'); // username|password|fullname|studentid|email
                if (parts.Length >= 2)
                {
                    string savedUsername = parts[0].Trim();
                    string savedPassword = parts[1].Trim();

                    if (savedUsername.Equals(Username, StringComparison.OrdinalIgnoreCase) &&
                        savedPassword == Password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
