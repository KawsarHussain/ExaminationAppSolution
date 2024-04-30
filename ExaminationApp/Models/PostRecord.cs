using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationApp.Models;

[SQLite.Table("Post")]
public class PostRecord
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; }

    [MaxLength(250)]
    public string Title { get; set; }
    public string Body {  get; set; }
    public PostType PostType {  get; set; }

    [ForeignKey(nameof(UserRecord))]
    public int userID { get; set;}
}
