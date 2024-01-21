﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class GameViewModel
    {
        public Game Game { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GameCategoryList { get; set; }
    }
}
