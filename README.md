# Examination App Solution ReadMe

The application as of submission is not complete despite the time that was given for me to complete it.

I used an M-V-VM design pattern standing for Model-View-View Model which allows for the decoupling of processes, allowing for the decoupling of visuals and functionality 
All the script written is mine and I got help from tutorials such as:
- [Popup Tutorial](https://www.youtube.com/watch?v=yM7opXlu-MU&ab_channel=GeraldVersluis)
- [SQLite Implementation](https://learn.microsoft.com/en-us/training/modules/store-local-data/)
- [Data Binding](https://www.youtube.com/watch?v=5Qga2pniN78&list=PLdo4fOcmZ0oUBAdL2NwBpDs32zwGqb9DY&index=7&ab_channel=dotnet)

Despite me using tutorials to help me learn how to use .NET MAUI, I applied what I learnt in these tutorials to develop the application

As of now what I have completed is as follows:
- Created a Registration Page
- Created a Login System
- Link Data to local databases
  * Using SQL statements to insert and retrieve data from the various tables
- Created a dashboard with varying levels of functionality based on the user type
- Created an exam creation system which is currently not linked in to the main code but is viewable via
   * View Model - Presnt in ExaminationApp/ViewModel/ExamCreationViewModel & ExaminationApp/ViewModel/ExamFormViewModel
   * View - Present in ExaminationApp/ExamCreationPage & ExaminationApp/ExamFormPage

What has not been implemented are as follows:
- Doing an exam
- As a Student, enrolling in a class
  * As such, getting the information pertaining to those enrolled classes from the database
- The ability to do an Exam/Assessment as a student
- The ability to update your own details
- Linking it with a server using Docker
- The ability to submit files to the application
- The ability to mark exams as a Teacher


# How To Run
To run the application. Open the project in Visual Studio 2022, have the .NET MAUI package installed. Click the debug and run button to build the application and run it.
I did not have enough time to Populate the tables in the tables and thus when you run the application, the first thing you have to do is register yourself as a user and then login.
