using System;
namespace hw16june
{
    public class Student
    {
        
        public Student()
        {
            _totalCount++;
            No = TotalCount;
        }
        private static int _totalCount;
        public static int TotalCount => _totalCount;
        public int No { get; }
        public string FullName;
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }


        public static bool CheckGroupNo(string groupNo)
        {
            if(!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 4)
            {
                if (Char.IsLetter(groupNo[0])
                {
                    for(int i=1; i<groupNo.Length; i++)
                    {
                        if (Char.IsDigit(groupNo[i]))
                            return false;
                    }
                    return true;
                }
            }
            return false;
        }

        
    }
}
 