
-- Insert Quizzes

INSERT INTO public."Quizzes" ("Id", "QuizName") VALUES (12, 'Music');
INSERT INTO public."Quizzes" ("Id", "QuizName") VALUES (1, 'General Knowledge');
INSERT INTO public."Quizzes" ("Id", "QuizName") VALUES (2, 'Sports');

INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (30, 'In which year did Little Mix win The X Factor?', 12);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (5, 'What is the only sport to be played on the moon?', 2);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (3, 'What is the largest country in the world?', 1);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (38, 'Who won the English Premier League in the 2018-19 season?', 2);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (32, 'Won who the last cricket world cup?', 2);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (1, 'What is the capital of Wales?', 1);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (28, 'Which sport involves tucks and pikes?', 2);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (4, 'Which is the only vowel not used as the first letter in a US State?', 1);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (31, 'What was Frank Sinatra’s middle name?', 12);
INSERT INTO public."Questions" ("Id", "QuestionName", "QuizId") VALUES (29, 'What is the name of The Beatles’ first album?', 12);

INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (14, 'Football', 5, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (15, 'Tennis', 5, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (16, 'Rugby', 5, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (97, '2010', 30, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (98, '2011', 30, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (13, 'Golf', 5, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (99, '2012', 30, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (100, '2013', 30, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (109, 'Pakistan', 32, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (110, 'West Indies', 32, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (111, 'Australia', 32, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (112, 'England', 32, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (5, 'USA', 3, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (6, 'China', 3, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (7, 'Russia', 3, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (8, 'Canada', 3, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (114, 'Manchester City', 38, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (115, 'Liverpool', 38, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (116, 'Chelsea', 38, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (117, 'Manchester United', 38, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (1, 'Swansea', 1, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (2, 'Cardiff', 1, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (3, 'Cheltenham', 1, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (4, 'Newport', 1, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (89, 'Surfing', 28, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (90, 'Skiing', 28, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (91, 'Badminton', 28, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (92, 'Diving', 28, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (9, 'A', 4, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (10, 'E', 4, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (11, 'I', 4, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (12, 'O', 4, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (101, 'Albert', 31, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (102, 'Frank', 31, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (103, 'Desmond', 31, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (104, 'Charles', 31, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (93, 'With The Beatles', 29, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (94, 'Please Please Me ', 29, true);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (95, 'Love Me Do', 29, false);
INSERT INTO public."Answers" ("Id", "AnswerName", "QuestionId", "IsCorrect") VALUES (96, 'Beatles For Sale', 29, false);