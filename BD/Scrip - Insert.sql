INSERT  INTO tbl_almacen (Almacen) VALUES
('Alm1'),
('Alm2'),
('Alm3');

INSERT INTO tbl_tipo_usuario (Nombre) VALUES
('Administrador'),
('Empleado');

INSERT INTO tbl_usuarios (Usuario, Contraseña, Nombre, Id_Tipo) VALUES
('Luis', '123', 'Luis Reyes', 1),
('Gerson', '321', 'Gerson Santos', 2);

INSERT INTO tbl_proveedores (Nombre, Telefono) VALUES
('Rayovac', '22456858'),
('Nescafe', '24894882'),
('Pepsi', '22458698'),
('Coca Cola', '55216485'),
('Colgate', '35689745'),
('Salvavidas', '22698978'),
('Cerveceria Gallo', '22467985'),
('Bremen', '22469828'),
('Toledo', '46857921'),
('Corona', '25468545');

INSERT INTO tbl_categoria (Categoria) VALUES
('Baterias'),
('Cafe'),
('Gaseosas'),
('Higiene Personal'),
('Agua Potable'),
('Alcohol'),
('Perecederos'),
('Embutidos');

INSERT INTO tbl_producto VALUES
(1001, 'Bateria Rayovac Alcalina AAA 6 Unidades', 'Baterias', 'Alm1'), -- 47.75 --
(1002, 'Bateria Alcalina Rayovac AA 2 Unidades', 'Baterias', 'Alm1'), -- 19.50 --
(1003, 'Bateria Rayovac Recargable AAA 2 Unidades', 'Baterias', 'Alm1'), -- 69.50 --
(1004, 'Cafe Clasico Instantanio Nescafe 300g', 'Cafe', 'Alm1'),  -- 59.95 --
(1005, 'Cafe Instantaneo Nescafé Clasico 200g', 'Cafe', 'Alm1'), -- 44.75 --
(1006, 'Cafe Instantaneo Sobre de 50g', 'Cafe', 'Alm1'), -- 12.85 --
(1007, '8 Pack Light Pepsi Black Lata - 355ml', 'Gaseosas', 'Alm1'), -- 20.00 --
(1008, 'Gaseosa Pepsi Envase 600ML', 'Gaseosas', 'Alm1'), -- 4.40 --
(1009, '2 pack Pepsi 6000ML', 'Gaseosas', 'Alm1'), -- 26.70 --
(1010, 'Pack Coca Cola Original y Sprite - 2L', 'Gaseosas', 'Alm1'), -- 19.85 --
(1011, 'Coca Cola Pet Sin Azucar 2.5L', 'Gaseosas', 'Alm1'), -- 12.90 -- 
(1012, '8 pack Bebida Gaseosa Mini Lata 237ML', 'Gaseosas', 'Alm1'),  -- 33.00 --
(1013, 'Pasta Dental Colgate Triple Accion 160ML', 'Higiene Personal', 'Alm1'), -- 21.75 --
(1014, 'Cepillo Dental Colgate Triple Accion 4 Pack', 'Higiene Personal', 'Alm1'), -- 33.20 --
(1015, 'Pasta Dental Colgate Total 12 Clean Mint 150ML', 'Higiene Persoanl', 'Alm1'), -- 47.00 --
(1016, 'Agua Pura Salvavidas Liquido 5 Galones', 'Agua Potable', 'Alm1'), -- 17.75 --
(1017, 'Agua Pura Salvavidas Galon', 'Agua Potable', 'Alm1'), -- 9.85 --
(1018, 'Agua Pura Salvavidas 8LT', 'Agua Potable', 'Alm1'), -- 22.50 --
(1019, 'Cerveza Gallo Lata Normal 15 Pack - 350ml', 'Alcohol', 'Alm1'), -- 97.00 --
(1020, '24 Pack Cerveza Gallo Botella - 355ml', 'Alcohol', 'Alm1'), -- 151 --
(1021, 'Cervesa Gallo En Botella 6 Pack - 355ml', 'Alcohol', 'Alm1'), -- 51.00 --
(1022, 'Salchicha Bremen 20 Unidades - 500gr', 'Embutidos', 'Alm1'), -- 14.75 --
(1023, 'Chorizo Bremen Precosido 12 Unidades - 454gr', 'Embutidos', 'Alm1'), -- 27.00 -- 
(1024, 'Salami Bremen - 227gr', 'Embutidos', 'Alm1'), -- 15.00 --
(1025, 'Salchicha Cocktail Toledo - 1Lb', 'Embutidos', 'Alm1'), -- 23.00 --
(1026, 'Salchicha HotDog Toledo - 460gr', 'Embutidos', 'Alm1'),
(1027, 'Pate Toledo 1.2 Libra', 'Embutidos', 'Alm1'), -- 11.35 --
(1028, '12 Pack Cerveza Corona Lata 355ml', 'Alcohol', 'Alm1'), -- 88.00 --
(1029, 'Cerveza Corona en Botella 6 Pack - 355ml', 'Alcohol', 'Alm1'), -- 55.00 --
(1030, 'Cerveza Coronita Extra Botella - 210ml', 'Alcohol', 'Alm1'); -- 5.50 --

