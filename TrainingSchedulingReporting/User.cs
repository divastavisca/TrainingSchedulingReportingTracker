using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSchedulingReporting
{
    public class User
    {
        public string Name, UserName, PassWord;
        public bool IsAuthorized(string UserName, string PassWord)
        {
            if (UserName == this.UserName && PassWord == this.PassWord)
                return true;
            return false;
        }
    }

    public class Admin : User
    {
        public Admin(string Name,string UserName,string PassWord)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.PassWord = PassWord;
        }
    }

    public class Trainer : User
    {
        public Trainer(string Name, string UserName, string PassWord)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.PassWord = PassWord;
        }
    }

    public class Trainee : User
    {
        public Trainee(string Name, string UserName, string PassWord)
        {
            this.Name = Name;
            this.UserName = UserName;
            this.PassWord = PassWord;
        }
    }

}
