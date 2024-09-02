using System;

namespace StudentEnrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the STI website!");

            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your mother's name: ");
            string motherName = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            
            Console.Write("\nAre you a new or existing student? (New/Existing): ");
            string studentStatus = Console.ReadLine();

            if (studentStatus == "New" || studentStatus == "new")
            {
                Console.WriteLine("Welcome, new student!");

              
                string[] requiredFiles = { "GOODMORAL", "FORM137", "SHSDIPLOMA", "PSA", "MEDCERT" };
                Console.WriteLine("\nYou need to submit the following documents:");

                foreach (string file in requiredFiles)
                {
                    string response = "";
                    while (response != "Yes" && response != "No")
                    {
                        Console.Write($"Do you have the {file}? (Yes/No): ");
                        response = Console.ReadLine();
                        if (response == "Yes" || response == "yes")
                        {
                            Console.WriteLine($"{file} is available.");
                        }
                        else if (response == "No" || response == "no")
                        {
                            Console.WriteLine($"Please make sure to obtain the {file}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid response. Please answer 'Yes' or 'No'.");
                        }
                    }
                }
            }
            else if (studentStatus == "Existing" || studentStatus == "existing")
            {
                Console.WriteLine("Welcome back, existing student!");
                Console.WriteLine("No additional documents are required.");
            }
            else
            {
                Console.WriteLine("Invalid status. Please enter 'New' or 'Existing'.");
                return;
            }

           
            Console.WriteLine("\nAvailable courses:");
            Console.WriteLine("1. BSCS (Bachelor of Science in Computer Science)");
            Console.WriteLine("2. BSIT (Bachelor of Science in Information Technology)");
            Console.Write("Select your course: ");
            string course = Console.ReadLine();

            if (course == "BSCS" || course == "bscs")
            {
                Console.WriteLine($"You selected BSCS. This course focuses on computing theory, programming, and software development.");
            }
            else if (course == "BSIT" || course == "bsit")
            {
                Console.WriteLine($"You selected BSIT. This course emphasizes practical IT skills, network management, and system administration.");
            }
            else
            {
                Console.WriteLine("Invalid course selection.");
            }

           
            Console.Write("\nPayment option (Cash or Installment): ");
            string paymentOption = Console.ReadLine();

            if (paymentOption == "Cash" || paymentOption == "cash")
            {
                Console.WriteLine("You chose to pay in cash. The total is 32,000 pesos.");
            }
            else if (paymentOption == "Installment" || paymentOption == "installment")
            {
                Console.WriteLine("You chose to pay in installments. Deposit: 10,000 pesos, 6,250 pesos per quarter.");
            }
            else
            {
                Console.WriteLine("Invalid payment option.");
            }

            
            Console.WriteLine("\nRegistration Summary:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Mother's Name: {motherName}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Course: {course}");
        }
    }
}
