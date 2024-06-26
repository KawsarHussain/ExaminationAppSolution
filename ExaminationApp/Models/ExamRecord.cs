﻿using SQLite;

namespace ExaminationApp.Models;

[Table("Exam")]
public class ExamRecord
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; }

    [MaxLength(250)]
    [Unique]
    public string Title { get; set; }
    public ExamQuestions[] Questions { get; set; }

    public int TeacherID { get; set; }

}