using System;

namespace CoreSchool.Entities
{
    public class Signature
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public Signature() => UniqueId = Guid.NewGuid().ToString(); 
        
    }
}