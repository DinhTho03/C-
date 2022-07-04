class Section2 {
        public string title {set;get;}
        public string content {set;get;}
        public string btn {set;get;} 
        public string icon {set;get;}
    }

    class Constentofsection2 {
        public List<Section2> searchSection {set;get;}

        public void showsection2 (){
            foreach (var showsec in searchSection)
            {
                Console.WriteLine(showsec.title + showsec.content+showsec.icon +showsec.btn);
            }
        }

    }