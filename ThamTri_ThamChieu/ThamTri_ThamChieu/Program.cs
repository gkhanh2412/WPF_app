// Kiểu tham trị (value type) lưu nội udng của nó trong bộ nhớ caapsphats là stack. 
// Khi chúng ta tạo một biến kiểu tham trị thì một vùng nhớ sẽ được cấp phát để lưu giá trị của biến một cách trực tiếp 
// nếu bạn gán nó cho một biến khác thì giá trị sẽ được copy trực tiếp và cả 2 biến sẽ làm việc độc lập với nhau.
// Các kiểu dữ liệu nguyên thủy như int, float, double, char, bool, struct, enum đều là kiểu tham trị.

// kiểu tham chiếu (reference type) lưu địa chỉ của ô nhớ của một đối tượng chứ không lưu trữ đối tượng đó.
// Bởi vì kiểu tham chiếu lưu địa chỉ chứ không lưu trực tiếp giá trị nên khi bạn gán một biến kiểu tham chiếu cho một biến khác thì cả 2 biến sẽ trỏ đến cùng một đối tượng.
// Các kiểu dữ liệu tham chiếu như class, interface, delegate, string, object, dynamic, array, list, dictionary, filestream, streamreader, streamwriter, exception, collection, context, dataset, datatable, datareader, dataadapter, command, connection, transaction, commandbuilder, parameter, sqlcommand

// stack là bộ nhớ cấp phát tĩnh, heap là bộ nhớ cấp phát động, cả 2 đều được lưu trữ trêN RAM
// ví dụ int a = 10 thì a =10 lưu trong stack, object lưu địa chỉ trong stack và lưu giá trị trong heap
/// trong ứng dụng multithreading thì stack sẽ được chia ra thành các thread stack, mỗi thread sẽ có một stack riêng, nhưng dùng chung 1 heap


using System;

namespace ThamTri_ThamChieu
{
    internal class Program
    {
        class Student
        {
            public string StudentName { set; get; }
        }
        static void ChangeValue(int x)
        { // Tham trị
            x = 200;
            Console.WriteLine(x);
        }

        static void ChangeReferType(Student std2)
        {
            std2.StudentName = "Steve";
        }
        static void Main(string[] args)
        {
            //int i = 100;
            //Console.WriteLine(i);
            //ChangeValue(i);
            //Console.WriteLine(i);
            // ctrl KC để comment

            Student std1 = new Student();
            std1.StudentName = "Bill";
            ChangeReferType(std1);
            Console.WriteLine(std1.StudentName);.
            Console.ReadLine();
        }
    }
}
