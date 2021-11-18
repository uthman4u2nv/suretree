using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace suretree.Services
{
    public interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        User GetById(int Id);
        int Insert(User u);
        List<User> list();

    }
}
