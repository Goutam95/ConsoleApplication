namespace DelegatesExample
{
    public class Grading
    {
        public static List<int> GradeingOfStudent(List<int> grades)
        { 
            const int failingGrade = 38;
            List<int> result       = new();

            if (grades.Count == 0)
            {
                return new List<int> {};
            }
            else
            {
                for (int i = 0; i < grades.Count; i++)
                {
                    if (grades[i] < failingGrade)
                    {
                        result.Add(grades[i]);
                    }
                    else if (grades[i] >= failingGrade)  
                    {
                        if (grades[i] % 5 == 0)
                        {
                            result.Add(grades[i]);
                        }
                        else if ((grades[i] + 1) % 5 == 0)
                        {
                            if(((grades[i] + 1) - grades[i]) <= 3)
                            {
                                result.Add(grades[i] + 1);
                            }
                        }
                        else if((grades[i] + 2) % 5 == 0)
                        {
                            if (((grades[i] + 2) - grades[i]) <= 3)
                            {
                                result.Add(grades[i] + 2);
                            }
                        }
                        else 
                        {
                            result.Add(grades[i]);
                        }
                    }
                }
                return result;          
            }
        }
        public static void Mainee(string[] args)  
        {
           Console.WriteLine(string.Join(" ", GradeingOfStudent(new() { 73, 67, 38, 33})));
        }
    }
}

//ID OriginalGrade	FinalGrade
//1	        73	        75
//2	        67	        67
//3	        38	        40
//4	        33	        33
//Explanations:

//Student 1 received a 73, and the next multiple of 5 from 73 is 75. Since 75 – 73 < 3, the student's grade is rounded to 75.
//Student 2 received a 67, and the next multiple of 5 from 67 is 70. Since 70 – 67 = 3, the grade will not be modified and the student's final grade is still a 67.
//Student 3 received a 38, and the next multiple of 5 from 38 is 40. Since 40 – 38 = 2, the student's grade will be rounded to 40.
//Student received a grade below 33, so the grade will not be modified and the student’s final grade is 33.
//cm  cvvvbg n 