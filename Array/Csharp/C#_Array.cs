/*
 * Arrays İn C#
 *Arrays in C#
   Arrays are fixed-size data structures that store data of the same type. They store all elements 
   starting from index 0. Data can also be accessed using the index.
   
   In C#, arrays can contain basic data types as well as objects of a class. When basic data types 
   are used, the actual values ​​are stored in contiguous memory locations. When objects of a
    class are involved, the actual objects are stored in the stack.
 *
 * 
 */


//Declare Arrays --> <Data Type>[size of the array] <Name_Array>
int [] numbers1=[1,2,3,4,5,6,7,8,9,10];

/*
 *Array Initialization
An array is a type of reference array. We create an instance of an array using the `new` keyword. 
We can initialize individual elements of the array using indexes.  
 *Syntax : Data_type [ ] < Name_Array > = new < datatype > [size];
 * Data_type: data type
   size: number of elements in the array
   Name_Array=Array Name
   new: allocates memory to the array.
 */
 //<data_type>[] <arr_name> = new <data_type>[size];
 int[] data = new int[5];
 
 //<data_type>[] <arr_name> = new <data_type>[size]{ array_elements};
 int[] data1 = new int[5]{1, 2, 3, 4, 5};
 //<data_type>[] <arr_name> = { array_elements};
 int[] data2 = {1, 2, 3, 4, 5};
    


//--------------------------------------AXAMPLE--------------------------------------------


// declares an Array of integers.
 int[] Data;

 // allocating memory for 5 integers.
 Data = new int[5];

 // initialize the first elements of the array
 Data[0] = 10;

 // initialize the second elements of the array
 Data[1] = 20;

 // so on...
 Data[2] = 30;
 Data[3] = 40;
 Data[4] = 50;

 // accessing the elements using for loop
 Console.Write("For loop :");
 for (int i = 0; i < Data.Length; i++)
     Console.Write(" " + Data[i]);

 Console.WriteLine("");
 Console.Write("For-each loop :");
		
 // using for-each loop
 foreach(int i in Data)
     Console.Write(" " + i);

 Console.WriteLine("");
 Console.Write("while loop :");
		
 // using while loop
 int j = 0;
 while (j < Data.Length) {
     Console.Write(" " + Data[j]);
     j++;
 }
 Console.WriteLine("");
 Console.Write("Do-while loop :");
 // using do-while loop
 int k = 0;
 do
 {
     Console.Write(" " + Data[k]);
     k++;
 } while (k < Data.Length);

//-------------------------------------------1. One-Dimensional Array---------------------------
//To store data in arrays, you must define the array. This array stores data sequentially, starting from array 0.
//int[] arrayint = new int[5];

 
 // declares a 1D Array of string.
 string[] days;

 // allocating memory for days.
 days = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

 // Displaying Elements
 foreach(string day in days)
     Console.Write(day + " ");
 
 //2. Multidimensional Arrays
/*
 *Multidimensional arrays require multiple rows to store data. This also known   rectangular arrays. 2D ,3D or more.
 * if you want to access data, you need nested loop.
 * int[,] data1 = new int[4, 2];
 * int[,,] data2 = new int[4, 2, 3];
 */
  int[,, ] numbers = new int[2, 2, 3] { { { 1, 2, 3 }, 
         { 4, 5, 6 } }, 
     { { 7, 8, 9 }, 
         { 10, 11, 12 } } };
 // Checking elements at particular index
 Console.WriteLine("arr[1][0][1] : " + numbers[1, 0, 1]);
 Console.WriteLine("arr[1][1][2] : " + numbers[1, 1, 2]);
 

//3. Jagged Arrays
/*
 * Arrays whose elements are arrays are called "irregular arrays". Irregular array elements can have different sizes.
 */
 
 
 // Declaring Jagged Array
 int[][] numberss = { new int[] { 1, 3, 5, 7, 9 },
     new int[] { 2, 4, 6, 8 } };
        
 Console.WriteLine("Arrays :");
      
 // Display the array elements:
 for (int i = 0; i < numberss.Length; i++)
 {
     System.Console.Write("Elements[" + i + "] Array: ");

     // Printing the elements of array
     for (int x = 0; x < numberss[i].Length; x++)
     {
         Console.Write(numberss[i][x] + " ");
     }
 }