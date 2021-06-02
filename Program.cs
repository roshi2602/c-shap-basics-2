using System;                                                  //namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_shap_basics3                   //namespace declaaration
{


    //c# properties
    //used for transfer data
    //the data fields have get and set method in it
    //2 types- get and set
    //set - is used to set data field , syntax = set { Data Field Name = value; }
    //get - used to get data from data field, syntax =get { return Data Field Name; }

    //different types of properties- readonly, writeonly


    //example having read and write only property
    public class ReadWriteproperty
    {
        private int sid;
        private string sname;
        public int eor            //dont apply colun;               //used to read data into data field and write data into data field
           
        {
        set{
            sid = value;
            }
    get{
        return sid;
        }
}

        public string eos
        {
            set
            {
                sname = value;
            }
            get
            {
                return sname;

            }
        }
    
    }

    
   



    //----------------------------------------------------------------------------

    //const variable
    //whose value can never be changed
    //is always static
    //always initialize const
    class ConstEx
    {
        //assign value to const variable
        public const int x = 10;

    }




    //----------------------------------------------------------------------------

    //read only variable
    class ReadOnlyEx
    {
        public readonly int z = 30;

    }


    //----------------------------------------------------------------------------


//convertToString 
//it handles null values
//it will not throw exception

    class Convert
    {
        public string cust_name { get; set; }
    }

    //now go to class Program

    //----------------------------------------------------------------------------


    //overriding ToString() method  

    public class Program2
    {
        public string first_name;
        public string last_name;

        //now overide
        public override string ToString()
        {
            return first_name + last_name;                 //concatinating
        }

    }
    //now go to class Program
    

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }


    //----------------------------------------------------------------------------


    class Program                                   //class declaration
    {
        






        //----------------------------------------------------------------------------
        //overriding ToString() method

        Program2 p = new Program2();
   //     p.first_name  = "jiya";
     //   p.last_name = "joseph";
     // Console.WriteLine(p.ToString());
        //        Console.ReadLine();

           
          

        //----------------------------------------------------------------------------
        //static and non static member
        //variables inside static block are staticvariable

        int x;                               //non static
        static int y = 100;    //statiic

        public Program(int x)                         //class method
        {
            this.x = x;
        }

        //----------------------------------------------------------------------


        static void Main(string[] args)                 //main method(will executed first)
        {
           
            //----------------------------------------------------------------------------
            //using checked keyword
            //ability to enable overflow checking(means when the value of integer type exceeds its range, it does not raise any exception, instead it gives unexpected results)
            //for arithmetic operations

            //use Class Program for this..


            //checked 
            int g = 21474837;
            int h = 214748;

            int j = checked(g + h);         //checked is used when variable value is too long 
            Console.WriteLine(j);
            Console.ReadLine();

            //checked throws exception


            //----------------------------------------------------------------------------
            //unchecked 
        

            int k = 21474837;
            int l = 214748;

            int m = unchecked(k + l);         //checked is used when variable value is too long 
            Console.WriteLine(j);
            Console.ReadLine();

         
            //unchecked dosent throw exception and works smoothly

         


            //---------------------------------------------------------------------------
            //converttostring
            Convert cc = null;           //assigning it to null as per ConvertToString()
           // Convert.ToString(cc);        //error

            String cd = null;
//            Convert.ToString(cd);          //error

            Console.WriteLine("throws error");
            Console.ReadLine();

            //---------------------------------------------------------------------------
            //properties
            ReadWriteproperty r = new ReadWriteproperty();
            r.eor = 100;
            r.eos = "sim";
            Console.WriteLine("sid" + r.eor);
            Console.WriteLine("sname" + r.eos);
            Console.ReadLine();



            //----------------------------------------------------------------------------
            //readOnly
            ReadOnlyEx rr = new ReadOnlyEx();
            Console.WriteLine(rr.z);            //object.var
            Console.ReadLine();         //in this only assigned value will come as output





            //----------------------------------------------------------------------------
            //Const variable 
            //since const are static in nature, so we will access by class name
            Console.WriteLine(ConstEx.x);

            //we can also declare const variable in function
            const int y = 20;
            Console.WriteLine(y);
            //after declaration we cannot change the value

            Console.WriteLine("result");
            Console.ReadLine();


            //----------------------------------------------------------
            //accessing static variable using class name(static and non static member)
            Console.WriteLine(Program.y);

            //now creating objects
            Program p1 = new Program(10);                //first object 
            Program p2 = new Program(20);                //second object


            //fetching it
            Console.WriteLine($"{p1.x} {p2.x}");
            Console.ReadLine();



            //----------------------------------------------------------------------
            //basic program for employee details
            int eid, esal;
            string ename, eadd;

            //entering details
            Console.WriteLine("enter employee details");

            Console.WriteLine("enter eid");
            eid = int.Parse(Console.ReadLine());

            Console.WriteLine("enter esal");
            esal = int.Parse(Console.ReadLine());


            Console.WriteLine("enter ename");
            ename = Console.ReadLine();

            Console.WriteLine("enter eadd");
            eadd = Console.ReadLine();


            //printing it
            Console.WriteLine("eid detail is " + eid);
            Console.WriteLine("esal detail is " + esal);
            Console.WriteLine("ename detail is " + ename);
            Console.WriteLine("eadd detail is " + eadd);

            Console.ReadLine();

            //--------------------------------------------------------------
        }
    }
}
