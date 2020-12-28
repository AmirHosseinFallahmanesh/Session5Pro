namespace Demo.Dal
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //public string _url;
        //public string _Url;
        //public string m_Url;
        //public string M_Url;
        public string backf;
       
        public string Url
        { 
            get { 
                return backf;
            } 
            set 
            {
                CallSomeThing();
                backf = value; 
            } 
        }
        void CallSomeThing()
        {
        }
            public Blog Blog { get; set; }
    }

}
