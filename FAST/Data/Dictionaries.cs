﻿using FAST.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAST.Data
{
    public static class Dictionaries
    {
        #region // To enter date, if new buttons are created. 

        /* If you create new kind of button in your program you have to input this kind in the dictionary.
           The order of names is not important. What is important is to enter all types of buttons.
           Only all inheritance classes and not the "BasicButton" class */

        public static Dictionary<int, string> KindOfButtonsMain = new Dictionary<int, string>()
        {
            [0] = "StartExplorerButton",
            [1] = "StartFileWithProgramButton",
            [2] = "StartWebsiteButton"
        };

        public static Dictionary<string, string> KindOfButtonsNameForForm = new Dictionary<string, string>()
        {
            ["StartExplorerButton"] = "Explorer öffnen",
            ["StartFileWithProgramButton"] = "Dokument öffnen",
            ["StartWebsiteButton"] = "Webseite öffnen"
        };

        #endregion

    }
}
