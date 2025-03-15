using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_beginner_week_2
{
    internal class Program
    {
        /* #region Class student
        class Student
        {
            public string name;
            public int age;
            public string grade;
            public Student(string name,int age,string grade)
            {
                this.name = name;
                this.age = age;
                this.grade = grade;
            }
            public virtual void PrintDetails()
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Name:" + name + "\nAge:" + age + "\nGrade:" + grade);
            }
        }
        class PostGraduate:Student
        {
            string ThisisTopic;
            public PostGraduate(string name, int age, string grade, string ThisisTopic) : base(name, age, grade)
            {
                this.ThisisTopic = ThisisTopic;
            }
            public override void PrintDetails()
            {
                base.PrintDetails();
                Console.WriteLine("ThisisTopic:"+ThisisTopic);
                Console.WriteLine("----------------------------------------");
            }
        }
        #endregion */

        /* #region Class Emmpolyee
        enum Gender
        {
            M,F
        }
        enum SecurityPrivileges
        {
            guest,developer,secertary,DBA
        }
        class Emmpolyee
        {
            int id;
            string name;
            SecurityPrivileges security;
            decimal salary;
            DateTime HireDate;
            Gender gender;
            public Emmpolyee(int id,string name, SecurityPrivileges security,decimal salary,DateTime HireDate,Gender gender)
            {
                this.id = id;
                this.name = name;
                this.security = security;
                this.salary = salary;
                this.HireDate = HireDate;
                this.gender = gender;
            }
            public override string ToString()
            {
                return $"ID:{id}\nName:{name}\nSecurity level:{security}\nSalary:{String.Format("{0:c}",salary)}\nHire data:{HireDate:dd,MM,yyyy}\nGender:{gender}\n--------------------------";
            }
        }
        #endregion */
        static void Main(string[] args)
        {
            /* Student student1 = new Student("Ahmed", 19, "Excellent");
             student1.PrintDetails();
             PostGraduate postGraduate1 = new PostGraduate("Maged", 25, "Very Good", "Internet of things");
             postGraduate1.PrintDetails();
             Student student2 = new Student("Ali", 20, "Good");
             student2.PrintDetails();
             PostGraduate postGraduate2 = new PostGraduate("Ans", 28, "Excellent", "AI");
             postGraduate2.PrintDetails(); */


           /* Emmpolyee emmpolyee1 = new Emmpolyee(1, "Ahmed", SecurityPrivileges.developer, 30500, new DateTime(2000,11,9), Gender.M);
            Console.WriteLine(emmpolyee1);
            Emmpolyee emmpolyee2 = new Emmpolyee(2, "Sara", SecurityPrivileges.secertary, 10000, new DateTime(2002,5,10), Gender.F);
            Console.WriteLine(emmpolyee2);
            Emmpolyee emmpolyee3 = new Emmpolyee(3, "Ali", SecurityPrivileges.DBA, 33750, new DateTime(1993,5, 7), Gender.M);
            Console.WriteLine(emmpolyee3); */
        }
    }
}
