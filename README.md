# FINAL SOFTWARE PROJECT


A gamified Student Learning Management System (LMS) with quiz-based learning for IT subjects.
Incorporates RPG elements like leveling up, badges, and achievements, making learning fun and engaging.

🧑‍🏫 Teacher = Admin
🎓 Student = Learner
✅ Students can view completed tasks, quizzes, and progress.

💡 Advanced features planned: 1v1 QuizBot battles and a ranking system!

# Objectives

- Login user page (login and create account) ------------- (DONE) oh well
- LMS dashboard (student) (LVL, subject taken, scores from the previous quizzes and achievements) ------------- (On progress)
- Quizbot itself (Multiple choice and time bounded (count down system) and the multiple choice and questions swaps every time)



Advanced Features:
 1v1 QuizBot Mode
 Leaderboard / Global Ranking
 Teacher/Admin Panel
 Add/Edit Questions
 View Student Progress
 Manage Subjects


Nugets I add
- CLOSEDXML for excel 
- SQLDATACLIENT for sql
 




version 1.5

VIDEO FOR DEMONSTRATION
![https://github.com/user-attachments/assets/b72d7633-d898-46bd-bf12-5347bca607c3]






// SQL commands


```
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
-- 1. Gojo: all valid scores, Math1=12 (pass), Info1=14 (pass) → all unlocked
-- Quizzes taken: 6 → Leveling = 6
(1, 6, 6, 12, 25, 14, 29, 11, 13),

-- 2. Albert: all valid, Math1=9 (pass), Info1=13 (pass) → all unlocked
-- Quizzes taken: 6 → Leveling = 6
(2, 6, 6, 9, 21, 13, 26, 8, 10),

-- 3. Erwin: Math1=15 (pass), Info1=15 (pass)
-- Quizzes taken: 6 → Leveling = 6
(3, 6, 6, 15, 30, 15, 27, 13, 14),

-- 4. Lelouch: Math1=10 (pass), Info1=12 (pass)
-- Quizzes taken: 6 → Leveling = 6
(4, 6, 6, 10, 23, 12, 20, 9, 12),

-- 5. Guts: Biology1 = 6 (taken) → all other topics set to -1
-- Quizzes taken: 1 → Leveling = 1
(5, 1, 1, -1, -1, -1, -1, 6, -1),
(6, 1, 1, -1, -1, -1, -1, -1, -1);

 
INSERT INTO Students (StudentID, FirstName, LastName, Age, Gender, Program, Username, KeyPassword) 
VALUES 
(1, 'Gojo', 'Saturo', 28, 'Male', 'Tourism Management', 'Seniorlegend', 'Edp455Fan1'),
(2, 'Albert', 'Eintsein', 24, 'Male', 'Electrical Engineer', 'Imakethemcry', 'Tears100M2'),
(3, 'Erwin', 'Rommel', 24, 'Male', 'Mechanical Engineer', 'Desssertfox', 'HeilH1tl3r'),
(4, 'Lelouch', 'Lamperouge', 22, 'Male', 'Political Science', 'ZeroKnight', 'GeassP99ow'),
(5, 'Guts', 'Berserker', 27, 'Male', 'Psychology', 'StrugglerX', 'BrandSac9X'), 
(6, 'ADMIN', 'FIXER', 27, 'Male', 'Electrical Engineer', 'm', 'm'); 



GO


select * from Students


```





