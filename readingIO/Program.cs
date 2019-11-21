using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readingIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> myCustomers= new List<Customer>();
            try
            {
               myCustomers= ReadCustomerInfo("../../accountinfo.csv");
            }catch(BalanceException e)
            {
                Console.WriteLine(e.Message);
            }
           
            
            foreach(Customer customer in myCustomers)
            {
                Console.WriteLine($"{customer.ToString()}");
            }
            Console.ReadKey();
        }

        public static List<Customer> ReadCustomerInfo(string fileName)
         {
            List<Customer> customers = new List<Customer>();
            string line;
            string[] words;
            StreamReader input = null;
            try
            {
                using( input=new StreamReader(fileName))
                
                {
                    while((line = input.ReadLine()) != null)
                    {
                        words = line.Split(',');
                        int id = int.Parse(words[0]);
                        string first = words[1];
                        string last = words[2];
                        double balance=0;
                        try
                        {
                         balance = double.Parse(words[3]);
                        }
                        catch (Exception)
                        {
                            //Console.WriteLine(ex.Message);
                            throw new  BalanceException(first);  
                        }
                        
                        AccountType accountType = (AccountType) int.Parse(words[4]);

                        Customer temp = new Customer(id, first, last, balance, accountType);
                        customers.Add(temp);
                    }
                }

            }catch(IOException e)
            {
                Console.WriteLine("There's an error reading from the file"+ e.Message);
            }
          
          
            return customers;

        }
    }
}
