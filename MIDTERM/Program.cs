public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Item is not available in stock");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Name of item : {ItemName}");
        Console.WriteLine($"Itemid is: {ItemId}");
        Console.WriteLine($"Price of item: {Price}");
        Console.WriteLine($"Quantity: {QuantityInStock}");

    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Detail of item 1");
        item1.PrintDetails();
        Console.WriteLine();

        Console.WriteLine("Detail of item 2");
        item2.PrintDetails();
        Console.WriteLine();
        // 2. Sell some items and then print the updated details.
        item1.SellItem(2);
        Console.WriteLine("After selling 2 item from item1 ");
        item1.PrintDetails();
        Console.WriteLine();
        // 3. Restock an item and print the updated details.
        item2.RestockItem(3);
        Console.WriteLine("After restocking 3items to item2");
        item2.PrintDetails();
        Console.WriteLine();
        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine($"Is item1 in  stock? {item1.IsInStock()}");
        Console.WriteLine($"Is item1 in  stock? {item2.IsInStock()}");



    }
}