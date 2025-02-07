USE PetStock
GO

INSERT INTO [Category] ([Name]) VALUES
('Food'),
('Toys'),
('Furniture'),
('Medicine'),
('Clothing')
INSERT INTO [Client] ([Name], [Email], [Phone], [Address], [RegistrationDate]) VALUES
('Laura', 'laura@hotmail.com', '999999999', 'PetStock Street 5', GETDATE()),
('Rodrigo', 'rodrigo@gmail.com', '999999999', 'PetStock Street 5', GETDATE()),
('Thers', 'thers@hotmail.com', '999999999', 'PetStock Street 5', GETDATE())
INSERT INTO [UserRole] ([Name]) VALUES
('Admin'),
('Product Manager'),
('Stock Manager')
INSERT INTO [User] ([Name], [Email], [Role], [PasswordHash], [RegistrationDate]) VALUES
('Laura', 'laura@hotmail.com', 0, HASHBYTES('SHA2_256', 'petstock'), GETDATE()),
('Rodrigo', 'rodrigo@gmail.com', 0, HASHBYTES('SHA2_256', 'petstock'), GETDATE()),
('Thers', 'thers@hotmail', 0, HASHBYTES('SHA2_256', 'petstock'), GETDATE())
INSERT INTO [Product] ([Name], [Description], [CategoryId], [Price], [StockQuantity]) VALUES
('Dog Food 4kg', 'Food for your dog', 0, 10.99, 5),
('Dog Food 2kg', 'Food for your dog', 0, 4.99, 10),
('Dog Food 1kg', 'Food for your dog', 0, 2.99, 15),
('Dog Food 500g', 'Food for your dog', 0, 1.99, 20),
('Cat Food 2kg', 'Food for your cat', 0, 9.99, 5),
('Cat Food 1kg', 'Food for your cat', 0, 4.59, 10),
('Cat Food 500g', 'Food for your cat', 0, 2.59, 15),
('Fish Food 500g', 'Food for your fish', 0, 1.59, 20),
('Fish Food 250g', 'Food for your fish', 0, 0.89, 30),
('Dog Rubber Toy', 'A rubber toy for your dog', 1, 2.99, 15),
('Cat Cloth Toy', 'A cloth toy for your dog', 1, 1.99, 10),
('Aquarium 10L', 'An aquarium for your fish', 2, 19.99, 5),
('Aquarium 5L', 'An aquarium for your fish', 2, 10.99, 10),
('Aquarium Decorative Rocks', 'Decorative Rocks for your aquarium', 2, 2.99, 15),
('Dog Antiparasitic Pipette', 'An antiparasitic pipette for your dog', 3, 3.99, 15),
('Dog Antiparasitic Collar', 'An antiparasitic collar for your dog', 3, 2.99, 10),
('Cat Antiparasitic Pipette', 'An antiparasitic pipette for your cat', 3, 3.99, 15),
('Cat Antiparasitic Collar', 'An antiparasitic collar for your cat', 3, 2.99, 10),
('Fish Medicine', 'Medicine for your fish', 3, 2.99, 15),
('Dog Shirt', 'A shirt for your dog', 4, 3.99, 20),
('Dog Shoes', 'A pair of shoes for your dog', 4, 5.99, 10),
('Cat Shirt', 'A shirt for your cat', 4, 2.99, 5)
GO