//**************************************************************************/
// Copyright (c) 2015-2021 Luxrender.
// All rights reserved.
// 
//**************************************************************************/
// DESCRIPTION: Contains the Dll Entry stuff
// AUTHOR: Omid Ghotbi (TAO) omid.ghotbi@gmail.com www.3dfine.com
//***************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using Microsoft.Deployment.WindowsInstaller;

namespace RegistrationInputCustomAction
{
    public class CustomActions
    {
        // I just add it to be used later to save user data and other stuff in the future.
        [CustomAction]
        public static ActionResult SaveUserInput(Session session)
        {
            string input1 = session["input1Property"]; // This property should be the same in Wix Project
            string input2 = session["input2Property"]; // This property should be the same in Wix Project

            string appdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(appdataPath + "\\UserData"))
                Directory.CreateDirectory(appdataPath + "\\UserData");

            File.WriteAllText(appdataPath + "\\UserData\\registrationInput.txt", input1 + "," + input2); // Save user data in file

            return ActionResult.Success;
        }
    }
}
