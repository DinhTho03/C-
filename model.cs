namespace on_tap
{
class Model
{
    public string title { set; get; }
    public string paragraphs { set; get; }
    public string content { set; get; }
    public string image { set; get; }
    public string icon { set; get; }

}

class showModel
{
    public List<Model> models { set; get; }

    public void showofModel()
    {
        foreach (var mo in models)
        {
            Console.WriteLine(mo.image + mo.title + mo.paragraphs + mo.icon + mo.content);
        }

    }
}
}