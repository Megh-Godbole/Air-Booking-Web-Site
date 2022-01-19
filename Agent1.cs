using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace State_Management_Tasks
{
    public static class Agent1
    {
        public static string UserName { get; set; } = "Agent1";
        public static string Password { get; set; } = "Agent@1";
        public static string Country { get; set; } = "IND";
        public static string FullName { get; set; } = "Megh Godbole";

        public static List<string> TravellerUniqueIds = new List<string>();
    }
}