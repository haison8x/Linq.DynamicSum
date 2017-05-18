# Linq.DynamicSum

Extension to return sum value of list of objects

# DynamicSum

### Implement operator +

    public class SimpleObject
    {
        public SimpleObject()
        {
            Name = string.Empty;
            Quantity = 0;
            Price = 0;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public static SimpleObject operator +(SimpleObject object1, SimpleObject object2)
        {
            return new SimpleObject
            {
                Name = object1.Name,
                Quantity = object1.Quantity + object2.Quantity,
                Price = 0,
            };
        }
    }


### Usage:

    var sum = sequence.DynamicSum();

# CalculateSummaryEntity

### Usage
	SummaryEntity<SimpleObject> summary = sequence.CalculateSummaryEntity();