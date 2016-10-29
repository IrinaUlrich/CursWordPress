using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;


namespace WordPress.Test
{
    [TestFixture]

    public class UnitTests
    { 
        [Test]
        public void TestSort()
        {
            
            var nameList = new List<WordPressPage>();
            var nameListValidation = new List<WordPressPage>();

            WordPressPage pageTest1 = new WordPressPage("Titlu frumos1", "Girls are strong and independent1");
            WordPressPage pageTest2 = new WordPressPage("Titlu frumos2", "Girls are strong and independent1");
            WordPressPage pageTest3 = new WordPressPage("Titlu frumos3", "Girls are strong and independent1");

            nameList.Add(pageTest1);
            nameList.Add(pageTest3);
            nameList.Add(pageTest2);

            nameListValidation.Add(pageTest1);
            nameListValidation.Add(pageTest2);
            nameListValidation.Add(pageTest3);

            nameList = WordPressPage.SortByTitle(nameList);

            Assert.AreEqual(nameList, nameListValidation);

            Assert.AreEqual(nameList[0], pageTest1);
            Assert.AreEqual(nameList[1], pageTest2);
            Assert.AreEqual(nameList[2], pageTest3);

        }

        [Test]
        public void UniqueID()
        {
            WordPressPage page = new WordPressPage();
            WordPressPost post = new WordPressPost();
            WordPressPost post2 = new WordPressPost();


            Assert.AreEqual(page.id, 1);
            Assert.AreEqual(post.id, 1);
            Assert.AreEqual(post2.id, 2);


        }

        [Test]
        public void isPublished()
        {
            IPublish page = new WordPressPage();

            page.unpublish();

            Assert.False(page.isPublished);
        }


    }
}
