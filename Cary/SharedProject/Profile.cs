using System;
using System.Collections.Generic;
using System.Text;

// Info user

namespace SharedProject
{
    class Profile : UserProfile
    {
        
    }

    public class UserProfile
    {
        private string Name { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string Weight { get; set; }
        private string Height { get; set; }
        private string Old { get; set; }
        private string Morphology { get; set; }
    }

}
