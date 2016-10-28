using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPress
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WordPressPage page1 = new WordPressPage("Titlu frumos1", "Girls are strong and independent1");
            WordPressPage page2 = new WordPressPage("Titlu frumos2", "Girls are strong and independent1");
            WordPressPage page3 = new WordPressPage("Titlu frumos2", "Girls are strong and independent1");
            //           Console.WriteLine(page1);
            //           Console.WriteLine(page2);
            //           Console.WriteLine(page3);
            page3.title = "NewTitlu";
            //          Console.WriteLine(page3);
            page3.publish();
            //           Console.WriteLine(page3);
            page2.statusPendingReview();
            page3.statusPendingReview();
//            Console.WriteLine(page3);
//           foreach (WordPressPage p in WordPressPage.pendingReview)
//              System.Console.WriteLine(p);

            page2.publish(2);
            //          Console.WriteLine(page2);
            page3.publish(DateTime.Now.AddDays(2));
            //         Console.WriteLine(page3);



            WordPressPage page4 = new WordPressPage();

            Console.WriteLine(page2);
            Console.WriteLine(page3);
            page4.setChild(page2);

            page4.setParent(page3);

            Console.WriteLine(page2);
            Console.WriteLine(page3);
            Console.WriteLine(page4);


            Console.WriteLine(page3.getWordCount());
            page4.publish();
            try
            {
                page4.publish();
            }
            catch (Exception e)
            {
                    
               Console.WriteLine(e.Message);
            }
      //      page4.publish();

            Console.WriteLine(page4);
            Console.Read();



        }

    }
}
