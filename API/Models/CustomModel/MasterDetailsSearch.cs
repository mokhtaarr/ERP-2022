﻿using System;
using Inv.DAL.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Web;

 
namespace Inv.API.Models.CustomModel
{
    public class MasterDetailsSearch
    {
        public G_SearchFormModule module  { get; set; }
        public G_SearchForm settings  { get; set; }
        public List<G_SearchFormSetting> ColumnSetting { get; set; }
    }
}
