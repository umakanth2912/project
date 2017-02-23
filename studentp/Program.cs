using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentp
{
    class student
    {
        public int StdId =0;
        public string StdLastName="";
        public string StdFirstName="";
        public char StdGender='\0';
        public DateTime ?StdDob= null;
    }
    class Program 
    {
        static void Main(string[] args)
        {
            List<student> stdreg = new List<student>();
        user: Console.WriteLine("Please Select from the below Options: \n 1.Register New Student \n 2.Search Existing Student by Last name");
            int valueselectd = Convert.ToInt32(Console.ReadLine());
            

            switch (valueselectd)
            {
                case 1:
                    Console.WriteLine("You Have selected Registration");
                    student st = new student();
                    Console.WriteLine("Please Enter the Student Id:");
                    st.StdId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter the Student First Name:");
                    st.StdFirstName = Console.ReadLine();
                    Console.WriteLine("Please Enter the Student Last Name:");
                    st.StdLastName = Console.ReadLine();
                    Console.WriteLine("Please Enter the Student Date Of Birth");
                    st.StdDob = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Please Enter Student Gender");
                    st.StdGender = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Your Details are Saved");
                    stdreg.Add(st);
                    goto user;
                    
                    

                case 2:
                    Console.WriteLine("You Have seleccted Search Student by Last Name");
                    Console.WriteLine("Please enter the last name you want to search:");
                    string fi = Console.ReadLine();
                    foreach (student stt in stdreg)
                    {
                        
                        var i = stdreg.Find(x => x.StdLastName.Contains(fi));
                   
                        Console.WriteLine("\n Student By Last Name:\n  Student First Name:{0}\n Student Last Name:{1}\n Student Id:{2}\n Student Date of Birth:{3}",i.StdFirstName,i.StdLastName,i.StdId,i.StdDob
            );
                        
                        Console.ReadLine();
                    }
                    break;
                default: Console.WriteLine("Enter the Correct value");
                    break;

            }
           
                        

                
            
        }
    }
}
