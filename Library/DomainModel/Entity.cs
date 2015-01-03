using System;

namespace Library.DomainModel

{
    public class Entity
    {
        private readonly Guid _identifier;

        public Entity()
        {
            _identifier = Guid.NewGuid();
        }

        public Guid Identifier
        {
            get { return _identifier; }
        }
    }
}