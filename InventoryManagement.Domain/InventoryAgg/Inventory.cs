using OuroFramework.Domain;
using System;
using System.Collections.Generic;

namespace InventoryManagement.Domain.InventoryAgg
{
    public class Inventory : EntityBase<int>
    {
        public int ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; private set; }
        public List<InventoryOperation> Operations { get; private set; }
    }
    public class InventoryOperation
    {
        public int Id { get; private set; }
        public bool Operation { get; private set; }
        public int Count { get; private set; }
        public int CurrentCount { get; private set; }
        public string Description { get; private set; }
        public DateTime OperationTime { get; private set; }
        public int OperatorId { get; private set; }
        public int OrderId { get; private set; }
        public int InventoryId { get; private set; }
    }
}
