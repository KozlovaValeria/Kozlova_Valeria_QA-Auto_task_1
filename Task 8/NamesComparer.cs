using Task_5;

namespace Task_8
{
    public class NamesComparer : IComparer<UniversityEmployee>
    {
        public bool IsReversed { get; set; }
        public NamesComparer(bool isReversed) 
        {
            IsReversed = isReversed;
        }  
        public int Compare(UniversityEmployee? x, UniversityEmployee? y)
        {
            if(IsReversed)
            {
                return (y.Person.FirstName.Length + y.Person.LastName.Length).CompareTo(x.Person.FirstName.Length + x.Person.LastName.Length);
            }
            return (x.Person.FirstName.Length + x.Person.LastName.Length).CompareTo(y.Person.FirstName.Length + y.Person.LastName.Length);         
        }
    }
}