INSERT INTO tbl_inventario VALUES
('2023-01-05', 1001, 'Bateria Rayovac Alcalina AAA 6 Unidades', 'Baterias', 'Alm1', 30, 25, 5), -- 47.75 --
('2023-01-07', 1002, 'Bateria Alcalina Rayovac AA 2 Unidades', 'Baterias', 'Alm1', 30, 15, 15), -- 19.50 --
('2023-01-10', 1003, 'Bateria Rayovac Recargable AAA 2 Unidades', 'Baterias', 'Alm1', 30, 20, 10), -- 69.50 --
('2023-01-11', 1004, 'Cafe Clasico Instantanio Nescafe 300g', 'Cafe', 'Alm1', 50, 13, 37),  -- 59.95 --
('2023-01-12', 1005, 'Cafe Instantaneo Nescafé Clasico 200g', 'Cafe', 'Alm1', 50, 7, 43), -- 44.75 --
('2023-01-23', 1006, 'Cafe Instantaneo Sobre de 50g', 'Cafe', 'Alm1', 50, 10, 40), -- 12.85 --
('2023-02-01', 1007, '8 Pack Light Pepsi Black Lata - 355ml', 'Gaseosas', 'Alm1', 25, 21, 4), -- 20.00 --
('2023-02-06', 1008, 'Gaseosa Pepsi Envase 600ML', 'Gaseosas', 'Alm1', 50, 17, 33), -- 4.40 --
('2023-02-12', 1009, '2 pack Pepsi 6000ML', 'Gaseosas', 'Alm1', 25, 13, 12), -- 26.70 --
('2023-02-16', 1010, 'Pack Coca Cola Original y Sprite - 2L', 'Gaseosas', 'Alm1', 20, 15, 5), -- 19.85 --
('2023-02-18', 1011, 'Coca Cola Pet Sin Azucar 2.5L', 'Gaseosas', 'Alm1', 50, 5, 45), -- 12.90 -- 
('2023-02-20', 1012, '8 pack Bebida Gaseosa Mini Lata 237ML', 'Gaseosa', 'Alm1', 20, 7, 13),  -- 33.00 --
('2023-03-05', 1013, 'Pasta Dental Colgate Triple Accion 160ML', 'Higiene Personal', 'Alm1', 25, 11, 14), -- 21.75 --
('2023-03-07', 1014, 'Cepillo Dental Colgate Triple Accion 4 Pack', 'Higiene Personal', 'Alm1', 20, 12, 8), -- 33.20 --
('2023-03-11', 1015, 'Pasta Dental Colgate Total 12 Clean Mint 150ML', 'Higiene Persoanl', 'Alm1', 20, 4, 16), -- 47.00 --
('2023-03-11', 1016, 'Agua Pura Salvavidas Liquido 5 Galones', 'Agua Potable', 'Alm1', 50, 5, 45), -- 17.75 --
('2023-03-20', 1017, 'Agua Pura Salvavidas Galon', 'Agua Potable', 'Alm1', 50, 29, 21), -- 9.85 --
('2023-03-21', 1018, 'Agua Pura Salvavidas 8LT', 'Agua Potable', 'Alm1', 25, 15, 10), -- 22.50 --
('2023-04-05', 1019, 'Cerveza Gallo Lata Normal 15 Pack - 350ml', 'Alcohol', 'Alm1', 20, 12, 8), -- 97.00 --
('2023-04-05', 1020, '24 Pack Cerveza Gallo Botella - 355ml', 'Alcohol', 'Alm1', 20, 13, 7), -- 151 --
('2023-04-15', 1021, 'Cervesa Gallo En Botella 6 Pack - 355ml', 'Alcohol', 'Alm1', 20, 5, 15), -- 51.00 --
('2023-04-16', 1022, 'Salchicha Bremen 20 Unidades - 500gr', 'Embutidos', 'Alm1', 30, 15, 15), -- 14.75 --
('2023-04-16', 1023, 'Chorizo Bremen Precosido 12 Unidades - 454gr', 'Embutidos', 'Alm1', 25, 8, 17), -- 27.00 -- 
('2023-04-19', 1024, 'Salami Bremen - 227gr', 'Embutidos', 'Alm1', 30, 10, 20), -- 15.00 --
('2023-05-01', 1025, 'Salchicha Cocktail Toledo - 1Lb', 'Embutidos', 'Alm1', 20, 7, 13), -- 23.00 --
('2023-05-01', 1026, 'Salchicha HotDog Toledo - 460gr', 'Embutidos', 'Alm1', 30, 17, 13),
('2023-05-02', 1027, 'Pate Toledo 1.2 Libra', 'Embutidos', 'Alm1', 30, 19, 11), -- 11.35 --
('2023-05-02', 1028, '12 Pack Cerveza Corona Lata 355ml', 'Alcohol', 'Alm1', 20, 10, 10), -- 88.00 --
('2023-05-03', 1029, 'Cerveza Corona en Botella 6 Pack - 355ml', 'Alcohol', 'Alm1', 20, 15, 5),
('2023-05-03', 1030, 'Cerveza Coronita Extra Botella - 210ml', 'Baterias', 'Alm1', 30, 15, 15); 

