class banner
    {
        public string? title { set; get; }
        public string? paragraphs { set; get; }
        public string? url { set; get; }
        public string? btn { set; get; }

    }
    
    
    class Contentofbanner
    {
        public List<banner>? content { set; get; }

        public void showcontent()
        {
            foreach (var item in content)
            {
                Console.WriteLine(item.title + item.paragraphs + item.btn + item.url);
            }
        }
    }