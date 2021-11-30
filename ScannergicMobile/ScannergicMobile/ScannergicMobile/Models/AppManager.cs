using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    /// <summary>
    /// This class Manag the user path in the App
    /// </summary>
    public class AppManager
    {
        private static Allergic allergic;

        /// <summary>
        /// Get the current Allergic
        /// </summary>
        public static Allergic Me
        {
            get { return allergic; }
        }

        /// <summary>
        /// Initialize app models
        /// </summary>
        public static void Init()
        {
            allergic = new Allergic();
        }
    }
}
