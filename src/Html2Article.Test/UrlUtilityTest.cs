using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StanSoft;
using NUnit.Framework;

namespace Html2Article.Test
{
    [TestFixture]
    public class UrlUtilityTest
    {
        [Test]
        public void FixUrl()
        {
            string baseUrl = "http://www.stan.com";
            string html = "<a href='http://www.a.com/a.html'></a>\r\n<img src='new.jpg' />info";
            string result = UrlUtility.FixUrl(baseUrl, html);

            Assert.AreEqual("<a href='http://www.a.com/a.html'></a>\r\n<img src=\"http://www.stan.com/new.jpg\" />info",
                result);
        }
    }
}