INSERT INTO tbl_entradas (Fecha, IdProveedores, Proveedores, IdProducto, Producto, Precio_Compra, Precio_Venta, Cantidad) VALUES
('2023-01-05', 1, 'Rayovac', 1001, 'Bateria Rayovac Alcalina AAA 6 Unidades', '30.50', '47.75', 30), -- 47.75 --
('2023-01-07', 1, 'Rayovac', 1002, 'Bateria Alcalina Rayovac AA 2 Unidades',  '11.50', '19.50', 30), -- 19.50 --
('2023-01-10', 1, 'Rayovac', 1003, 'Bateria Rayovac Recargable AAA 2 Unidades',  '55.50', '69.50', 30), -- 69.50 --
('2023-01-11', 2, 'Nescafe', 1004, 'Cafe Clasico Instantanio Nescafe 300g',  '45.90', '59.95', 50),  -- 59.95 --
('2023-01-12', 2, 'Nescafe', 1005, 'Cafe Instantaneo Nescafé Clasico 200g',  '35.50', '44.75', 50); -- 44.75 --

INSERT INTO tbl_entradas (Fecha, IdProveedores, Proveedores, IdProducto, Producto, Precio_Compra, Precio_Venta, Cantidad) VALUES
('2023-01-23', 2, 'Nescafe', 1006, 'Cafe Instantaneo Sobre de 50g',  '7.50', '12.85', 50), -- 12.85 --
('2023-02-01', 3, 'Pepsi', 1007, '8 Pack Light Pepsi Black Lata - 355ml',  '16.00', '20.00', 25), -- 20.00 --
('2023-02-06', 3, 'Pepsi', 1008, 'Gaseosa Pepsi Envase 600ML', '2.50', '4.40' , 50), -- 4.40 --
('2023-02-12', 3, 'Pepsi', 1009, '2 pack Pepsi 6000ML', '17.50', '26.70', 25), -- 26.70 --
('2023-02-16', 4, 'Coca Cola', 1010, 'Pack Coca Cola Original y Sprite - 2L',  '16.75', '19.85', 20); -- 19.85 --

INSERT INTO tbl_entradas (Fecha, IdProveedores, Proveedores, IdProducto, Producto, Precio_Compra, Precio_Venta, Cantidad) VALUES
('2023-02-18', 4, 'Coca Cola', 1011, 'Coca Cola Pet Sin Azucar 2.5L',  '8.90', '12.90', 50), -- 12.90 -- 
('2023-02-20', 4, 'Coca Cola', 1012, '8 pack Bebida Gaseosa Mini Lata 237ML',  '25.00', '33.00', 20),  -- 33.00 --
('2023-03-05', 5, 'Colgate', 1013, 'Pasta Dental Colgate Triple Accion 160ML',  '11.75', '21.75', 25), -- 21.75 --
('2023-03-07', 5, 'Colgate', 1014, 'Cepillo Dental Colgate Triple Accion 4 Pack',  '23.20', '33.20', 20), -- 33.20 --
('2023-03-11', 5, 'Colgate', 1015, 'Pasta Dental Colgate Total 12 Clean Mint 150ML',  '37.00', '47.00', 20); -- 47.00 --

