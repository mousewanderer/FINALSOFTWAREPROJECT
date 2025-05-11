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
 




version 1.3

![Screenshot 2025-05-03 001504](https://github.com/user-attachments/assets/668c17a6-ce7f-42ff-810e-c18cc9dd5b76)
![Screenshot 2025-05-03 001441](https://github.com/user-attachments/assets/c022f000-a99e-4fe8-ac29-d71c611c9af9)

![Screenshot 2025-05-03 001436](https://github.com/user-attachments/assets/86f47159-e72b-49ef-82a8-c2f3a245186b)

![Screenshot 2025-04-19 013521](https://github.com/user-attachments/assets/356f5a6a-3433-4ade-a990-911defb350e8)


![Screenshot 2025-05-03 001419](https://github.com/user-attachments/assets/b44681b1-0e20-4569-abd6-0a6a980d13be)
![Screenshot 2025-05-03 001407](https://github.com/user-attachments/assets/f946342f-695c-47bb-8e91-d0f3e2434de0)
![Screenshot 2025-05-03 001400](https://github.com/user-attachments/assets/fcd0cf38-3dbf-46e6-acae-621f50a4f490)
![Screenshot 2025-05-03 001355](https://github.com/user-attachments/assets/fcc628ca-bb81-42f5-933b-643342ce781a)
![Screenshot 2025-05-03 001349](https://github.com/user-attachments/assets/179682f8-0dc8-47ab-aa82-42cb57840499)
![Screenshot 2025-05-03 001530](https://github.com/user-attachments/assets/6e988770-7987-40e9-a9a5-963e968770ef)




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





