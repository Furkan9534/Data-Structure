 
 // Array
 

    int numbers[] = {2, 4, 8, 12, 16, 18};
    int n = sizeof(numbers)/sizeof(numbers[0]);
    // Printing array elements
    for (int i = 0; i < n; i++) {
        printf("%d ", numbers[i]);
        printf("\n");
    }



    // array declaration and initialization
    int numbers1[5] = {2, 4, 8, 12, 16};

    // accessing element at index 2 i.e 3rd element
    printf("%d ", numbers1[2]);

    // accessing element at index 4 i.e last element
    printf("%d ", numbers1[4]);

    // accessing element at index 0 i.e first element
    printf("%d ", numbers1[0]);
    

    //Update Array Element
    numers1[0] = 1;

    //Size of Array
     int size = sizeof(numbers1)/sizeof(numbers1[0]);
    printf("%d", size);


