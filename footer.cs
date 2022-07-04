class footer
{
    public string title { set; get; }
    public string paragraphs { set; get; }


}

class Showfooter
{
    public List<footer> footers { set; get; }

    public void showFooter()
    {
        foreach (var ft in footers)
        {
            Console.WriteLine(ft.title + ft.paragraphs);
        }

    }
}