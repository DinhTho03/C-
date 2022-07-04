namespace on_tap
{
class Introduct
{
    public string title { set; get; }
    public string paragraphs { set; get; }


}

class Showintroduct2
{
    public List<Introduct> introducts2 { set; get; }

    public void showintroduct2()
    {
        foreach (var intro in introducts2)
        {
            Console.WriteLine(intro.title + intro.paragraphs);
        }

    }
}
}
