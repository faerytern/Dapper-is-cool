# ConsoleApp2
From https://www.learndapper.com/

What does Dapper actually do? 
Here is some standard ADO.NET code for retrieving data from a database and materialising it as a collection of Product objects:
```c#
var sql = "select * from products";
var products = new List<Product>();
using (var connection = new SqlConnection(connString))
{
    connection.Open();
    using (var command = new SqlCommand(sql, connection))
    {
        using (var reader = command.ExecuteReader())
        {
            var product = new Product
            {
                ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                SupplierId = reader.GetInt32(reader.GetOrdinal("SupplierId")),
                CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")),
                QuantityPerUnit = reader.GetString(reader.GetOrdinal("QuantityPerUnit")),
                UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                UnitsInStock = reader.GetInt16(reader.GetOrdinal("UnitsInStock")),
                UnitsOnOrder = reader.GetInt16(reader.GetOrdinal("UnitsOnOrder")),
                ReorderLevel = reader.GetInt16(reader.GetOrdinal("ReorderLevel")),
                Discontinued = reader.GetBoolean(reader.GetOrdinal("Discontinued")),
                DiscontinuedDate = reader.GetDateTime(reader.GetOrdinal("DiscontinuedDate"))
            };
            products.Add(product);
        }
    }
}
```
At its most basic level, Dapper replaces the highlighted block of assignment code in the example above with the following:
```c#
products = connection.Query<Product>(sql);
``` 
Dapper also takes care of creating the command and opening the connection if needed. If all you ever use Dapper for is for managing basic assignment like this, it will save you hours of time. In fact, Dapper is capable of doing quite a bit more.
