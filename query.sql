SELECT DISTINCT p.Name, c.Name
FROM Products p 
LEFT JOIN Products2Categories p2c ON p.Id = p2c.ProductId
LEFT JOIN Categories c ON c.Id = p2c.CategoryId