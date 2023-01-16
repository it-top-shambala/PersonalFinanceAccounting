USE WALLETSDB;
GO
CREATE TRIGGER tab_valuta_INSERT_UPDATE
ON tab_valuta
AFTER INSERT, UPDATE
AS
UPDATE tab_valuta
SET Id = Id + id
WHERE Id = (SELECT Id FROM inserted)


USE WALLETSDB;
GO
CREATE TRIGGER tab_category_refill_INSERT_UPDATE
ON tab_category_refill
AFTER INSERT, UPDATE
AS
UPDATE tab_category_refill
SET Id = Id + id
WHERE Id = (SELECT Id FROM inserted)

USE WALLETSDB;
GO
CREATE TRIGGER tab_category_expence_INSERT_UPDATE
ON tab_category_expence
AFTER INSERT, UPDATE
AS
UPDATE tab_category_expence
SET Id = Id + id
WHERE Id = (SELECT Id FROM inserted)



USE WALLETSDB;
GO
CREATE TRIGGER tab_wallets_INSERT_UPDATE
ON tab_wallets
AFTER INSERT, UPDATE
AS
UPDATE tab_wallets
SET Id = Id + id
WHERE Id = (SELECT Id FROM inserted)



USE WALLETSDB;
GO
CREATE TRIGGER tab_reffiling_INSERT_UPDATE
ON tab_reffiling
AFTER INSERT, UPDATE
AS
UPDATE tab_reffiling
SET Id = Id + id
WHERE Id = (SELECT Id FROM inserted)


USE productsdb
GO
CREATE TRIGGER tab_valuta_DELETE
ON tab_valuta
AFTER DELETE
AS
INSERT INTO History (Id)
SELECT Id
FROM DELETED


USE productsdb
GO
CREATE TRIGGER tab_category_refill_DELETE
ON tab_category_refill
AFTER DELETE
AS
INSERT INTO History (Id)
SELECT Id
FROM DELETED


USE productsdb
GO
CREATE TRIGGER tab_wallets_DELETE
ON tab_wallets
AFTER DELETE
AS
INSERT INTO History (Id)
SELECT Id
FROM DELETED


USE productsdb
GO
CREATE TRIGGERtab_reffiling_DELETE
ON tab_reffiling
AFTER DELETE
AS
INSERT INTO History (Id)
SELECT Id
FROM DELETED




