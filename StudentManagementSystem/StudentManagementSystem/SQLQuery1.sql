-- 1. Users Table
CREATE TABLE Users (
    UserID INT IDENTITY PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL, -- 'Admin' or 'Teacher'
    CONSTRAINT CK_Role CHECK (Role IN ('Admin', 'Teacher'))
);

-- 2. Students Table
CREATE TABLE Students (
    StudentID INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255),
    EmergencyContact NVARCHAR(50),
    StudentType NVARCHAR(20) NOT NULL, -- FullTime, PartTime, Athlete
    CONSTRAINT CK_StudentType CHECK (StudentType IN ('FullTime', 'PartTime', 'Athlete'))
);

-- 3. Courses Table
CREATE TABLE Courses (
    CourseID INT IDENTITY PRIMARY KEY,
    CourseName NVARCHAR(100) NOT NULL UNIQUE
);

-- 4. Teachers Table
CREATE TABLE Teachers (
    TeacherID INT IDENTITY PRIMARY KEY,
    UserID INT NOT NULL UNIQUE,
    Name NVARCHAR(100) NOT NULL,
    CourseID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- 5. Enrollment Table (REQUIRED, not optional)
CREATE TABLE Enrollments (
    EnrollmentID INT IDENTITY PRIMARY KEY,
    StudentID INT NOT NULL,
    CourseID INT NOT NULL,
    TeacherID INT NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID),
    FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID),
    -- Ensure a student isn't enrolled in the same course twice
    CONSTRAINT UQ_StudentCourse UNIQUE (StudentID, CourseID)
);

-- 6. Grades Table
CREATE TABLE Grades (
    GradeID INT IDENTITY PRIMARY KEY,
    EnrollmentID INT NOT NULL,
    Grade NVARCHAR(5),
    FOREIGN KEY (EnrollmentID) REFERENCES Enrollments(EnrollmentID)
);

-- 7. Feedback Table
CREATE TABLE Feedback (
    FeedbackID INT IDENTITY PRIMARY KEY,
    EnrollmentID INT NOT NULL,
    Comment NVARCHAR(MAX),
    DateAdded DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (EnrollmentID) REFERENCES Enrollments(EnrollmentID)
);