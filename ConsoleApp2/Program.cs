using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Ticket Bill = new Ticket();
            do
            {
                Console.WriteLine("Introduzca el Importe");
                string text = Console.ReadLine();
                double Number;
                Number = Convert.ToDouble(text);
                Bill.Amount += Number;
                
            } while (Bill.Amount < 200);

            Console.WriteLine("Has superado los 200 euros, avisa al seguridad");
            Console.ReadKey();
            


        

            
        
            


        }
    }
}

public class Ticket
{
    public double Amount; 
    public DateTime DateTicket;
    public string Employee;


    
}