INSERT INTO tbl_entradas (Fecha, IdProveedores, Proveedores, IdProducto, Producto, Precio_Compra, Precio_Venta, Cantidad) VALUES
('2023-03-11', 6, 'Salvavidas', 1016, 'Agua Pura Salvavidas Liquido 5 Galones',  '7.75', '17.75', 50), -- 17.75 --
('2023-03-20', 6, 'Salvavidas', 1017, 'Agua Pura Salvavidas Galon', '5.85', '9.85', 50), -- 9.85 --
('2023-03-21', 6, 'Salvavidas', 1018, 'Agua Pura Salvavidas 8LT',  '12.50', '22.50', 25), -- 22.50 --
('2023-04-05', 7, 'Cerveceria Gallo', 1019, 'Cerveza Gallo Lata Normal 15 Pack - 350ml', '87.00', '97.00', 20), -- 97.00 --
('2023-04-05', 7, 'Cerveceria Gallo', 1020, '24 Pack Cerveza Gallo Botella - 355ml', '141.00', '151.00', 20); -- 151 --

INSERT INTO tbl_entradas (Fecha, IdProveedores, Proveedores, IdProducto, Producto, Precio_Compra, Precio_Venta, Cantidad) VALUES
('2023-04-15', 7, 'Cerveceria Gallo', 1021, 'Cervesa Gallo En Botella 6 Pack - 355ml', '41.00', '51.00', 20), -- 51.00 --
('2023-04-16', 8, 'Bremen', 1022, 'Salchicha Bremen 20 Unidades - 500gr', '10.75', '14.75', 30), -- 14.75 --
('2023-04-16', 8, 'Bremen', 1023, 'Chorizo Bremen Precosido 12 Unidades - 454gr', '17.00', '27.00', 25), -- 27.00 -- 
('2023-04-19', 8, 'Bremen', 1024, 'Salami Bremen - 227gr', '10.00', '15.00', 30), -- 15.00 --
('2023-05-01', 9, 'Toledo', 1025, 'Salchicha Cocktail Toledo - 1Lb',  '17.50', '23.00', 20); -- 23.00 --

INSERT INTO tbl_entradas (Fecha, IdProveedores, Proveedores, IdProducto, Producto, Precio_Compra, Precio_Venta, Cantidad) VALUES
('2023-05-01', 9, 'Toledo', 1026, 'Salchicha HotDog Toledo - 460gr',  '12.00', '19.00', 30),
('2023-05-02', 9, 'Toledo', 1027, 'Pate Toledo 1.2 Libra', '7.35', '11.35', 30), -- 11.35 --
('2023-05-02', 10, 'Corona', 1028, '12 Pack Cerveza Corona Lata 355ml',  '75.00', '88.00', 20), -- 88.00 --
('2023-05-03', 10, 'Corona', 1029, 'Cerveza Corona en Botella 6 Pack - 355ml',  '45.00', '55.00', 20), -- 55.00 --
('2023-05-03', 10, 'Corona', 1030, 'Cerveza Coronita Extra Botella - 210ml',  '3.50', '5.50', 30); -- 5.50 --

