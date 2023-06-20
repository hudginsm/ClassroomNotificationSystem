CREATE TABLE IF NOT EXISTS guardians(
        recordid INTEGER PRIMARY KEY AUTOINCREMENT,
        fname TEXT NOT NULL,
        lname TEXT NOT NULL,
        email TEXT
    );
CREATE TABLE IF NOT EXISTS students(
        recordid INTEGER PRIMARY KEY AUTOINCREMENT,
        fname TEXT NOT NULL,
        lname TEXT NOT NULL,
        email TEXT NOT NULL,
        grade INTEGER NOT NULL,
        period INTEGER NOT NULL,
        guardian1 INTEGER NOT NULL,
        guardian2 INTEGER,
        FOREIGN KEY(guardian1) REFERENCES guardians(recordid),
        FOREIGN KEY(guardian2) REFERENCES guardians(recordid)
    );
CREATE TABLE IF NOT EXISTS assignments(
        recordid INTEGER PRIMARY KEY AUTOINCREMENT,
        title TEXT NOT NULL,
        assigned TEXT NOT NULL,
        due TEXT NOT NULL
    );
CREATE TABLE IF NOT EXISTS grades(
        recordid INTEGER PRIMARY KEY AUTOINCREMENT,
        studentid INTEGER NOT NULL,
        assignmentid INTEGER NOT NULL,
        grade FLOAT NOT NULL,
        missing BOOLEAN NOT NULL,
        incomplete BOOLEAN NOT NULL,
        FOREIGN KEY(studentid) REFERENCES students(recordid),
        FOREIGN KEY(assignmentid) REFERENCES assignments(recordid),
    );