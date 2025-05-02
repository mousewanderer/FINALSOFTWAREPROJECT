# FINAL SOFTWARE PROJECT


A gamified Student Learning Management System (LMS) with quiz-based learning for IT subjects.
Incorporates RPG elements like leveling up, badges, and achievements, making learning fun and engaging.

🧑‍🏫 Teacher = Admin
🎓 Student = Learner
✅ Students can view completed tasks, quizzes, and progress.

💡 Advanced features planned: 1v1 QuizBot battles and a ranking system!

# Objectives

- Login user page (login and create account) ------------- (DONE)
- LMS dashboard (student) (LVL, subject taken, scores from the previous quizzes and achievements) ------------- (On progress)
- Quizbot itself (Multiple choice and time bounded (count down system) and the multiple choice and questions swaps every time)



Advanced Features:
 1v1 QuizBot Mode
 Leaderboard / Global Ranking
 Teacher/Admin Panel
 Add/Edit Questions
 View Student Progress
 Manage Subjects

(Why did I loss my core alliance at senior high school ) 

Nugets I add
- CLOSEDXML for excel 
- SQLDATACLIENT for sql
 




version 1

![Screenshot 2025-04-19 013521](https://github.com/user-attachments/assets/356f5a6a-3433-4ade-a990-911defb350e8)
![Screenshot 2025-04-19 013515](https://github.com/user-attachments/assets/17a69eef-9d6c-4068-a8c3-5677a7dd86f6)

![Screenshot 2025-04-19 013526](https://github.com/user-attachments/assets/0cd32b0f-6005-4013-8c03-73c9fde11e01)

// SQL commands



USE Final_projectDB; 
 GO


 
DROP TABLE dbo.Students;
 

DROP TABLE dbo.Quizzes;


 
 CREATE TABLE Students ( 
 StudentID INT PRIMARY KEY, 
 FirstName VARCHAR(50), 
 LastName VARCHAR(50), 
 Age INT, 
 Gender VARCHAR(50),
 Program VARCHAR(50),
 Username VARCHAR(50), 
 KeyPassword VARCHAR(50)
 ); 
 GO
 



 --  FOR THE SCORES ---
 CREATE TABLE  Quizzes ( 
 StudentID INT PRIMARY KEY, 
 numquiz INT,           -- Number of quizzes
 Leveling INT,        -- LEVEL PLAYER
  Math1 INT,            -- SAMPLES
 Math2 INT, 
 InfoTech1 INT, 
 InfoTech2 INT,
 Biology1 INT, 
  Physics1 INT
 ); 



INSERT INTO Quizzes (StudentID, numquiz, Leveling, Math1, Math2, InfoTech1, InfoTech2, Biology1, Physics1)
VALUES 
(1, 5, 3, 12, 25, 14, 29, 11, 13),
(2, 4, 2, 9, 21, 13, 26, 8, 10),
(3, 6, 4, 15, 30, 15, 27, 13, 14),
(4, 5, 3, 10, 23, 12, 20, 9, 12),
(5, 3, 2, 7, 19, 8, 15, 6, 7),
(6, 7, 5, 14, 28, 15, 30, 13, 15),
(7, 4, 2, 8, 18, 10, 20, 7, 9),
(8, 3, 1, 5, 12, 6, 14, 5, 6),
(9, 5, 3, 11, 22, 13, 25, 10, 12),
(10, 6, 4, 13, 28, 14, 27, 12, 13),
(11, 4, 2, 9, 16, 8, 17, 6, 7),
(12, 5, 3, 10, 20, 12, 22, 9, 10),
(13, 6, 4, 14, 29, 15, 30, 13, 14),
(14, 3, 2, 7, 15, 9, 18, 7, 8),
(15, 4, 3, 10, 23, 11, 24, 9, 10),
(16, 5, 3, 12, 25, 13, 26, 10, 11),
(17, 2, 1, 6, 10, 5, 12, 4, 5),
(18, 3, 2, 8, 19, 9, 20, 7, 8),
(19, 5, 3, 11, 27, 12, 28, 10, 11),
(20, 4, 2, 9, 21, 10, 23, 8, 9),
(21, 6, 4, 13, 30, 15, 29, 12, 13),
(22, 3, 1, 5, 14, 6, 16, 5, 6),
(23, 4, 2, 8, 17, 9, 19, 7, 8),
(24, 5, 3, 12, 24, 13, 25, 11, 12),
(25, 2, 5, 13, 27, 14, 29, 12, 14);


 
INSERT INTO Students (StudentID, FirstName, LastName, Age, Gender, Program, Username, KeyPassword) 
VALUES 
(1, 'Gojo', 'Saturo', 28, 'Male', 'Tourism Management', 'Seniorlegend', 'Edp455Fan1'),
(2, 'Albert', 'Eintsein', 24, 'Male', 'Electrical Engineer', 'Imakethemcry', 'Tears100M2'),
(3, 'Erwin', 'Rommel', 24, 'Male', 'Mechanical Engineer', 'Desssertfox', 'HeilH1tl3r'),
(4, 'Lelouch', 'Lamperouge', 22, 'Male', 'Political Science', 'ZeroKnight', 'GeassP99ow'),
(6, 'Guts', 'Berserker', 27, 'Male', 'Psychology', 'StrugglerX', 'BrandSac9X'),
(7, 'Edward', 'Elric', 20, 'Male', 'Chemical Engineering', 'FullmetalAlch', 'AutoMail25x'),
(11, 'Sasuke', 'Uchiha', 25, 'Male', 'Computer Science', 'ShadowAvenger', 'RevengeC07x'),
(13, 'Light', 'Yagami', 24, 'Male', 'Law', 'JusticeKira', 'Shinigami1x'),
(14, 'Harry', 'Potter', 22, 'Male', 'Defense Studies', 'TheBoyWhoLived', 'Expell21Us'),
(15, 'Rick', 'Sanchez', 60, 'Male', 'Quantum Physics', 'WubbaLubba', 'PickleR42k'),
(16, 'Tony', 'Stark', 35, 'Male', 'Mechanical Engineering', 'IronMind', 'Ironman1Xx'),
(17, 'Sherlock', 'Holmes', 32, 'Male', 'Forensic Psychology', 'MindPalace', 'Element007a'),
(19, 'Peter', 'Parker', 21, 'Male', 'Multimedia Arts', 'WebSlinger', 'SpiderM9nX'),
(20, 'Marie', 'Curie', 26, 'Female', 'Chemistry', 'RadioactiveGal', 'Polonium88Y'),
(21, 'Bruce', 'Wayne', 34, 'Male', 'Criminology', 'DarkKnight', 'IamBatm4nX'),
(22, 'Diana', 'Prince', 29, 'Female', 'International Relations', 'WonderDiplomat', 'Last0Tru7h'),
(23, 'Indiana', 'Jones', 38, 'Male', 'History', 'IndyExplorer', 'Snakes102a'),
(24, 'Bon', 'Clay', 30, 'LGBTQA', 'Performing Arts', 'OkamaWay', 'SwanDance1A'),
-- Admin for easy debug
(25, 'Admin', 'windy', 20, 'Male', 'Quantum Physics', 'm', 'm');

GO


select * from Students





