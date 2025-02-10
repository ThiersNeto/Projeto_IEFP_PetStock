USE PetStock
GO

DELETE FROM [Category]
DELETE FROM [Client]
DELETE FROM [Product]
DELETE FROM [Sale]
DELETE FROM [SaleItem]
DELETE FROM [StockTransaction]
DELETE FROM [User]
DELETE FROM [UserRole]
GO

INSERT INTO [Category] ([Name]) VALUES
('Food'),
('Toys'),
('Furniture'),
('Treatment'),
('Clothing')
GO

INSERT INTO [Client] ([Name], [Email], [Phone], [Address], [RegistrationDate]) VALUES
('Laura', 'laura@hotmail.com', '999999999', 'PetStock Street 5', GETDATE()),
('Rodrigo', 'rodrigo@gmail.com', '999999999', 'PetStock Street 5', GETDATE()),
('Thers', 'thers@hotmail.com', '999999999', 'PetStock Street 5', GETDATE()),
('Joana', 'joana@hotmail.com', '999999999', 'PetStock Street 5', GETDATE()),
('José', 'jose@hotmail.com', '999999999', 'PetStock Street 5', GETDATE())
GO

INSERT INTO [UserRole] ([Name]) VALUES
('Admin'),
('Product Manager'),
('Stock Manager')
GO

INSERT INTO [User] ([Name], [Email], [Role], [PasswordHash], [RegistrationDate]) VALUES
('Laura', 'laura@hotmail.com', 1, HASHBYTES('SHA2_256', 'petstock'), GETDATE()),
('Rodrigo', 'rodrigo@gmail.com', 1, HASHBYTES('SHA2_256', 'petstock'), GETDATE()),
('Thers', 'thers@hotmail', 1, HASHBYTES('SHA2_256', 'petstock'), GETDATE()),
('Joana', 'joana@hotmail', 2, HASHBYTES('SHA2_256', 'petstock'), GETDATE()),
('José', 'jose@hotmail', 3, HASHBYTES('SHA2_256', 'petstock'), GETDATE())
GO

INSERT INTO [Product] ([Name], [Description], [CategoryId], [Price], [StockQuantity]) VALUES
('Dog Food 4kg', 'Food for your dog', 1, 10.99, 5),
('Dog Food 2kg', 'Food for your dog', 1, 4.99, 10),
('Dog Food 1kg', 'Food for your dog', 1, 2.99, 15),
('Dog Food 500g', 'Food for your dog', 1, 1.99, 20),
('Dog Snacks 200g', 'Snacks for your dog', 1, 1.59, 20),
('Dog Sticks 200g', 'Sticks for your dog', 1, 2.59, 20),
('Cat Food 2kg', 'Food for your cat', 1, 9.99, 5),
('Cat Food 1kg', 'Food for your cat', 1, 4.59, 10),
('Cat Food 500g', 'Food for your cat', 1, 2.59, 15),
('Cat Snacks 100g', 'Snacks for your cat', 1, 1.99, 20),
('Cat Sticks 100g', 'Sticks for your cat', 1, 2.99, 20),
('Fish Food 500g', 'Food for your fish', 1, 1.59, 20),
('Fish Food 250g', 'Food for your fish', 1, 0.89, 30),
('Dog Rubber Toy', 'A rubber toy for your dog', 2, 2.99, 15),
('Cat Cloth Toy', 'A cloth toy for your dog', 2, 1.99, 10),
('Aquarium 10L', 'An aquarium for your fish', 3, 19.99, 5),
('Aquarium 5L', 'An aquarium for your fish', 3, 10.99, 10),
('Aquarium Decorative Rocks', 'Decorative rocks for your aquarium', 3, 2.99, 15),
('Aquarium Decorative Tree', 'Decorative trees for your aquarium', 3, 3.99, 20),
('Dog Antiparasitic Pipette', 'An antiparasitic pipette for your dog', 4, 3.99, 15),
('Dog Antiparasitic Collar', 'An antiparasitic collar for your dog', 4, 2.99, 10),
('Dog Nail Clipper', 'A nail clipper for your dog', 4, 3.99, 25),
('Cat Antiparasitic Pipette', 'An antiparasitic pipette for your cat', 4, 3.99, 15),
('Cat Antiparasitic Collar', 'An antiparasitic collar for your cat', 4, 2.99, 10),
('Cat Nail Clipper', 'A nail clipper for your cat', 4, 3.99, 20),
('Fish Medicine', 'Medicine for your fish', 4, 2.99, 15),
('Dog Shirt', 'A shirt for your dog', 5, 3.99, 20),
('Dog Shoes', 'A pair of shoes for your dog', 5, 4.99, 10),
('Cat Shirt', 'A shirt for your cat', 5, 2.99, 5),
('Cat Shoes', 'A pair of shoes for your cat', 5, 4.99, 20)
GO