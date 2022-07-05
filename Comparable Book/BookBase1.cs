namespace IteratorsAndComparators
{
    public class BookBase1
    {

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
                return result;
            }
        }
    }
}