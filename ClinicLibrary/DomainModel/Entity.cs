using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicLibrary.DomainModel

{
    public class Entity
    {
        public Entity()
        {
            Identifier = Guid.NewGuid();
        }

        [Key]
        public Guid Identifier
        {
            get;
            private set;
        }
    }
}