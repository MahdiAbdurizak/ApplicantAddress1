Create database Practical_Task3
Create table University
(
     UniversityID int Not Null primary key,
     UName nvarchar(50),
     City nvarchar(50)
     
)
Go

Create table Student
(
     StudentID int Not Null primary key,
     F_Name nvarchar(50),
	 L_Name nvarchar(50)
	
     
)
Go
Create table Specialty
(
     ID int Not Null primary key,
     Specialty_Num nvarchar(50),
	 Specialty_Name nvarchar(50)
	
     
)
Go

Create table Level_of_Study
(
     ID int Not Null primary key,
     Level_Sudy nvarchar(50)
	 
	
     
)
Go
Create table Enrollment
(
     StudentId int Not Null Unique ,
	 SpecialtyId int Not Null Unique ,
     spe_priority int
	 
	
     
)
Go

Create table StudentAddress
(
     StudentID int Not Null primary key,
	 Address1 nvarchar(50),
     Address2 nvarchar(50),
	 Address3 nvarchar(50),
	 Address4 nvarchar(50),
	 City nvarchar(50),
	 Stu_State nvarchar(50),
	 Area nvarchar(50),
	 
	
     
)
Go

Alter table Student  add UniversityID int
Alter table Specialty  add UniversityID int
Alter table Specialty  add LevelID int
Alter table Enrollment  add spe_priority int 

	
Go
Alter table Enrollment 
add constraint PK_Enrollment primary KEY (StudentId , SpecialtyId)
Go


/*To add a foreign key reference using a query*/
Alter table Student 
add constraint FK_Student_University FOREIGN KEY (UniversityID) references University(UniversityID) 
Go
Alter table StudentAddress 
add constraint FK_StudentAddress_Student FOREIGN KEY (StudentID) references Student(StudentID) 
Go
Alter table Enrollment 
add constraint FK_Enrollment_Student FOREIGN KEY (StudentId) references Student(StudentID) 
Go
Alter table Enrollment 
add constraint FK_Enrollment_Specialty FOREIGN KEY (SpecialtyId) references Specialty(ID) 
Go
Alter table Specialty 
add constraint FK_Specialty_University FOREIGN KEY (UniversityID) references University(UniversityID) 
Go

Alter table Specialty 
add constraint [FK_Specialty_Level _of _Study] FOREIGN KEY (LevelID) references Level_of_Study(ID) 
Go





/*To insert data*/

Insert into Level_of_Study values (1, 'высшее образование(ВО)')
Insert into Level_of_Study values (2, 'средне специальное образование (СПО)')
Insert into Level_of_Study values (3, 'Аспирантура')
Go

Insert into University values (1, 'Perm State Academy of Medicine', 'Perm')
Insert into University values (2, 'Perm State Pedagogical University', 'Perm')
Insert into University values (3, 'Perm State Technical University', 'Perm')
Insert into University values (4, 'Perm State University', 'Perm')
Insert into University values (5, 'the Great St.Peter University', 'Saint Petersburg')
Insert into University values (6, 'Petrozavodsk State Conservatory', 'Petrozavodsk')
Go

Insert into Student values (1, 'Max', 'Andrey',1)
Insert into Student values (2, 'Flat', 'Jhon',2)
Insert into Student values (3, 'Alex', 'Pitric',6)
Insert into Student values (4, 'Andrey', 'Dimitri',4)
Insert into Student values (5, 'Irina', 'Anton',3)
Insert into Student values (6, 'Rita', 'Andireva',2)
Go

Insert into Specialty values (1, '40.02.02', 'Правоохранительная',1,2)
Insert into Specialty values (2, '38.02.01', 'Экономика и бухгалтерский учет',2,2)
Insert into Specialty values (3, '54.02.01', 'Дизайн (по отраслям)',6,2)
Insert into Specialty values (4, '01.06.01', 'Математика и механика',4,3)
Insert into Specialty values (5, '05.06.01', 'Науки о Земле',3,3)
Insert into Specialty values (6, '09.03.03', 'Прикладная информатика',2,1)
Go

Insert into StudentAddress values (1, 'ул. Синяя', 'д.42','K5','кв. 12','г.Пермь','Пермский край',null)
Insert into StudentAddress values (2, 'ул. Красная', 'д.422','K6','кв. 121','г.Пермь','Пермский край',null)
Insert into StudentAddress values (3, 'ул.Пензенская', 'д.422','K6','кв. 121',' Г. ТАМБОВ','Тамбовская обл.',null)
Insert into StudentAddress values (4, 'ул. Кронштадтская', 'д.6/22','K6','кв. 121','Г. ТАМБОВ','Тамбовская обл.',null)
Insert into StudentAddress values (5, 'ул. Мичуринская', 'д.422','K6','кв. 121',' Г. ТАМБОВ','Тамбовская обл.',null)
Insert into StudentAddress values (6, 'ул. КАРЛА ', 'д.422','K6','кв. 121','г.Пермь','Пермский край',null)
Go

Insert into Enrollment values (1,1,2)
Insert into Enrollment values (1,2,1 )
Insert into Enrollment values (1,3,3)
Insert into Enrollment values (2,2,1)
Insert into Enrollment values (2,3,2)
Insert into Enrollment values (2,4,3)
Insert into Enrollment values (3,5,1)
Insert into Enrollment values (3,6,2)
Insert into Enrollment values (3,4,3)
Insert into Enrollment values (4,1,1)
Insert into Enrollment values (4,3,3)
Insert into Enrollment values (4,6,2)
Insert into Enrollment values (5,1,1)
Insert into Enrollment values (5,3,3)
Insert into Enrollment values (5,4,2)
Insert into Enrollment values (6,2,3)
Insert into Enrollment values (6,1,2)
Insert into Enrollment values (6,4,3)
Go



