using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public  class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static List<Group> _modelGroup;

        static Group()
        {
            _modelGroup = new List<Group>();
        }
    }
}
