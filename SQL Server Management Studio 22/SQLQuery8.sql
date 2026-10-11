USE university;

DROP TABLE IF EXISTS teacher;

CREATE TABLE teacher (
    tid INT IDENTITY(1,1) PRIMARY KEY,
    fname VARCHAR(250),
    gender VARCHAR(10),
    dob VARCHAR(250),
    mobile BIGINT,
    email VARCHAR(250),
    semester VARCHAR(250),
    prog VARCHAR(100),
    course VARCHAR(250),
    adrr VARCHAR(350)
);

INSERT INTO teacher (fname, gender, dob, mobile, email, semester, prog, course, adrr) VALUES
('Aymed Hossain', 'Male', '1983', 1222345689, 'aymedhossain@gmail.com', '39', 'CSE', 'OOP2', 'Dhaka'),
('Tamanna Zaman Bistry', 'Female', '1995', 12345678, 'tamannazaman@gmail.com', '7th', 'EEE', 'Math6', 'Dhaka,Norda'),
('Fahim Faysal', 'Male', '1994', 12345678, 'fahimfaysal@gmail.com', '6th', 'CSE', 'OOP2', 'Dhaka'),
('Topon Das', 'Male', '1994', 1234566678, 'topondas@gmail.com', '6th Sem', 'LAW', 'Business Communication', 'Rajshahi');

SELECT * FROM teacher;