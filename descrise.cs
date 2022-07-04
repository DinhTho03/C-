class Descrise
{
    public string title { set; get; }
    public string paragraphs { set; get; }
    public string content { set; get; }
}

class Showdescrise
{
    public List<Descrise> descrises { set; get; }

    public void showDescrise()
    {
        foreach (var des in descrises)
        {
            Console.WriteLine(des.title + des.paragraphs + des.content);
        }

    }
}