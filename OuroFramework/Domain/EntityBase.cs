using System;

namespace OuroFramework.Domain
{
    public class EntityBase<T>
    {
        public T Id { get; private set; }
        public DateTime CreationTime { get; private set; }
        
        public EntityBase()
        {
            CreationTime = DateTime.Now;
        }
    }
}
