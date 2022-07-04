namespace on_tap
{
    

class Proof
{
    public string title { set; get; }
    public string paragraphs { set; get; }
}

class ShowProof
{
    public List<Proof> proofs2 { set; get; }

    public void showProof()
    {
        foreach (var intro in proofs2)
        {
            Console.WriteLine(intro.title + intro.paragraphs);
        }

    }
}
}