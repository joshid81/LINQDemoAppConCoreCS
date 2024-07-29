
using LINQDemoAppConCoreCS;

MyGenCollection<Product> products = new MyGenCollection<Product>();

products.Add(new Product { ProductID = 1, ProductName = "Table" });

products.Add(new Product { ProductID = 2, ProductName = "Chair" });

products.Add(new Product { ProductID = 4, ProductName = "Pen" });

products.ShowList();

Console.WriteLine("-------------");


//MyGenCollection<int> intList = new MyGenCollection<int>();
//intList.Add(1);
//intList.Add(2);
//intList.ShowList();

//Console.WriteLine("-------------");

MyGenCollection<Employee> employees = new MyGenCollection<Employee>();

employees.Add(new Employee { EmpID = 101, EmpName = "Kishan" });
employees.Add(new Employee { EmpID = 102, EmpName = "Ruturaj" });
employees.Add(new Employee { EmpID = 103, EmpName = "Manish" });


employees.ShowList();

Console.WriteLine("-------------");


//MyGenCollection<float> floatList = new MyGenCollection<float>();
//floatList.Add(10.4f);
//floatList.Add(23.9f);
//floatList.ShowList();

//MyGenCollection<Student> students = new MyGenCollection<Student>();
//students.Add(new Student { StudentID = 1111, Age = 20, City = "Surat", StudentName = "Harish" });
//students.ShowList();




