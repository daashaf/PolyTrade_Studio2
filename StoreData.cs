using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PolyTrade_WebApp
{
    internal class StoreData
    {
        private readonly string filePath = @"D:\Studio2\userData.txt";

        public bool ValidateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            if (!File.Exists(filePath))
                return false;

            var lines = File.ReadAllLines(filePath);

            return lines.Any(line =>
            {
                var parts = line.Split(',');
                return parts.Length == 2 &&
                       parts[0].Trim().Equals(username, StringComparison.OrdinalIgnoreCase) &&
                       parts[1].Trim().Equals(password);
            });
        }
    }
}



