using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace State_Management_Tasks
{
    public class GenrateUniqueId
    {
        public static int UniqueId = 1000;
        public GenrateUniqueId()
        {
            UniqueId++;  
            //Random random = new Random();
            //UniqueId = random.Next(1000).ToString();
        }

    }
}