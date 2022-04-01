using System.ComponentModel.DataAnnotations;

namespace FFXIVMacroGenerator.Models
{
    public class MACRO_URL_M
    {
        [Key]
        public int PK_NO { get; set; }
        public string Name { get; set; }
    }
}
