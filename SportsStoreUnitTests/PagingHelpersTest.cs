using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Web.Mvc;
using SportsStore.WebUI.Models;

namespace SportsStoreUnitTests
{
    [TestFixture]
    public class PagingHelpersTest
    {
        //[Test]
        //public void Can_Generate_Page_Links()
        //{
        //    // define a HTML helper
        //    HtmlHelper myHelper = null;

        //    // create paging info
        //    PagingInfo pagingInfo = new PagingInfo
        //    {
        //        CurrentPage = 2,
        //        TotalItems = 28,
        //        ItemsPerPage = 10
        //    };

        //    Func<int, string> pageUrlDelegate = i => "Page" + 1;

        //    MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);
        //    //MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);

        //    Assert.AreEqual(result.ToString(), @"<a href = ""Page1""></a><a class =""selected""href=""Page2"">2</a><a href =""Page3"">3</a>");
        //}
    }
}
