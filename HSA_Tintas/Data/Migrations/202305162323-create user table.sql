--
-- File generated with SQLiteStudio v3.1.1 on ter mai 16 23:26:32 2023
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: User
CREATE TABLE User (
    Id      INTEGER PRIMARY KEY AUTOINCREMENT,
    Name    TEXT    NOT NULL ON CONFLICT ROLLBACK,
    IsAdmin BOOLEAN DEFAULT (0) 
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
