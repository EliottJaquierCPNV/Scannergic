using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    public class AppManager
    {
        private static Allergic allergic;

        public static Allergic Me
        {
            get { return allergic; }
        }

        public static void Init()
        {
            allergic = new Allergic();
        }
    }
}
