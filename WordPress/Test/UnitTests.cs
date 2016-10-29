﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace WordPress.Test
{
    [TestFixture]
    public class test
    {
        [Test]
        public void TestSort()
        {
            var myList = new List<WordPressPage>();
            var myList2 = new List<WordPressPage>();

            WordPressPage pag1 = new WordPressPage("Titlu frumos1", "Girls are strong and independent1");
            WordPressPage pag2 = new WordPressPage("Titlu frumos2", "Girls are strong and independent2");
            WordPressPage pag3 = new WordPressPage("Titlu frumos3", "Girls are strong and independent3");
            WordPressPage pag4 = new WordPressPage("Titlu frumos4", "Girls are strong and independent4");


            myList.Add(pag1);
            myList.Add(pag4);
            myList.Add(pag3);
            myList.Add(pag2);

            myList2.Add(pag1);
            myList2.Add(pag2);
            myList2.Add(pag3);
            myList2.Add(pag4);

            var results = new List<WordPressPage>();

            results = WordPressPage.SortByTitle(myList);


            Assert.AreEqual(results[0], pag1);
            Assert.AreEqual(results[1], pag2);
            Assert.AreEqual(results[2], pag3);
            Assert.AreEqual(results[3], pag4);


            Assert.AreEqual(results, myList2);



        }
    }
}