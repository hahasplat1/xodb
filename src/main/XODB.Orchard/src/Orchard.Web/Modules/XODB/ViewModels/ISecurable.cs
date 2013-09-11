﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace XODB.ViewModels
{
    public interface ISecurable
    {
        string ReferenceType { get; }
        Guid? ReferenceID { get; set; }
        IQueryable SecurityBlacklist { get; set; }
        IQueryable SecurityWhitelist { get; set; }

        SelectList Contacts { get; set; }
        SelectList Companies { get; set; }
        SelectList Roles { get; set; }
    }
}
