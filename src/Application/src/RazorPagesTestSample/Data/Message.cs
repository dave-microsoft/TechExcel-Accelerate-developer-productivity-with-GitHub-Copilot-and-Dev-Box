using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        [Required]

        [StringLength(200, ErrorMessage = "There's a 200 character limit on messages. Please shorten your message.")]

        public string Text { get; set; }
    }
    #endregion
}
