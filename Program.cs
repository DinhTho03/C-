
using System;
using System.Collections;

namespace CS  {
     class Video {
        public  string nameVideo {set;get;}
        public  int stt {set;get;}
        public double time {set;get;}
        }

        class PlayList  {
        public string namePlaylist;
    
       
        }

    
  
    class program {
        
        
        static void Main(string [] agrs){

            List<Video> InfoVideo = new List<Video>(){
                new Video (){
                    nameVideo = "bai 1: co ban oop",
                    stt = 1,
                    time = 01.35
                },
                new Video (){
                    nameVideo = "bai 2: co ban html",
                    stt = 2,
                    time = 01.35
                },
                new Video (){
                    nameVideo = "bai 3: co ban oop 2",
                    stt = 3,
                    time = 01.35
                }
            } ;
            
            foreach(var p in InfoVideo)
            {
                Console.WriteLine($"video ({p.stt} ,{p.nameVideo} ,{p.time})");
            }


        }
    }
}
