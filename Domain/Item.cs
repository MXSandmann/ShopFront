using System;
using System.Collections.Generic;

namespace Domain
{
    public class Item : BaseEntity
    {
        public Item(string name, string desciption, uint count)
        {
            Name = name;
            Desciption = desciption;
            Count = count;
        }

        private Item()
        {

        }

        public string Name { get; private set; }
        public string Desciption { get; private set; }
        public uint Count { get; private set; }

        public ICollection<User> Users { get; private set; }
    }
}
