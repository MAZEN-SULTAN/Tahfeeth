-- إنشاء قاعدة البيانات
CREATE DATABASE TahfeethDB;
GO

-- استخدام قاعدة البيانات التي أنشأناها
USE TahfeethDB;
GO



-- جدول المعلمين (لكل معلم اسم وراتب)
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY IDENTITY(1,1),     -- رقم تعريف فريد للمعلم
    FullName NVARCHAR(100) NOT NULL,             -- اسم المعلم الكامل
    Salary DECIMAL(10,2) NOT NULL ,              -- راتب المعلم الشهري
	PhoneNumber NVARCHAR(20) NOT NULL            --رقم تلفون المعلم 
);

-- جدول الحلقات (كل حلقة لها اسم ومعلم مرتبط بها)
CREATE TABLE Classes (
    ClassID INT PRIMARY KEY IDENTITY(1,1),     -- رقم تعريف فريد للحلقة
    ClassName NVARCHAR(100) NOT NULL,          -- اسم الحلقة
    TeacherID INT UNIQUE,                         -- رقم المعلم المرتبط بالحلفة (علاقة واحد لواحد)
	CONSTRAINT FK_Classes_Teachers FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
);

-- جدول الطلاب (كل طالب مرتبط بحلقة معينة)
CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),     -- رقم تعريف فريد للطالب
    FullName NVARCHAR(100) NOT NULL,             -- اسم الطالب
    BirthDate DATE,                                     -- تاريخ الميلاد
    JoinDate DATE NOT NULL,                      -- تاريخ الانضمام
	PhoneNumber NVARCHAR(20) NOT NULL,            --رقم تلفون الطالب 
    ClassID INT NOT NULL,                      -- رقم الحلقة التي ينتمي لها الطالب
    CONSTRAINT FK_Students_Classes FOREIGN KEY (ClassID) REFERENCES Classes(ClassID) -- علاقة الحلقة بالطالب
);

-- جدول تسجيل الحفظ والمراجعة
CREATE TABLE StudentProgress (
    ProgressID INT PRIMARY KEY IDENTITY(1,1),    -- رقم تعريف فريد للتقدم
    StudentID INT NOT NULL,                      -- الطالب المرتبط بالسجل
    RecordDate DATE NOT NULL,                    -- تاريخ التسجيل
    MemorizedFrom NVARCHAR(50),                  -- من آية...
    MemorizedTo NVARCHAR(50),                    -- إلى آية...
    ReviewedFrom NVARCHAR(50),                   -- مراجعة من...
    ReviewedTo NVARCHAR(50),                     -- مراجعة إلى...
    CONSTRAINT FK_Progress_Student FOREIGN KEY (StudentID) REFERENCES Students(StudentID) -- علاقة بالطالب
);

-- جدول الرواتب الشهرية
CREATE TABLE Salaries (
    SalaryID INT PRIMARY KEY IDENTITY(1,1),      -- رقم تعريف الراتب
    TeacherID INT NOT NULL,                      -- رقم المعلم
    Amount DECIMAL(10,2) NOT NULL,               -- المبلغ
    SalaryDate DATE NOT NULL,                    -- تاريخ صرف الراتب
    CONSTRAINT FK_Salaries_Teacher FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID) -- علاقة بالمعلم
);

-- جدول الدعم المالي للحلقات
CREATE TABLE FinancialSupports (
    SupportID INT PRIMARY KEY IDENTITY(1,1),     -- رقم تعريف الدعم
    ClassID INT NOT NULL,                      -- الحلقة المستفيدة
    Amount DECIMAL(10,2) NOT NULL,               -- مبلغ الدعم
    SupportDate DATE NOT NULL,                   -- تاريخ الدعم
    Source NVARCHAR(100),                        -- مصدر الدعم (متبرع - جهة داعمة ...)
    CONSTRAINT FK_Supports_Classes FOREIGN KEY (ClassID) REFERENCES Classes(ClassID) -- علاقة بالحلقات
);

-- جدول صندوق الحلقة (لتتبع الرصيد الشهري)
CREATE TABLE ClassFunds (
    FundID INT PRIMARY KEY IDENTITY(1,1),        -- رقم تعريف السجل
    ClassID INT NOT NULL,                      -- الحلقة المعنية
    MonthYear NVARCHAR(7) NOT NULL,              -- الشهر والسنة (مثال: 2025-05)
    TotalIncome DECIMAL(10,2) DEFAULT 0,         -- مجموع الدعم المادي
    TotalExpenses DECIMAL(10,2) DEFAULT 0,       -- مجموع الرواتب أو المصروفات
    Balance AS (TotalIncome - TotalExpenses),    -- الرصيد (محسوب تلقائياً)
    CONSTRAINT FK_Funds_Class FOREIGN KEY (ClassID) REFERENCES Classes(ClassID) -- علاقة بالحلقات
);