INSERT INTO tbl_salidas (Fecha, IdAlmacen, Almacen, IdProducto, Descripcion, Cantidad) VALUES
('2023-01-05', 1, 'Alm1', 1001, 'Bateria Rayovac Alcalina AAA 6 Unidades', 25), -- 47.75 --
('2023-01-07', 1, 'Alm1', 1002, 'Bateria Alcalina Rayovac AA 2 Unidades', 15), -- 19.50 --
('2023-01-10', 1, 'Alm1', 1003, 'Bateria Rayovac Recargable AAA 2 Unidades', 20), -- 69.50 --
('2023-01-11', 1, 'Alm1', 1004, 'Cafe Clasico Instantanio Nescafe 300g', 13),  -- 59.95 --
('2023-01-12', 1, 'Alm1', 1005, 'Cafe Instantaneo Nescafé Clasico 200g', 7), -- 44.75 --
('2023-01-23', 1, 'Alm1', 1006, 'Cafe Instantaneo Sobre de 50g', 10), -- 12.85 --
('2023-02-01', 1, 'Alm1', 1007, '8 Pack Light Pepsi Black Lata - 355ml', 21), -- 20.00 --
('2023-02-06', 1, 'Alm1', 1008, 'Gaseosa Pepsi Envase 600ML', 17), -- 4.40 --
('2023-02-12', 1, 'Alm1', 1009, '2 pack Pepsi 6000ML', 13), -- 26.70 --
('2023-02-16', 1, 'Alm1', 1010, 'Pack Coca Cola Original y Sprite - 2L',  15), -- 19.85 --
('2023-02-18', 1, 'Alm1', 1011, 'Coca Cola Pet Sin Azucar 2.5L', 5), -- 12.90 -- 
('2023-02-20', 1, 'Alm1', 1012, '8 pack Bebida Gaseosa Mini Lata 237ML', 7),  -- 33.00 --
('2023-03-05', 1, 'Alm1', 1013, 'Pasta Dental Colgate Triple Accion 160ML', 11), -- 21.75 --
('2023-03-07', 1, 'Alm1', 1014, 'Cepillo Dental Colgate Triple Accion 4 Pack', 12), -- 33.20 --
('2023-03-11', 1, 'Alm1', 1015, 'Pasta Dental Colgate Total 12 Clean Mint 150ML', 4), -- 47.00 --
('2023-03-11', 1, 'Alm1', 1016, 'Agua Pura Salvavidas Liquido 5 Galones', 5), -- 17.75 --
('2023-03-20', 1, 'Alm1', 1017, 'Agua Pura Salvavidas Galon', 29), -- 9.85 --
('2023-03-21', 1, 'Alm1', 1018, 'Agua Pura Salvavidas 8LT', 15), -- 22.50 --
('2023-04-05', 1, 'Alm1', 1019, 'Cerveza Gallo Lata Normal 15 Pack - 350ml', 12), -- 97.00 --
('2023-04-05', 1, 'Alm1', 1020, '24 Pack Cerveza Gallo Botella - 355ml', 13), -- 151 --
('2023-04-15', 1, 'Alm1', 1021, 'Cervesa Gallo En Botella 6 Pack - 355ml', 5), -- 51.00 --
('2023-04-16', 1, 'Alm1', 1022, 'Salchicha Bremen 20 Unidades - 500gr', 15), -- 14.75 --
('2023-04-16', 1, 'Alm1', 1023, 'Chorizo Bremen Precosido 12 Unidades - 454gr', 8), -- 27.00 -- 
('2023-04-19', 1, 'Alm1', 1024, 'Salami Bremen - 227gr', 10), -- 15.00 --
('2023-05-01', 1, 'Alm1', 1025, 'Salchicha Cocktail Toledo - 1Lb', 7), -- 23.00 --
('2023-05-01', 1, 'Alm1', 1026, 'Salchicha HotDog Toledo - 460gr', 17),
('2023-05-02', 1, 'Alm1', 1027, 'Pate Toledo 1.2 Libra', 19), -- 11.35 --
('2023-05-02', 1, 'Alm1', 1028, '12 Pack Cerveza Corona Lata 355ml', 10), -- 88.00 --
('2023-05-03', 1, 'Alm1', 1029, 'Cerveza Corona en Botella 6 Pack - 355ml', 15), -- 55.00 --
('2023-05-03', 1, 'Alm1', 1030, 'Cerveza Coronita Extra Botella - 210ml', 13); -- 5.50 --

