using System;
using System.Collections;

namespace ArrayList_Student
{
    class StudentManagement
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();
            //Thêm các phần tử vào ArrayList.

            studentList.Add(new Student { Name = "Peter", Age = 20 });
            studentList.Add(new Student { Name = "John", Age = 21 });
            studentList.Add(new Student { Name = "Mark", Age = 19 });
            //Sử dụng đoạn code sau để kiểm tra kết quả.

            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);
            //Thay đổi phần tử ở vị trí số 0 trong ArrayList.

            studentList[0] = new Student { Name = "Michael", Age = 21 };
            //Sử dụng đoạn code sau để kiểm tra kết quả.

            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);
            //Xoá phần tử có index bằng 1 trong ArrayList.

            studentList.RemoveAt(1);
            //Sử dụng đoạn code sau để kiểm tra kết quả.

            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);
        }
    }
}
