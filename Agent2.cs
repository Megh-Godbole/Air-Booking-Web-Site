using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

namespace State_Management_Tasks
{
    public static class Agent2
    {
        public static string UserName { get; set; } = "Agent2";
        public static string Password { get; set; } = "Agent@2";
        public static string Country { get; set; } = "USA";
        public static string FullName { get; set; } = "Ganesh Godbole";

        public static List<string> TravellerUniqueIds = new List<string>();
    }
}