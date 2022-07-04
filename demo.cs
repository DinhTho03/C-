namespace on_tap
{
    class Demo
    {
        public string title { set; get; }
        public string paragraphs { set; get; }
        public string icon { set; get; }

    }

    class Showdemo
    {
        public List<Demo> demos { set; get; }

        public void showDemo()
        {
            foreach (var de in demos)
            {
                Console.WriteLine(de.icon + de.title + de.paragraphs);
            }

        }
    }
}