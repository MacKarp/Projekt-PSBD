-- Dodanie marki auta:
INSERT INTO [dbo].[Markas]
VALUES ('Mazda')

-- Update marki auta:
UPDATE [dbo].[Markas]
SET [NazwaMarka] = 'Subaru'
WHERE ([MarkaID] = 3)

-- Usuniecie marki auta:
DELETE [dbo].[Markas]
WHERE ([MarkaID] = 3)

-- Dodanie modelu auta:
INSERT INTO [dbo].[Models]
VALUES ('Mazda')

-- Update modelu auta:
UPDATE [dbo].[Models]
SET [NazwaModel] = '126p'
WHERE ([ModelID] = 3)

-- Usuniêcie modelu auta:
DELETE [dbo].[Models]
WHERE ([ModelID] = 4)

-- Dodanie nadwozia auta:
INSERT INTO [dbo].[RodzajNadwozias]
VALUES ('Sedan')

-- Update nadwozia auta:
UPDATE [dbo].[RodzajNadwozias]
SET [Nadwozie] = 'Coupe'
WHERE ([RodzajNadwoziaID] = 3)

-- Usuniêcie nadwozia auta:
DELETE [dbo].[RodzajNadwozias]
WHERE ([RodzajNadwoziaID] = 3)

-- Dodanie rodzaju paliwa:
INSERT INTO [dbo].[RodzajPaliwas]
VALUES ('Diesel')

-- Update rodzaju paliwa:
UPDATE [dbo].[RodzajPaliwas]
SET [Paliwo] = 'Hybryda'
WHERE ([RodzajPaliwaID] = 3)

-- Usuniêcie paliwa:
DELETE [dbo].[RodzajPaliwas]
WHERE ([RodzajPaliwaID] = 3)

-- Dodanie roku produkcji:
INSERT INTO [dbo].[RokProdukcjis]
VALUES (2000)

-- Update roku produkcji:
UPDATE [dbo].[RokProdukcjis]
SET [Rok] = 1999
WHERE ([RokProdukcjiID] = 3)

-- Usuniêcie roku produkcji:
DELETE [dbo].[RokProdukcjis]
WHERE ([RokProdukcjiID] = 3)

-- Dodanie pojemnosci silnika:
INSERT INTO [dbo].[PojemnoscSilnikas]
VALUES (2)

-- Update pojemmoœci silnika:
UPDATE [dbo].[PojemnoscSilnikas]
SET [Pojemnosc] = '1,2'
WHERE ([PojemoscSilnikaID] = 4)

-- Usuniêcie pojemnoœci silnika:
DELETE [dbo].[PojemnoscSilnikas]
WHERE ([PojemoscSilnikaID] = 4)

-- Dodanie koloru nadwozia:
INSERT INTO [dbo].[KolorNadwozias]
VALUES ('Niebieski')

-- Update koloru nadwozia:
UPDATE [dbo].[KolorNadwozias]
SET [Kolor] = 'Bia³y'
WHERE ([KolorNadwoziaID] = 3)

-- Usuniêcie koloru nadwozia:
DELETE [dbo].[KolorNadwozias]
WHERE ([KolorNadwoziaID] = 3)

-- Pobranie listy ofert:
SELECT 
    [AutoNaSprzedazID], 
    [TytulOferty], 
    [Przebieg], 
    [Moc], 
    [IloscMiejs], 
    [TypSkrzyniBiegow], 
    [Opis], 
    [Cena], 
    [Pic1], 
    [Pic2], 
    [Pic3], 
    [Pic4], 
    [KolorNadwozia_KolorNadwoziaID], 
    [Marka_MarkaID], 
    [Model_ModelID], 
    [PojemnoscSilnika_PojemoscSilnikaID], 
    [RodzajNadwozia_RodzajNadwoziaID], 
    [RodzajPaliwa_RodzajPaliwaID], 
    [RokProdukcji_RokProdukcjiID]
FROM [dbo].[AutoNaSprzedazs]

-- Dodanie oferty sprzeda¿y:
INSERT INTO [dbo].[AutoNaSprzedazs]([TytulOferty], [Przebieg], [Moc], [IloscMiejs], [TypSkrzyniBiegow], [Opis], [Cena], [Pic1], [Pic2], [Pic3], [Pic4], [KolorNadwozia_KolorNadwoziaID], [Marka_MarkaID], [Model_ModelID], [PojemnoscSilnika_PojemoscSilnikaID], [RodzajNadwozia_RodzajNadwoziaID], [RodzajPaliwa_RodzajPaliwaID], [RokProdukcji_RokProdukcjiID])
VALUES ('TytulOferty', 1234567890, 65, 3, 'Manual', 'Elo opis', 54321, 'C:\Users\Public\Documents\Komis Samochodowy - Janusz\img\637257407240750501.jpg', 'C:\Users\Public\Documents\Komis Samochodowy - Janusz\img\637257407240750501.jpg', 'C:\Users\Public\Documents\Komis Samochodowy - Janusz\img\637257407240750501.jpg', 'C:\Users\Public\Documents\Komis Samochodowy - Janusz\img\637257407240750501.jpg', 1, 1, 1, 2, 1, 1, 1)
	
-- Pobranie listy u¿ytkowników:
SELECT 
    [UzytkownikID], 
    [NazwaUzytkownia], 
    [HashHaslaUzytkownika], 
    [PoziomDostepuUzytkownika]
FROM [dbo].[Uzytkowniks]
	
-- Dodanie u¿ytkownika:
INSERT INTO [dbo].[Uzytkowniks]
VALUES ('Sprzedawca', '889C55911084DA2C4177BD991D67328757EC50F48E34166A227C208A5434094B216BBFC27A753408823B84254B2BF3F07A05B805018F371C056C96CDC8654297', 1)
	
-- Update u¿ytkownika (na przyk³adzie zmiany has³a):
UPDATE [dbo].[Uzytkowniks]
SET [HashHaslaUzytkownika] = '4DD2FD3D44E3B80DDB7E59152BB5219F8AB8A8C6F949B6A6A11650E89D7AD7853A48062CC45BF7D895813CD3AA6F34BC63D188652D0A87C9D05FEA825DD68D7B'
WHERE ([UzytkownikID] = 3)

-- Usuniêcie u¿ytkownika:
DELETE [dbo].[Uzytkowniks]
WHERE ([UzytkownikID] = 3)
