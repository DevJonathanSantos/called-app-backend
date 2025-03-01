using System;
using System.Collections.Generic;

namespace ChamadosSetor8.Domain.Entities
{
    public class User : Entity
    {
        public User() { }

        public User(string name, string emailAddress, int profileId, int departmentId)
        {
            Name = name;
            EmailAddress = emailAddress;
            CreationDate = DateTime.Now;
            ProfileId = profileId;
            DepartmentId = departmentId;
            Churchs = new List<Church>();
        }

        public User(int id, string name, string emailAddress, int profileId, int departmentId) : base()
        {
            Name = name;
            EmailAddress = emailAddress;
            UpdateDate = DateTime.Now;
            ProfileId = profileId;
            DepartmentId = departmentId;
            Churchs = new List<Church>();
        }

        public string Name { get; private set; }
        public string EmailAddress { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public Department Department { get; private set; }
        public int DepartmentId { get; private set; }
        public Profile Profile { get; private set; }
        public int ProfileId { get; private set; }
        public List<Church> Churchs { get; private set; }

        public User AddChurchs(IList<Church> churchs)
        {
            Churchs.AddRange(churchs);

            return this;
        }
    }
}