INSERT INTO tbl_productos_populares (Fecha, Codigo, Descripcion, Cantidad) VALUES 
('2023-01-05', 1001, 'Bateria Rayovac Alcalina AAA 6 Unidades', 25), -- 47.75 --
('2023-01-07', 1002, 'Bateria Alcalina Rayovac AA 2 Unidades', 15), -- 19.50 --
('2023-01-10', 1003, 'Bateria Rayovac Recargable AAA 2 Unidades', 20), -- 69.50 --
('2023-01-11', 1004, 'Cafe Clasico Instantanio Nescafe 300g', 13),  -- 59.95 --
('2023-01-12', 1005, 'Cafe Instantaneo Nescafé Clasico 200g', 7), -- 44.75 --
('2023-01-23', 1006, 'Cafe Instantaneo Sobre de 50g', 10), -- 12.85 --
('2023-02-01', 1007, '8 Pack Light Pepsi Black Lata - 355ml', 21), -- 20.00 --
('2023-02-06', 1008, 'Gaseosa Pepsi Envase 600ML', 17), -- 4.40 --
('2023-02-12', 1009, '2 pack Pepsi 6000ML', 13), -- 26.70 --
('2023-02-16', 1010, 'Pack Coca Cola Original y Sprite - 2L', 15), -- 19.85 --
('2023-02-18', 1011, 'Coca Cola Pet Sin Azucar 2.5L', 5), -- 12.90 -- 
('2023-02-20', 1012, '8 pack Bebida Gaseosa Mini Lata 237ML', 7),  -- 33.00 --
('2023-03-05', 1013, 'Pasta Dental Colgate Triple Accion 160ML', 11), -- 21.75 --
('2023-03-07', 1014, 'Cepillo Dental Colgate Triple Accion 4 Pack', 12), -- 33.20 --
('2023-03-11', 1015, 'Pasta Dental Colgate Total 12 Clean Mint 150ML', 4), -- 47.00 --
('2023-03-11', 1016, 'Agua Pura Salvavidas Liquido 5 Galones', 5), -- 17.75 --
('2023-03-20', 1017, 'Agua Pura Salvavidas Galon', 29), -- 9.85 --
('2023-03-21', 1018, 'Agua Pura Salvavidas 8LT', 15), -- 22.50 --
('2023-04-05', 1019, 'Cerveza Gallo Lata Normal 15 Pack - 350ml', 12), -- 97.00 --
('2023-04-05', 1020, '24 Pack Cerveza Gallo Botella - 355ml', 13), -- 151 --
('2023-04-15', 1021, 'Cervesa Gallo En Botella 6 Pack - 355ml', 5), -- 51.00 --
('2023-04-16', 1022, 'Salchicha Bremen 20 Unidades - 500gr', 15), -- 14.75 --
('2023-04-16', 1023, 'Chorizo Bremen Precosido 12 Unidades - 454gr', 8), -- 27.00 -- 
('2023-04-19', 1024, 'Salami Bremen - 227gr', 10), -- 15.00 --
('2023-05-01', 1025, 'Salchicha Cocktail Toledo - 1Lb', 7), -- 23.00 --
('2023-05-01', 1026, 'Salchicha HotDog Toledo - 460gr', 17),
('2023-05-02', 1027, 'Pate Toledo 1.2 Libra', 19), -- 11.35 --
('2023-05-02', 1028, '12 Pack Cerveza Corona Lata 355ml', 10), -- 88.00 --
('2023-05-03', 1029, 'Cerveza Corona en Botella 6 Pack - 355ml', 15), -- 55.00 --
('2023-05-03', 1030, 'Cerveza Coronita Extra Botella - 210ml', 15); -- 5.50 --

select Cantidad, Descripcion from tbl_productos_populares where Fecha between '2023-02-16' and '2023-04-19' order by Cantidad desc limit 5;

INSERT INTO tbl_ingresos (Fecha, Total) VALUES 
('2023-01-05', 86.25), -- 47.75 --
('2023-01-07', 40.00), -- 19.50 --
('2023-01-10', 70.00), -- 69.50 --
('2023-01-11', 70.25),  -- 59.95 --
('2023-01-12', 46.25), -- 44.75 --
('2023-01-23', 25.75), -- 12.85 --
('2023-02-01', 20.00), -- 20.00 --
('2023-02-06', 9.50), -- 4.40 --
('2023-02-12', 46.00), -- 26.70 --
('2023-02-16', 15.50), -- 19.85 --
('2023-02-18', 20.00), -- 12.90 -- 
('2023-02-20', 40.00),  -- 33.00 --
('2023-03-05', 50.00), -- 21.75 --
('2023-03-07', 50.00), -- 33.20 --
('2023-03-11', 50.00), -- 47.00 --
('2023-03-11', 50.00), -- 17.75 --
('2023-03-20', 20.00), -- 9.85 --
('2023-03-21', 50.00), -- 22.50 --
('2023-04-05', 50.00), -- 97.00 --
('2023-04-05', 50.00), -- 151 --
('2023-04-15', 50.00), -- 51.00 --
('2023-04-16', 20.00), -- 14.75 --
('2023-04-16', 50.00), -- 27.00 -- 
('2023-04-19', 25.00), -- 15.00 --
('2023-05-01', 27.50), -- 23.00 --
('2023-05-01', 35.00),
('2023-05-02', 20.00), -- 11.35 --
('2023-05-02', 65.00), -- 88.00 --
('2023-05-03', 50.00), -- 55.00 --
('2023-05-03', 10.00); -- 5.50 --

