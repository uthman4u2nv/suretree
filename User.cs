using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace suretree
{
    public class User : Services.IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        List<User> u = new List<User>();
        

        public User GetById(int Id)
        {
            return u.FirstOrDefault(m => m.Id == Id);
        }

        public int Insert(User u)
        {
            u.Id = 10;
            u.Name = "Ajagbe";
            u.Age = 100;
            u.DateOfBirth = DateTime.Now;
            
        }

        public List<User> list()
        {
            return u;
        }
    }
}
