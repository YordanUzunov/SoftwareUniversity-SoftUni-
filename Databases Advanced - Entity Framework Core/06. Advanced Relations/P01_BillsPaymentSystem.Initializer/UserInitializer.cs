namespace P01_BillsPaymentSystem.Initializer
{
    using P01_BillsPaymentSystem.Data.Models;

    public class UserInitializer
    {
        public static User[] GetUsers()
        {
            User[] users = new User[]
            {
                new User() {FirstName = "Gosho", LastName = "Georgiev", Email = "tamburaki@abv.bg", Password = "asdasfr1" },
                new User() {FirstName = "Pesho", LastName = "Penev", Email = "harekche@abv.bg", Password = "gasgaaads"  },
                new User() {FirstName = "Drago", LastName = "Tenev", Email = "sexgod@abv.bg", Password = "sdgsssdg"  },
                new User() {FirstName = "Misho", LastName = "Dimitrov", Email = "blabla@abv.bg", Password = "hshsdhsdh"  },
                new User() {FirstName = "Kalin", LastName = "Evstatiev", Email = "annakin@abv.bg", Password = "xvcxcvxcv"  },
                new User() {FirstName = "Petar", LastName = "Kalinov", Email = "krastavici@abv.bg", Password = "sfsdssa"  },
                new User() {FirstName = "Techo", LastName = "Genov", Email = "bobslutenica@abv.bg", Password = "agdsgsdgs"  },
                new User() {FirstName = "Raiko", LastName = "Rios", Email = "osvaldo@abv.bg", Password = "hshsds"  },
                new User() {FirstName = "Boris", LastName = "Borislavov", Email = "destroyer666@abv.bg", Password = "hshshsa"  },
                new User() {FirstName = "Velko", LastName = "Genadiev", Email = "harakiriiiii@abv.bg", Password = "wwewwewa"  },
                new User() {FirstName = "Dilqn", LastName = "Petrov", Email = "daimooooo@abv.bg", Password = "sesfgsgs"  },
                new User() {FirstName = "Dobri", LastName = "Dobrev", Email = "qkfen@abv.bg", Password = "fdgdgadf"  },
                new User() {FirstName = "Delyo", LastName = "Melyo", Email = "aslpls@abv.bg", Password = "gdsgsdgsg1"  },
                new User() {FirstName = "Maria", LastName = "Georgieva", Email = "hubatamaria@abv.bg", Password = "hhhhhgsdgsg"  },
                new User() {FirstName = "Vanya", LastName = "Ivanova", Email = "vanyamanya@abv.bg", Password = "bvcbcvbcv"  },

            };

            return users;
        }
    }
}
