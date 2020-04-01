using System;
using System.Text.RegularExpressions;

/*--------------- Welcome to User Registration ------------------------------------------------------------------------------*
 * As a user u need to enter a valid first name  [ first name start with cap and has minimum 3 charecters ]
 * As a User need to enter a valid Last Name - [ Last name starts with Cap and has minimum 3 characters]
 * As a User need to enter a valid email - E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co)
 * ->and 2 optional (xyz & in) with precise @ and . positions
 * As a User need to follow pre -defined Mobile Format - E.g. 91 9919819801 - Country code follow by space and 10 digit number
 * As a User need to follow pre -defined Password rules. Rule1– minimum 8 Characters
 * Rule2 – Should have at least 1 Upper Case
 * Rule3 - Should have at least 1 numeric number in the password
 * Rule4 - Should have only one special charector
 * --------------------------------------------------------------------------------------------------------------------------*/
namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string first_name = null,
                   last_name = null,
                   email = null,
                   phone_number = null,
                   password=null;
            Console.WriteLine("----***** Welcome To User Registration *****----");
            // creating object to the UserRegistration class
            UserRegistration obj_userregistaration = new UserRegistration();
        
            // logic for first name
            while (first_name is null) 
                 first_name = obj_userregistaration.FristName();
            // logic for last name
            while (last_name is null)
                 last_name = obj_userregistaration.LastName();
            //logic for email
            while (email is null)
                email = obj_userregistaration.Email();
            // logic for phone number
            while (phone_number is null)
                phone_number = obj_userregistaration.PhoneNumber();
            //logic for password
            while (password is null)
                password = obj_userregistaration.Password();
            Console.WriteLine("first name  : " + first_name) ;
            Console.WriteLine("last name  : " + last_name);
            Console.WriteLine("email  : " + email);
            Console.WriteLine("phone number   : " + phone_number);
            Console.WriteLine("Password   :  " + password);
        }//end:  static void Main(string[] args)
    }//end : class Program
    public class UserRegistration
    {
        // variables

        // method for firstname
        public string FristName()
        {
            //variable
            string first_name;
            Console.WriteLine("Enter first name \n  ::first name start with cap and has minimum 3 charecters");
            first_name = Console.ReadLine();
            // expression
            string exp = "^[A-Z]{1,}..";
            // create object to Regex
            Regex re_firstName = new Regex(exp);
            // check  first name rules
            if (re_firstName.IsMatch(first_name)) {
                return first_name;
            }// if (re_firstName.IsMatch(first_name))
            else
            {
                Console.WriteLine("in valid input ");
                return null;
            }
        }//end: public string FristName()

        // method for validate last name
        public string LastName()
        {
            //variable
            string last_name;
            Console.WriteLine("Enter Last name \n  :: last name start with cap and has minimum 3 charecters");
            last_name = Console.ReadLine();
            //expression
            string exp = "^[A-Z]{1,}..";
            // create object to Regex
            Regex re_lastName = new Regex(exp);
            // check  last name rules
            if (re_lastName.IsMatch(last_name))
            {
                return last_name;
            }// if (re_last.IsMatch(last_name))
            else
            {
                Console.WriteLine("in valid input ");
                return null;
            }
        }//end :  public string LastName()

        // method email validation
        public string Email()
        {
            //variable
            string email;
            Console.WriteLine("Enter email id \n  :: email E.g :- abc@bl.com ");
            email = Console.ReadLine();
            //expression
            string exp = "^[a-zA-Z0-9]*@[a-zA-Z0-9]*.[a-zA-Z0-9]{2,4}$";
            // create object to Regex
            Regex re_email = new Regex(exp);
            // check  email rules
            if (re_email.IsMatch(email))
            {
                return email ;
             
            }// if (re_email.IsMatch(email))
            else
            {
                Console.WriteLine("invalid input ");
                return null;
            }
        }//  end : public string Email()

        // method for phone number validation
        public string PhoneNumber() {
            //variable
            string phone_number;
            Console.WriteLine("Enter  phone number \n  :: E.g -- 91 9919819801 - Country code follow by space and 10 digit number ");
            phone_number = Console.ReadLine();
            //expression
            string exp = "^[0-9]{2} [0-9]{10}$";
            // create object to Regex
            Regex re_phonenumber = new Regex(exp);
            // check  phone number rules
            if (re_phonenumber.IsMatch(phone_number))
            {
                return phone_number;
            }// if (re_phonenumber.IsMatch(exp))
            else
            {
                Console.WriteLine("invalid input ");
                return null;
            }
        }//end: public int PhoneNumber()

        // method for password validation
        public string Password()
        {
            // variables
            string password;
            Console.WriteLine("enter password  \n :: Rule1: minimum 8 Characters");
            password = Console.ReadLine();
            // expression
            string r2 = "[A-Z]{1,}",
                   r3 = "[0-9]{1,}",
                   r4a = "[\\W]{1}",
                   r4b = "[\\W]{2,}";
            // create object to Regex
            Regex re_psw_r2 = new Regex(r2);
            Regex re_psw_r3 = new Regex(r3);
            Regex re_psw_r4a = new Regex(r4a);
            Regex re_psw_r4b = new Regex(r4b);
            // check  password  rules
            if (password.Length >= 8 )
            {
                // cheking password have a Capital letters && Number && Special charectors
                if (re_psw_r2.IsMatch(password) && re_psw_r3.IsMatch(password) && re_psw_r4a.IsMatch(password))
                {
                    // checking the password have 2 or more special charectors
                    if (re_psw_r4b.IsMatch(password))
                        return null;
                    else
                        return password;
                }
                else
                {
                    Console.WriteLine("invalid input ");
                    return null;
                } 
                
            }// if (re_password.IsMatch(exp))
            else
            {
                Console.WriteLine("invalid input ");
                return null;
            }
        }// end:public string Password()
    }// end :public class UserRegistration
}//end : namespace UserRegistration