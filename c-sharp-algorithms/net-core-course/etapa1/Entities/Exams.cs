using System;

namespace CoreSchool.Entities
{
    public class Exams
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Signature Signature { get; set; }
        public float Score { get; set; }

        public Exams() => UniqueId = Guid.NewGuid().ToString(); 
        
    }
}