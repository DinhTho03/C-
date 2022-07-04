namespace on_tap
{
    class Introducthouse2
    {
        public string title { set; get; }
        public string paragraphs { set; get; }
        public string image { set; get; }
        public string price { set; get; }
        public string place { set; get; }


    }

    class Showintroduct3
    {
        public List<Introducthouse2> introducts3 { set; get; }

        public void showintroduct()
        {
            foreach (var intro in introducts3)
            {
                Console.WriteLine(intro.image + intro.title + intro.paragraphs + intro.place + intro.price);
            }

        }
    }
}