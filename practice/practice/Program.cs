using practice.Models;
using System;

namespace practice
{
    class Program
    {
        private static object student;

        static void Main(string[] args)
        {
        Start:
            string fullName;
            try
            {
                Console.WriteLine("add fullname:");
                fullName = Console.ReadLine(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            int age;
            try
            {
                Console.WriteLine("add age:");
                age = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            string email;
            try
            {
                Console.WriteLine("add email:");
                email = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            string password;
            try
            {
                Console.WriteLine("add password:");
                password = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
            user us = new user(fullName, email, password);
            Console.WriteLine("-----------------------------");
            int choose;
            do
            {
                Console.WriteLine("1:Show info\n2. create new group\n3-Info\n0-cixis");
                Console.WriteLine("---------------------------------------------");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 3:
                        Console.WriteLine("----------------");
                        break;
                    case 1:
                        Console.WriteLine("-----------");
                        us.ShowInfo();
                        break;
                    case 0:
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("THE END");
                        break;
                    case 2:
                        string groupNo;
                        try
                        {
                            Console.WriteLine("add group no:");
                            groupNo = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        int studentLimit;
                        try
                        {
                            Console.WriteLine("add student count:");
                            studentLimit = int.Parse(Console.ReadLine());

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        Group gro = new Group(groupNo, studentLimit);
                        string fullName1;
                        try
                        {
                            Console.WriteLine("add fullname:");
                            fullName = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        double point;
                        try
                        {
                            Console.WriteLine("add point:");
                            point = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        Student stu = new Student(fullName, point);
                        Console.WriteLine("--------------------------");
                        int edit;
                        do
                        {
                            Console.WriteLine("1.show all students\n2-get student by id\n3-add student\n4-info\n0-quit");
                            edit = int.Parse(Console.ReadLine());
                            switch (edit)
                            {
                                case 1:
                                    Console.WriteLine("----------------");
                                    gro.GetAllStudent(student);
                                    break;
                            case 2:
                        int id;
                        try
                        {
                            Console.WriteLine("add id:");
                            id = int.Parse(Console.ReadLine());
                            gro.GetStudent(id);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            goto Start;
                        }
                        break;
                                case 3:
                                    Console.WriteLine("--------------");
                                    gro.AddStudent(stu);
                                    break;
                                case 4:
                                    Console.WriteLine("------------");
                                    break;
                                case 0:
                                    Console.WriteLine("THE END");
                                    break;
                                default:
                                    Console.WriteLine("you entered incorrectly");
                                    break;
                            }

                        } while (edit !=0);
                        break;
                    default:
                        Console.WriteLine("you entered incorrectly");
                        break;
                }
            } while (choose !=0);            
        }
    }
}
