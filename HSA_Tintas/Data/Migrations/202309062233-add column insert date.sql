PRAGMA foreign_keys = 0;

CREATE TABLE sqlitestudio_temp_table AS SELECT *
                                          FROM Paint;

DROP TABLE Paint;

CREATE TABLE Paint (
    Id             INTEGER PRIMARY KEY AUTOINCREMENT
                           UNIQUE,
    Code           TEXT,
    Project        TEXT,
    Description    TEXT,
    CanQty         DOUBLE,
    Liters         DOUBLE,
    InsertionDate  DATE    DEFAULT (CURRENT_DATE),
    ExpirationDate DATE,
    Status         TEXT,
    Obs            TEXT
);

INSERT INTO Paint (
                      Id,
                      Code,
                      Project,
                      Description,
                      CanQty,
                      Liters,
                      ExpirationDate,
                      Status,
                      Obs
                  )
                  SELECT Id,
                         Code,
                         Project,
                         Description,
                         CanQty,
                         Liters,
                         ExpirationDate,
                         Status,
                         Obs
                    FROM sqlitestudio_temp_table;

DROP TABLE sqlitestudio_temp_table;

PRAGMA foreign_keys = 1;
