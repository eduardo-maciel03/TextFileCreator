
namespace TextFileCreator
{
    public class GenericList<TYPE>
    {
        //This class creates a new list every time you call it, and you can pass it any type you like
        public GenericList() 
        {
            MyList = new List<TYPE>();
        }

        public List<TYPE> MyList { get; set; }
    }
}
