using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

namespace State_Management_Tasks
{
    /// <summary>
    /// Store The Agent2 Related Details
    /// </summary>
    public static class Agent2
    {
        #region Agent2 Details
        public static string UserName { get; set; } = "Agent2";
        public static string Password { get; set; } = "Agent@2";
        public static string Country { get; set; } = "USA";
        public static string FullName { get; set; } = "Ganesh Godbole";
        #endregion

        #region FlightDates
        public static string FlightDateFromUsaToInd;
        public static string FlightDateFromIndToUsa;
        #endregion
        
        #region Traveller Unique Ids
        public static List<string> TravellerUniqueIds = new List<string>();
        #endregion

    }
}