using System.ComponentModel.DataAnnotations;

namespace SpookifyApi.Models;

public class SongModel
{
    public int SongID { get; set; }
    [Required]
    [StringLength(150)]
    public string Name { get; set; }
    [Required]
    [StringLength(150)]
    public string Artist { get; set; }
    [Required]
    [StringLength(150)]
    public string Album { get; set; }
    [Required]
    [StringLength(150)]
    /*
    * Regex matching:
    * - lowercase and uppercase English letters
    * - numbers
    * - '_' I know you dont like this Tase, but we need it =)
    * - '-'
    * - must end in '.mp3'
    * This can be modified
   */
/*    [RegularExpression(@"^[a-zA-Z\d\-]+\.mp3$")]*/
    public string Filename { get; set; }

    // Name - will be displayed in the app
    // Filename - the actual name of the file that will be uploaded from one's computer
}
