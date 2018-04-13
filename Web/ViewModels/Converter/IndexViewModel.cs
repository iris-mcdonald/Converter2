using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels.Converter
{
    public class IndexViewModel
    {
        
        [Range(0.00, 1000000.00,
            ErrorMessage = "Value must be between 0.00 and 1,000,000.00")]
        public double ViewConvertFrom { get; set; }

        [Range(0.00, 1000000.00,
                    ErrorMessage = "Value must be between 0.00 and 1,000,000.00")]
        public double ViewConvertTo { get; set; }

        public string ViewConvertSelect { get; set; }

        public IEnumerable<SelectListItem> ViewConversionTypes
        {
            get
            {
                return new[]
                {
                new SelectListItem { Value = "Temperature", Text = "Temperature" },
                new SelectListItem { Value = "Volume", Text = "Volume" },
                new SelectListItem { Value = "Weight", Text = "Weight" },
                };
            }
        }

        public string ViewConvertDirection { get; set; }

        public IEnumerable<SelectListItem> ViewConvertDirections
        {
            get
            {
                return new[]
                {
                new SelectListItem { Value = "LeftToRight", Text = "Left to Right" },
                new SelectListItem { Value = "RightToLeft", Text = "RightToLeft" },
                };
            }
        }

    }
}