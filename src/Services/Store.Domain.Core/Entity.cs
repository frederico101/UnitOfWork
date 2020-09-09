using System;

namespace DomainCore
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public Entity()
        {
           Id = new Guid();           
        }
    }
}