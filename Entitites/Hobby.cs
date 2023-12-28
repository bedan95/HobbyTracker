using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyTracker.Entities
{
    public class Hobby : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ColorHex { get; set; }
        public bool IsVisible { get; set; }
    }
}
