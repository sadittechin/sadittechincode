# sadittechin rattanaphong
683450194-7
# Training Registration System - Class Diagram

## Overview
ระบบลงทะเบียนอบรม ประกอบด้วย:
- นักศึกษา (Student)
- อาจารย์ (Teacher)
- บุคคลทั่วไป (Guest)
- วิทยากร (Trainer)

นักศึกษา, อาจารย์ และ บุคคลทั่วไป สามารถลงทะเบียนอบรมได้  
อาจารย์และบุคคลทั่วไป สามารถเป็นวิทยากรได้  

---

## UML Class Diagram

```mermaid
classDiagram

%% =====================
%% Interface
%% =====================
class IRegister {
    <<interface>>
    +RegisterCourse()
}

%% =====================
%% Abstract Class
%% =====================
class User {
    <<abstract>>
    -firstname : string
    -lastname : string
    -email : string
    -phone : string
    +SetUser(fname, lname, email, phone)
    +ShowInfo()
}

%% =====================
%% Student
%% =====================
class Student {
    -studentID : string
    -major : string
    +RegisterCourse()
    +ShowInfo()
}

%% =====================
%% Teacher
%% =====================
class Teacher {
    -major : string
    -academicPosition : string
    +RegisterCourse()
    +ShowInfo()
}

%% =====================
%% Guest
%% =====================
class Guest {
    -workplace : string
    -position : string
    +RegisterCourse()
    +ShowInfo()
}

%% =====================
%% Trainer
%% =====================
class Trainer {
    +ApproveTraining()
    +ShowTrainerInfo()
}

%% =====================
%% Relationships
%% =====================

User <|-- Student
User <|-- Teacher
User <|-- Guest
User <|-- Trainer

IRegister <|.. Student
IRegister <|.. Teacher
IRegister <|.. Guest

Teacher --> Trainer : can be
Guest --> Trainer : can be
