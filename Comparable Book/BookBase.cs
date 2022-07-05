namespace IteratorsAndComparators
{
    public class BookBase
    {

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(this.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
                return result;
            }
        }
    }
}