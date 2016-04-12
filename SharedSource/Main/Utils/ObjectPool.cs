namespace HarryPotter.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ObjectPool<T>
    {
        private readonly List<T> objectPool = new List<T>();
        private readonly Predicate<T> availablePredicate; 

        public ObjectPool(Predicate<T> availablePredicate)
        {
            this.availablePredicate = availablePredicate;
        }

        public IEnumerable<T> AvailableObjects => this.objectPool.Where(o => this.availablePredicate(o));

        public List<T> Objects => this.objectPool;

        public bool IsFull => !this.AvailableObjects.Any();
    }
}