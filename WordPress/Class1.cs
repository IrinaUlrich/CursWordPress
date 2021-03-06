﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPress
{
    public class WordPressPage
    {
        public static int pageCount = 0;
        public static List<WordPressPage> pendingReview = new List<WordPressPage>();

        private int id;
        public string title = "Titlu frumos va fi frumos";
        private string content = "Girls are strong and independent";



        enum Status
        {
            Draft,
            Published,
            PendingReview
        }

        private Status _status;
        private Status pageStatus
        {
            get { return _status; }
            set { _status = value; }
        }

        private Boolean isVisible = true;
        private DateTime publishDate = DateTime.Now;
        private int parent;
        private int order = 332;
        private int viewCount = 87777676;



        public WordPressPage()
        {
            pageCount++;
            id = pageCount;
        }

        public WordPressPage(string title, string content)
        {
            this.title = title;
            this.content = content;
            pageCount++;
            id = pageCount;
        }

        public WordPressPage(string title, string content, int parent)
        {
            this.title = title;
            this.content = content;
            this.parent = parent;
            pageCount++;
            id = pageCount;
        }

        public bool isPublished
        {
            get { return pageStatus == Status.Published && publishDate <= DateTime.Now; }
        }


        public override string ToString()
        {

            return id.ToString() + "\n" + title + "\n" + content + "\nstatus: " + pageStatus + "\nvisible: " + isVisible + " " + publishDate + " " + parent + " " + order + " " + viewCount;

        }

        public void publish()
        {
            if (this.isPublished)
            {
                Console.WriteLine("from puvlish");
                throw new SystemException("Pagina a fost deja publicata");

            }
            pageStatus = Status.Published;
            publishDate = DateTime.Now;
        }

        public void statusPendingReview()
        {
            pageStatus = Status.PendingReview;
            pendingReview.Add(this);
        }

        public void publish(int hours)
        {
            publish();
            publishDate = publishDate.AddHours(hours);
        }

        public void publish(DateTime date)
        {
            publishDate = date;
        }

        public void setChild(WordPressPage page)
        {
            page.id = this.parent;
        }

        public void setParent(WordPressPage page)
        {
            this.parent = page.id;
        }

        public int getWordCount()
        {
            return content.Split(' ').Length;

        }



    }
}
