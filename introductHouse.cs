
    class Introducthouse
    {
        public string title { set; get; }
        public string paragraphs { set; get; }
        public string image { set; get; }
        public string price { set; get; }
        public string place { set; get; }


    }

    class Showintroduct
    {
        public List<Introducthouse> introducts { set; get; }

        public void showintroduct()
        {
            foreach (var intro in introducts)
            {
                Console.WriteLine(intro.image + intro.title + intro.paragraphs + intro.place + intro.price);
            }

        }
    }
