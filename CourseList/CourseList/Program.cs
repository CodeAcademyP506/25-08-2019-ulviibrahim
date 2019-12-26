using CourseList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Simple course management proqramı hazırlayın
//Proqramda olmalıdır: qruplar, müəllimlər və tələbələr.
//İstifadəçinin imkanı olmalıdır: qrup əlavə etsin, silsin / müəllim əlavə etsin, silsin / tələbə əlavə etsin, silsin
//Qrupun bir müəllimi və çoxlu tələbəsi olmalıdır(list)
//Eyni tələbə yalnız bir qrupda ola bilər, ancaq eyni müəllim müxtəlif qruplara dərs deyə bilər.
//Qrupu siləndə avtomatik olaraq onun bütün tələbələri də silinməldiri, amma qrupun müəllimi yalnız o halda silinə bilər ki, o başqa qrupa dərs demir.




//Keçən həftəki task.a əlavə olaraq:
//Bütün obyektlərin(tələbə, müəllim, qrup) getInfo metodu olsun, həmin obyekt(list) haqqında bütün məlumatı ekrana yazdırsın
//İstifadəçinin daxil etdiyi məlumatların sizin tələblərinizə uyğunluğunu yoxlamaq üçün try/catch mexanizimini əlavə edin

namespace CourseList
{
    class Program
    {
        static void Main(string[] args)
        {






            Console.WriteLine();










            Console.WriteLine(" Simple Course managment program");

            Console.WriteLine();

            Console.WriteLine("1. Add Group");
            Console.WriteLine("2. Add Student");

            Console.WriteLine("1.  Add Group teacher");

            Console.WriteLine();

        
            List<Group> groups = new List<Group>();
            groups.Add(new Group() { GroupName="P506", CountStu=12,});
            Group gru = new Group();
            var choose = Console.ReadLine();
            int countChoose = 0;


            if (choose == "1" && countChoose == 0)
            {
                Console.WriteLine(" 1 secilib");
                int countgroupname = 0;
                string[] groupNames = new string[3];

                groupNames[0] = Console.ReadLine();
                countgroupname++;
                groupNames[1] = Console.ReadLine();
                groupNames[2] = Console.ReadLine();

                for (int i = 0; i < groupNames.Length; i++)
                {
                    Console.WriteLine(groupNames[i]);
                }
                Console.WriteLine();
                Console.ReadLine();

                countChoose++;
            }
            else if (choose == "2" && countChoose != 0)
            {
                Console.WriteLine("Zehmet olmasa once Group elave edin");

                Console.WriteLine("2 secilib");
            }
            else if (choose == "2" || choose == "3" && countChoose == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Zehmet olmasa once Group elave edin");
                Console.WriteLine();
            }

            else if (choose == "3" && countChoose != 0)
            {
                Console.WriteLine("3 secilib");
            }



            var stu = new Student();
            stu.EnqueStudent(new Student() { Name = "Ulvi" });
            stu.EnqueStudent(new Student() { Name = "Besir" });
            stu.EnqueStudent(new Student() { Name = "Kamal" });


            for (int i = 0; i < stu.StudentList.Length; i++)
            {
                Console.WriteLine(stu.StudentList[i].StuInfo());
                Console.WriteLine();
            }

            var teacher = new Teacher();
            teacher.EnqueTeacher(new Teacher() { Name = "Ismayil", Surname = "Ismayilov", Proffesion = "Programmer" });
            teacher.EnqueTeacher(new Teacher() { Name = "Yolchu", Surname = "Nasib", Proffesion = "Programmer" });



            for (int i = 0; i < teacher.TeacherList.Length; i++)
            {
                Console.WriteLine(teacher.TeacherList[i].TeacherInfo());
                Console.WriteLine();
            }


        }


    }

    public class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }



        }

       public class Student : Person
        {
            public int Age { get; set; }
            public string GroupName { get; set; }

            public string StuInfo()
            {
                var result = Name + " " + Surname + " " + Age + " " + GroupName;

                return result;


            }


        public Student[] StudentList = new Student[3];
        int nextindex = 0;
        public void EnqueStudent(Student a)
        {
            StudentList[nextindex] = a;
            nextindex++;
        }


    }

}
           public class Teacher : Person
            {
                public string Proffesion { get; set; }
    public string[] Groups;


    int nextindex = 0;

    public Teacher[] TeacherList = new Teacher[2];

    public void EnqueTeacher(Teacher a)
    {
        TeacherList[nextindex] = a;
        nextindex++;
    }

    public string TeacherInfo()
                {
                    var result = Name + " " + Surname + " " + Proffesion + " ";

                    return result;


                }
            }
       
   
        class Group:Teacher
        {
            public string GroupName { get; set; }
            public int CountStu { get; set; }
            public void teacherName (List<Teacher>teacherlist, string name)
            {
                for (int i = 0; i < teacherlist.Count; i++)
                {
                    teacherlist[i].Name = name;
                }

            }


        }
        
    


   

