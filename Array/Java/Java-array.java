	/*
		 * Array in Java
		 * An array stores the same data types sequentially in memory locations. 
		 * It allows you to define a single element and store multiple values ​​within it, 
		 * and access the desired data using an index.
		   In the Java programming language, arrays can hold both basic data types (int, char, boolean, etc.)
           and objects (string, integer, etc.).
           When using arrays composed of basic data types, the elements are stored in sequential locations.
           For non-basic data types, references to the elements are stored in sequential locations. 
           The first element of an array is at index 0.
           Once an array is created, its size is fixed.
		 */
		
		//Definition Array
		
        int[] Numbers = {10, 20, 30, 40};// Definition
        int n = Numbers.length; // length of array

        System.out.print("Primitive Array -> ");
        
        for (int i = 0; i < n; i++)
            System.out.print(Numbers[i] + " ");

        System.out.println();
        
        

        // Non-primitive  
        String[] Names = {"Lakshit", "Rahul", "Pankaj"};
        System.out.print("Non-Primitive Array -> ");
        for (int i = 0; i < Names.length; i++)
            System.out.print(Names[i] + " ");
		
		
		 