INSERT INTO tbl_bitacora_entradas (Fecha, Hora, Nombre) VALUES 
('2023-01-05', '08:05', 'Luis'), -- 47.75 --
('2023-01-07', '06:25', 'Luis'), -- 19.50 --
('2023-01-10', '11:35', 'Gerson'), -- 69.50 --
('2023-01-11', '08:05', 'Gerson'),  -- 59.95 --
('2023-01-12', '06:25', 'Luis'),-- 44.75 --
('2023-01-23', '11:35', 'Luis'), -- 12.85 --
('2023-02-01', '08:05', 'Gerson'), -- 20.00 --
('2023-02-06', '06:25', 'Gerson'), -- 4.40 --
('2023-02-12', '11:35', 'Luis'), -- 26.70 --
('2023-02-16', '08:05', 'Luis'), -- 19.85 --
('2023-02-18', '06:25', 'Gerson'), -- 12.90 -- 
('2023-02-20', '11:35', 'Gerson'),  -- 33.00 --
('2023-03-05', '08:05', 'Luis'), -- 21.75 --
('2023-03-07', '06:25', 'Luis'), -- 33.20 --
('2023-03-11', '11:35', 'Gerson'), -- 47.00 --
('2023-03-11', '08:05', 'Gerson'), -- 17.75 --
('2023-03-20', '06:25', 'Luis'), -- 9.85 --
('2023-03-21', '11:35', 'Luis'), -- 22.50 --
('2023-04-05', '08:05', 'Gerson'), -- 97.00 --
('2023-04-05', '06:25', 'Gerson'), -- 151 --
('2023-04-15', '11:35', 'Luis'), -- 51.00 --
('2023-04-16', '08:05', 'Luis'), -- 14.75 --
('2023-04-16', '06:25', 'Gerson'), -- 27.00 -- 
('2023-04-19', '11:35', 'Gerson'), -- 15.00 --
('2023-05-01', '08:05', 'Luis'), -- 23.00 --
('2023-05-01', '06:25', 'Luis'),
('2023-05-02', '11:35', 'Gerson'), -- 11.35 --
('2023-05-02', '08:05', 'Gerson'), -- 88.00 --
('2023-05-03', '06:25', 'Luis'), -- 55.00 --
('2023-05-03', '11:35', 'Luis'); -- 5.50 --

INSERT INTO tbl_bitacora_salidas (Fecha, Hora, Nombre) VALUES 
('2023-01-05', '09:05', 'Luis'), -- 47.75 --
('2023-01-07', '07:25', 'Luis'), -- 19.50 --
('2023-01-10', '12:35', 'Gerson'), -- 69.50 --
('2023-01-11', '09:05', 'Gerson'),  -- 59.95 --
('2023-01-12', '07:25', 'Luis'),-- 44.75 --
('2023-01-23', '12:35', 'Luis'), -- 12.85 --
('2023-02-01', '09:05', 'Gerson'), -- 20.00 --
('2023-02-06', '07:25', 'Gerson'), -- 4.40 --
('2023-02-12', '12:35', 'Luis'), -- 26.70 --
('2023-02-16', '09:05', 'Luis'), -- 19.85 --
('2023-02-18', '07:25', 'Gerson'), -- 12.90 -- 
('2023-02-20', '12:35', 'Gerson'),  -- 33.00 --
('2023-03-05', '09:05', 'Luis'), -- 21.75 --
('2023-03-07', '07:25', 'Luis'), -- 33.20 --
('2023-03-11', '12:35', 'Gerson'), -- 47.00 --
('2023-03-11', '09:05', 'Gerson'), -- 17.75 --
('2023-03-20', '07:25', 'Luis'), -- 9.85 --
('2023-03-21', '12:35', 'Luis'), -- 22.50 --
('2023-04-05', '09:05', 'Gerson'), -- 97.00 --
('2023-04-05', '07:25', 'Gerson'), -- 151 --
('2023-04-15', '12:35', 'Luis'), -- 51.00 --
('2023-04-16', '09:05', 'Luis'), -- 14.75 --
('2023-04-16', '07:25', 'Gerson'), -- 27.00 -- 
('2023-04-19', '12:35', 'Gerson'), -- 15.00 --
('2023-05-01', '09:05', 'Luis'), -- 23.00 --
('2023-05-01', '07:25', 'Luis'),
('2023-05-02', '12:35', 'Gerson'), -- 11.35 --
('2023-05-02', '09:05', 'Gerson'), -- 88.00 --
('2023-05-03', '07:25', 'Luis'), -- 55.00 --
('2023-05-03', '12:35', 'Luis'); -- 5.50 --

