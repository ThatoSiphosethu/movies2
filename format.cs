namespace MovieLibrary

{
    public abstract class Type
    {
        public string movieId { get; set; }
        
        public string movieTitle { get; set; }

        public abstract string Display();   
    }

    public class MovieGroup : Type
    {
        public override string Display()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Shows : Type
    {
        public int Season { get; set; }
        
        public int Episode { get; set; }
        
        public string[] Writers { get; set; }

         public override string Display()
        {
            throw new System.NotImplementedException();
        } 
    }

    public class Video : Type
    {
        public string format { get; set; }
        
        public int Length { get; set; }
        
        public int[] Regions { get; set; }
        
         public override string Display()
        {
            throw new System.NotImplementedException();
        }   
    }
}