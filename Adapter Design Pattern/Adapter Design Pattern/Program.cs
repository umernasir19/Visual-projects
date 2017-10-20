using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern
{
    public interface MediaPlayer
    {
         void play(String audioType, String fileName);
    }
    public interface AdvancedMediaPlayer
    {
        void playVlc(String fileName);
         void playMp4(String fileName);
    }
    public class VlcPlayer : AdvancedMediaPlayer
    {

        public void playVlc(String fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }


        public void playMp4(String fileName)
        {
            //do nothing
        }
    public class Mp4Player: AdvancedMediaPlayer
    {

  
   public  void playVlc(String fileName)
   {
      //do nothing
   }

   
   public  void playMp4(String fileName)
            {
                Console.WriteLine("Playing mp4 file. Name: "+ fileName);		
            }
    
    }

        public class MediaAdapter: MediaPlayer {

   AdvancedMediaPlayer advancedMusicPlayer;

   public MediaAdapter(String audioType){
   
      if(audioType=="vlc")
      {
         advancedMusicPlayer = new VlcPlayer();			
         
      }
      else if (audioType=="mp4")
      {
         advancedMusicPlayer = new Mp4Player();
      }	
   }

   
   public void play(String audioType, String fileName) {
   
      if(audioType=="vlc")
      {
         advancedMusicPlayer.playVlc(fileName);
      }
      else if(audioType=="mp4")
      {
         advancedMusicPlayer.playMp4(fileName);
      }
   }
}

        public class AudioPlayer: MediaPlayer {
   MediaAdapter mediaAdapter; 

  
   public void play(String audioType, String fileName) {		

      //inbuilt support to play mp3 music files
      if(audioType=="mp3"){
         Console.WriteLine("Playing mp3 file. Name: " + fileName);			
      } 
      
      //mediaAdapter is providing support to play other file formats
      else if(audioType=="vlc" || audioType=="mp4"){
         mediaAdapter = new MediaAdapter(audioType);
         mediaAdapter.play(audioType, fileName);
      }
      
      else{
         Console.WriteLine("Invalid media. " + audioType + " format not supported");
      }
   }   
}





        class Program
        {
            static void Main(string[] args)
            {
                AudioPlayer audioPlayer = new AudioPlayer();

      audioPlayer.play("mp3", "beyond the horizon.mp3");
      audioPlayer.play("mp4", "alone.mp4");
      audioPlayer.play("vlc", "far far away.vlc");
      audioPlayer.play("avi", "mind me.avi");
            }
        }
    }
}
