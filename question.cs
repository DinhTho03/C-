class Aquestion
{
    public string title { set; get; }
    public string paragraphs { set; get; }

}

class ShowAquestion
{
    public List<Aquestion> question { set; get; }

    public void Showde()
    {
        foreach (var de in question)
        {
            Console.WriteLine(de.title + de.paragraphs);
        }

    }
}