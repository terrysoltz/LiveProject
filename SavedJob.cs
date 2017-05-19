using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobBoardMVC.Models
{
    public class SavedJob
    {
        public int ID { get; set; }

        [Display(Name = "User ID")]
        public Guid UserID { get; set; }

        [Display(Name = "Application Link")]
        public string ApplicationLink { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyCompanyName { get; set; }

        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        public string Location { get; set; }

        [Display(Name = "Date Posted")]
        public string DatePosted { get; set; }

        [Display(Name = "Date Saved")]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime DateSaved { get; set; }

        public virtual Company Company { get; set; }
    }
}