INSERT INTO tbl_bitacora_login VALUES 
('2023-01-05', '09:05', 'Luis', 'Login'), -- 47.75 --
('2023-01-05', '09:05', 'Luis', 'Sign Out'),
('2023-01-07', '07:25', 'Luis', 'Login'), -- 19.50 --
('2023-01-07', '07:25', 'Luis', 'Sign Out'),
('2023-01-10', '12:35', 'Gerson', 'Login'), -- 69.50 --
('2023-01-10', '12:35', 'Gerson', 'Sign Out'),
('2023-01-11', '09:05', 'Gerson', 'Login'),  -- 59.95 --
('2023-01-11', '09:05', 'Gerson', 'Sign Out'),
('2023-01-12', '07:25', 'Luis', 'Login'),-- 44.75 --
('2023-01-12', '07:25', 'Luis', 'Sign Out'),
('2023-01-23', '12:35', 'Luis', 'Login'), -- 12.85 --
('2023-01-23', '12:35', 'Luis', 'Sign Out'),
('2023-02-01', '09:05', 'Gerson', 'Login'), -- 20.00 --
('2023-02-01', '09:05', 'Gerson', 'Sign Out'),
('2023-02-06', '07:25', 'Gerson', 'Login'), -- 4.40 --
('2023-02-06', '07:25', 'Gerson', 'Sign Out'),
('2023-02-12', '12:35', 'Luis', 'Login'), -- 26.70 --
('2023-02-12', '12:35', 'Luis', 'Sign Out'),
('2023-02-16', '09:05', 'Luis', 'Login'), -- 19.85 --
('2023-02-16', '09:05', 'Luis', 'Sign Out'),
('2023-02-18', '07:25', 'Gerson', 'Login'), -- 12.90 -- 
('2023-02-18', '07:25', 'Gerson', 'Sign Out'),
('2023-02-20', '12:35', 'Gerson', 'Login'),  -- 33.00 --
('2023-02-20', '12:35', 'Gerson', 'Sign Out'),
('2023-03-05', '09:05', 'Luis', 'Login'), -- 21.75 --
('2023-03-05', '09:05', 'Luis', 'Sign Out'),
('2023-03-07', '07:25', 'Luis', 'Login'), -- 33.20 --
('2023-03-07', '07:25', 'Luis', 'Sign Out'),
('2023-03-11', '12:35', 'Gerson', 'Login'), -- 47.00 --
('2023-03-11', '12:35', 'Gerson', 'Sign Out'),
('2023-03-12', '09:05', 'Gerson', 'Login'), -- 17.75 --
('2023-03-12', '09:05', 'Gerson', 'Sign Out'),
('2023-03-20', '07:25', 'Luis', 'Login'), -- 9.85 --
('2023-03-20', '07:25', 'Luis', 'Sign Out'),
('2023-03-21', '12:35', 'Luis', 'Login'), -- 22.50 --
('2023-03-21', '12:35', 'Luis', 'Sign Out'),
('2023-04-05', '09:05', 'Gerson', 'Login'), -- 97.00 --
('2023-04-05', '09:05', 'Gerson', 'Sign Out'),
('2023-04-06', '07:25', 'Gerson', 'Login'), -- 151 --
('2023-04-06', '07:25', 'Gerson', 'Sign Out'),
('2023-04-15', '12:35', 'Luis', 'Login'), -- 51.00 --
('2023-04-15', '12:35', 'Luis', 'Sign Out'),
('2023-04-16', '09:05', 'Luis', 'Login'), -- 14.75 --
('2023-04-16', '09:05', 'Luis', 'Sing Out');
