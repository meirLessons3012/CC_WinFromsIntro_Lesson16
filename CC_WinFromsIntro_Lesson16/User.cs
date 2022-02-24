using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_WinFromsIntro_Lesson16
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsVeg { get; set; }
        public GenderTypes Gender { get; set; }
    }


}
