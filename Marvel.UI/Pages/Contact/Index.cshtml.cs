using Marvel.DataAccess;
using Marvel.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Marvel.UI.Pages.Contact
{
    public class IndexModel : PageModel
    {
        readonly IDataAccess _dataaccess;
        
        [BindProperty]
        [Required]
        public ComplainDTO Complain { get; set; }

        public IndexModel(IDataAccess dataAccess)
        {
            _dataaccess = dataAccess;
        }

        public void OnPostInquiry()
        {
            _dataaccess.Save(Complain);
        }




    }
}
