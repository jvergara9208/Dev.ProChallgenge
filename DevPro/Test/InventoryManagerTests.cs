using System.Collections.Generic;
using Xunit;

/// <summary>
/// Task 2: Inventory Management
/// Test scenarios for the InventoryManager class.
/// Expected Output: Sorted list of products based on the specified sort key and order.
/// </summary>
public class InventoryManagerTests
{
    [Fact]
    public void SortProducts_ByPrice_Descending()
    {
        var products = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object> { { "name", "Product A" }, { "price", 100 }, { "stock", 5 } },
            new Dictionary<string, object> { { "name", "Product B" }, { "price", 200 }, { "stock", 3 } },
            new Dictionary<string, object> { { "name", "Product C" }, { "price", 50 }, { "stock", 10 } }
        };

        var sortedProducts = InventoryManager.SortProducts(products, "price", ascending: false);

        Assert.Equal(200, sortedProducts[0]["price"]);
        Assert.Equal(100, sortedProducts[1]["price"]);
        Assert.Equal(50, sortedProducts[2]["price"]);
    }

    [Fact]
    public void SortProducts_ByName_Ascending()
    {
        var products = new List<Dictionary<string, object>>
        {
            new Dictionary<string, object> { { "name", "Product A" }, { "price", 100 }, { "stock", 5 } },
            new Dictionary<string, object> { { "name", "Product B" }, { "price", 200 }, { "stock", 3 } },
            new Dictionary<string, object> { { "name", "Product C" }, { "price", 50 }, { "stock", 10 } }
        };

        var sortedProducts = InventoryManager.SortProducts(products, "name", ascending: true);

        Assert.Equal("Product A", sortedProducts[0]["name"]);
        Assert.Equal("Product B", sortedProducts[1]["name"]);
        Assert.Equal("Product C", sortedProducts[2]["name"]);
    }
}
