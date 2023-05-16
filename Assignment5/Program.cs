namespace Assignment_5
{
    class Programming
    {

        public int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
        public string[] poem = "mary had a little lamb its fleece was white as snow".Split();
        public static void Main(string[] args)
        {
           Console.WriteLine("Enter the number for the question to run or 0 to exit: ");
            Displaymenu();
        }    

        /// <summary>
        /*1.Write a method with the following specifications:
            name: DisplayMenu
            arguments: none
            return value: none
            tasks: display the following menu choice on the screen

            Main Menu
            1) Calculate Sum 
            2) Calculate Average
            3) Display Numbers
            4) Display Poem
            5) Create Numbers Array
            0) To Exit

            Enter the number that corresponds to your choice: 

            You may beautify the output to your own likings. You don’t have to implement the functionalities of the various menu choices at this stage
            Call this method from your main.*/
        public static void Displaymenu()
        {
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            Console.WriteLine("1.Calculate Sum");
            Console.WriteLine("2.Calculate Average");
            Console.WriteLine("3.Display Numbers");
            Console.WriteLine("4.Display Poem");
            Console.WriteLine("5.Create Numbers Array");
            Console.WriteLine("0.To Exit");
            int ch;
            do
            {
            Console.WriteLine("Please enter the number of your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    case 1:
                        Console.WriteLine("Calculating Sum");
                        Console.Write("How many numbers do you want to enter: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int summ = CalculateSum(n);
                        Console.WriteLine($"{"Calculated Sum="} {summ}");
                        break;
                    case 2:
                        Console.WriteLine("Calculating Average");
                        Console.WriteLine("How many numbers do you want to enter: ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        double average = CalculateAverage(choice);
                        Console.WriteLine("Calculated Average: " + average);
                        break;
                    case 3:
                        Console.WriteLine("Displaying Numbers");
                        DisplayIntArray(numbers);
                        break;
                    case 4:
                        Console.WriteLine("Displaying Poem");
                        DisplayStringAray();
                        break;
                    case 5:
                        Console.WriteLine("Create Number Array");
                        CreateIntArray();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
            while (ch != 0);


        }
        //<summary>
        //Modify your main method so that the above method is call repeatedly and the user can enter a menu choice. 
        //The program will terminate when the user enters 0. Any choice not listed should produce an error message.
        //Because you will not be doing any arithmetic you may accept the user response either as an int, or a char or a string.<summary>
        public static void Question2()
        {
            int number;
            do
            {
                Console.WriteLine("Write a Number");
                
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                else if (number > 5)
                {
                    Console.WriteLine("Error. Enter valid number 1-5 ");
                    break;
                }
            } while (number != 0);
        }

        //<summary>
        //Write a method with the following specifications:
        //name: CalculateSum
        //arguments   : a single int representing the number of inputs that will constitute the sum
        //return value	: int representing the sum of all the user inputs
        //displays	: only the prompt for the user inputs, but does not display the sum 
        //tasks	: prompt and accepts inputs (as many as specified by the argument),
        //and sum them, Finally the method will return the sum of all the inputs (the sum) 

        //In your main you will call this method when the user enters 1 in response to the menu choices.
        //You will invoke this method with argument 5 and then display the resulting value from the method.<summary>
        public static int CalculateSum(int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            return sum;
        }
        //<summary>4.	Write a method with the following specifications:
        //name: CalculateAverage
        //arguments   : a single int representing the number of inputs that will constitute the average
        //return value	: double representing the mathematical average of its inputs
        //displays	: only the prompt for the user inputs, but does not display the average
        //tasks	: prompt and accepts inputs (as many as specified by the argument), and average them,
        //Finally the method will return the average of all the inputs (the average)
        //In your main you will call this method when the user enters 2 in response to the menu choices.
        //You will invoke this method with argument 5 and then display the resulting value from the method.<summary>    
        public static double CalculateAverage(int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input the number: ");
                double number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            return sum / n;
        }
        //<summary>5.Write a method with the following specifications:
        //name: DisplayIntArray
        //arguments   : an int array representing the numbers to display
        //return value: none
        //displays    : all values of the array on a single line separated by a space
        //tasks	: display all values in the array
        //In your main you will call this method when the user enters 3 in response to the menu choices.
        //You will invoke this method with argument set to the numbers array variable.
        //Then you will reverse the array and call this method again.*/
        public static void DisplayIntArray(int[] numbers)
        {
            //CreateIntArray();
                //int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
                Console.WriteLine($"Display all values of the array on a single line separated by a space:");
                for (int i = 0; i < numbers.Length; i++)

                {
                    Console.Write($"{" "}{numbers[i]}");
                }
                Console.WriteLine("\n");

             Console.WriteLine($"Display all values of the reversed array on a single line separated by a space:");
            for (int i = numbers.Length-1; i >= 0; i--)

            {
                Console.Write($"{" "}{numbers[i]}");
            }
            Console.WriteLine("\n");
        }

        //<summary>6.	Write a method with the following specifications:
        //name: DisplayStringArray
        //arguments   : a string array representing the values to display
        //return value: none
        //displays    : all values of the array on a single line separated by a space
        //tasks	: display all values in the array
        //In your main you will call this method when the user enters 4 in response to the menu choices.
        //You will invoke this method with argument set to the poem array variable.
        //Then you will sort the array and call this method again.//<summary>
        public static void DisplayStringAray()

        {
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            for (int i = 0; i <= poem.Length; i++)
            {
                Console.Write($"{" "}{poem[i]}");
            }
                Console.WriteLine("\n");
        }
        /*7.	Write a method with the following specifications:
        name: CreateIntArray
        arguments   : none
        return value: an int array representing the created array
        displays	: only the prompt for the user inputs, but does not display the array
        tasks	: prompts and accepts an input for the array length, then create the array,
        then using any loop structure prompt the user for a number and then assign to each element, finally return the array
        In your main you will call this method when the user enters 5 in response to the menu choices.
        You will invoke this method and then pass the resulting array to the DisplayIntArray method.*/
        public static void CreateIntArray()
        {
            Console.WriteLine("Input array length");
           
            int input_array = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[input_array];
            for (int i =0; i < input_array; i++)
            {
                Console.WriteLine($"{"Enter number "}");
                A[i] = Convert.ToInt32(Console.ReadLine());
       
           }
            Console.WriteLine($"Values of the arrays you have ented :");
            for (int i = 0; i < input_array; i++)
            {
                Console.Write($"{" "}{ A[i]}");
            }
                Console.WriteLine("\n");
            DisplayIntArray(A);
        }
        
    }
}