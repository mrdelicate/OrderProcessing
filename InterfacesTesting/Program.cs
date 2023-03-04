
using OrderProcessing;

OrderProcessor orderProcessor = new(new ShippingCalculator());
var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
orderProcessor.Process(order);