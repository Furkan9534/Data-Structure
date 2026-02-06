#Pyhton Liste
#Python'da liste, sıralı bir şekilde verileri tutan bir veri yapısıdır. 
# Bazı dillerdeki dizilerin aksine, Python listeleri çok esnektir:
#Tekrarlanan verileri içerebilir.
#Öğeler değiştirilebilir, yani var olan öge değiştirilerek yerine yenisi yazılabilir veya kaldırılabilir.
#Sıralı bir şekilde veriler eklenir.
#Farklı veri tipleri olarak veri saklanabilir. Örneğin integer,strings...


#Python List
#In Python, a list is a data structure that stores data in an ordered manner.
#Unlike arrays in some languages, Python lists are very flexible:
#Can contain repeated data.
#Elements are modifiable, meaning existing elements can be replaced with new ones or removed.
#Data is added in an ordered manner.
#Data can be stored as different data types. For example, integer, strings...


#1.Creat List
a = [1, 2, 3, 4, 5] # List of integers
b = ['apple', 'banana', 'cherry'] # List of strings
c = [1, 'hello', 3.14, True] # Mixed data types
#Print
print("İnteger data types",a)
print("Mixed Strings types",b)
print("Mixed data types",c)

#2. Using Constructor --> list()
Customer=list("CustomerName")
print("Constructor result : ",Customer)

#3. Creating List with Repeated Elements
Customer1=["Name","Surname"]*7 #--> 7 times it will contunie

#4.Accessing List Elements
Customer2=["Name","Surname"]*7 #--> 7 times it will contunie
print("First Element : ",Customer2[0])

#5.Adding Elements into List
"""
We can perform operations on lists using the following functions:

append(): Adds a desired item to the end of the list.

extend(): Adds multiple items to the end of the list.

insert(): Inserts an item at a specific position.
clear(): Removes all items.
"""
Customer3 = []

Customer3.append(10)  
print("Customer3 : After append(10):", Customer3)  

Customer3.insert(0, 5)
print("Customer3 : After insert(0, 5):", Customer3) 

Customer3.extend([15, 20, 25])  
print("Customer3 : After extend([15, 20, 25]):", Customer3) 

Customer3.clear()
print("Customer3 : After clear():", Customer3)

#6.Updating List Items
#Lists are editable, and you can update items by accessing them through their indexes.
Customer4=[10, 20, 30, 40, 50]
Customer4[1] = 25 
print(Customer4)

#7. Remove Elements
"""
remove(): Removes the first occurrence of an element.
pop(): Removes the element at the specified index, or the last element if no index is specified.
del statement: Deletes the element at the specified index.
"""
Customer5 = [10, 20, 30, 40, 50]

Customer5.remove(30)  
print("After remove(30):", Customer5)

popped_val = Customer5.pop(1)  
print("Popped element:", popped_val)
print("After pop(1):", Customer5) 

del Customer5[0]  
print("After del a[0]:", Customer5)

#8.Listeler Üzerinde Yineleme
#We can iterate through lists using loops, and each item can be processed individually.
Customer6 = ['Name', 'Surname', 'Address']
for item in a:
    print(item)

#9.Nested Lists
"""
Nested lists are very useful for working with 
matrices or tables. They are used by writing a list within a list. 
You can see an example below.
"""
Numbers = [ [1, 2, 3],
           [4, 5, 6],
           [7, 8, 9] ]
print(Numbers[1][2])

#10.List Understanding
"""
List understanding allows us to create lists using a single line of code. 
It is useful for applying an operation or filter to elements in an iterable 
structure such as a list or range.
"""
Square = [x**2 for x in range(1, 6)]
print(Square)



"""
How does Python List store data? Python lists don't store the original versions of 
data within the list itself. They hold the reference addresses of those values. The 
list only points to these objects using their reference addresses. In fact, when the
 value changes, it's not the object in the index that changes, but its reference.
"""