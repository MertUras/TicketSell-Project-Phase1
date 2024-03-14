#nullable disable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DataAccess.Records.Bases;

namespace Business.Models
{
	public class RoleModel : Record

	{
        #region Entity Props 
        [Required(ErrorMessage ="{0}is required!")]
        [StringLength(20, MinimumLength =2,ErrorMessage ="{0} must be minimyum {2} and max {1}")]
        [DisplayName("Role Name")]
        public string Name { get; set; }
        #endregion

        #region Extra Props
        [DisplayName("Game Count")]
        public int GameCount { get; set; }

        [DisplayName("Game Names")]
        public string GameNamesOutput { get; set; }
        #endregion
    }
}

