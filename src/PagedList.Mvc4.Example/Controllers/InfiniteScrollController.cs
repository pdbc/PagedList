﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PagedList.Mvc4.Example.Controllers
{
    public class InfiniteScrollController : BaseController
    {
		// Ajax Paging (Infinite)
		public ViewResult Index()
		{
			return View();
		}

		// Ajax Paging (cont'd)
		public ActionResult AjaxPage(int? page)
		{
			var listPaged = GetPagedNames(page); // GetPagedNames is found in BaseController
			if (listPaged == null)
				return HttpNotFound();

			return Json(new
			{
				names = listPaged.ToArray(),
				pager = listPaged.GetMetaData()
			}, JsonRequestBehavior.AllowGet);
		}
    }
}
