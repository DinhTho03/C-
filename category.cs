class Category
    {
        public string? name { set; get; }

        public string? url { set; get; }
        public string? btn { set; get; }

        public Category() { }
        public Category(string name)
        {
            this.name = name;
        }

    }
   
   
    class showCategory
    {
        public List<Category> Categorys { set; get; }
        public void showCategorys()
        {
            foreach (var p in Categorys)
            {
                Console.Write(p.url + p.name + p.btn);
            };
        }
    }