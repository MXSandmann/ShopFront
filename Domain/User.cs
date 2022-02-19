using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : BaseEntity
    {
        public User(string name)
        {
            Name = name;
        }

        private User()
        {

        }

        public string Name { get; private set; }
        public ICollection<Item> Items { get; private set; }
    }
}
