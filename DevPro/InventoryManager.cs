using System.Collections.Generic;

/// <summary>
/// Task 2: Inventory Management
/// Function that takes a list of products and returns a sorted list based on a given sort key and order.
/// Example usage:
/// List<Dictionary<string, object>> products = ...
/// var sortedProducts = InventoryManager.SortProducts(products, "price", ascending: false);
/// Expected Output:
/// Sorted list of products based on the specified sort key and order.
/// </summary>
public static class InventoryManager
{
    public static List<Dictionary<string, object>> SortProducts(List<Dictionary<string, object>> products, string sortKey, bool ascending)
    {
        products.Sort((x, y) => 
        {
            int comparison = Comparer<object>.Default.Compare(x[sortKey], y[sortKey]);
            return ascending ? comparison : -comparison;
        });

        return products;
    }
}
