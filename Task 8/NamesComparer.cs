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
        public int Compare(UniversityEmployee? leftItem, UniversityEmployee? rightItem)
        {
            if(leftItem == null || rightItem == null)
            {
                throw new ArgumentNullException();
            }

            if(IsReversed)
            {
                return rightItem.Person.FullNameLength().CompareTo(leftItem.Person.FullNameLength());
            }
            return leftItem.Person.FullNameLength().CompareTo(rightItem.Person.FullNameLength());         
        }
    }
}
