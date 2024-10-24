                               +----------------+
                               |     Program    |
                               +----------------+
                               | + Main()       |
                               +----------------+
                                     |
                                     | creates
                                     v
         +----------------+          +----------------+
         |     Order      |<---------|   Customer     |
         +----------------+          +--------------------+
         | - _customers    |         | - _name            |
         | - _products     |         | - _shippingAddress |
         +------------------------+  +------------------------+
         | + AddCustomer()        |  | + GetShippingAddress() |
         | + AddProduct()         |  | + LivesInUSA()         |
         | + CalculateTotalCost() |  +------------------------+
         | + PrintOrderDetails()  |    ^    
         +------------------------+    |
                                       |
                                       | contains
                                       |
                                       v
         +----------------+       +----------------+
         |    Address     |<------|    Product     |
         +----------------+       +----------------+
         | - _street      |       | - _name        |
         | - _city        |       | - _productId   |
         | - _state       |       | - _price       |
         | - _country     |       | - _quantity    |
         +--------------------+   +----------------+
         | + GetFullAddress() |   | + TotalCost()  |
         | + IsInUSA()        |   +----------------+
         +--------------------+
