﻿CREATE TABLE Paint (
    Id             INTEGER PRIMARY KEY AUTOINCREMENT
                           UNIQUE,
    Code           TEXT,
    Project        TEXT,
    Description    TEXT,
    CanQty         DOUBLE,
    Liters         DOUBLE,
    ExpirationDate DATE,
    Status         TEXT,
    Obs            TEXT
);