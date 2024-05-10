using SQLite;

namespace ExaminationApp.Models;

[Table("Exam")]
public class ExamRecord
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; }

    [MaxLength(250)]
    public string Title { get; set; }
    public ExamQuestions[] Questions { get; set; }

}