using System.ComponentModel.DataAnnotations;

namespace FFXIVMacroGenerator.Models
{
    public class MACRO_URL_D
    {
        [Key]
        public int PK_NO { get; set; }
        public string MASTER_PK_NO { get; set; }
        public string ROUTER  { get; set; }
        public string JSON_DATA { get; set; }
    }
}
