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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_name"></param>
        public Group(string _name)
        {
            this.Id = Guid.NewGuid();
            this.Name = _name;
        }
    }
}
