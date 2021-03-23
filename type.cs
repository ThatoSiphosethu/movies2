namespace MovieLibrary

{
    public abstract class Type
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public abstract string Display();   
    }



}