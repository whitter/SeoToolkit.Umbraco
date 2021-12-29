﻿using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;
using uSeoToolkit.Umbraco.Core.Collections;

namespace uSeoToolkit.Umbraco.Core.Controllers
{
    [PluginController("uSeoToolkit")]
    public class ModuleController : UmbracoAuthorizedApiController
    {
        private readonly ModuleCollection _moduleCollection;

        public ModuleController(ModuleCollection moduleCollection)
        {
            _moduleCollection = moduleCollection;
        }

        [HttpGet]
        public IActionResult GetModules()
        {
            return new JsonResult(_moduleCollection.GetAll());
        }
    }
}
