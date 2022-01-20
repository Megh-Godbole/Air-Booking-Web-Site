using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace State_Management_Tasks
{
    /// <summary>
    /// Store The Agent1 Related Details
    /// </summary>
    public static class Agent1
    {
        #region Agent1 Details
        public static string UserName { get; set; } = "Agent1";
        public static string Password { get; set; } = "Agent@1";
        public static string Country { get; set; } = "IND";
        public static string FullName { get; set; } = "Megh Godbole";
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