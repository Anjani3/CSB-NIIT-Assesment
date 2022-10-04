
//1. Store age of person and print it (use 8-bit memory)
/*
Console.WriteLine("Enter the Age ");
byte AgeOfPerson = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Age of the persion "+AgeOfPerson);
*/

//2. Accept Price of product
/*
Console.WriteLine("Enter the price of product ");
float PriceOfprdt = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("The Price of product"+PriceOfprdt);
    */

//3. Calculate Loan amount of 10000 with 5%
/*
Console.WriteLine("Enter the Principle and interest");
double Principle = Convert.ToDouble(Console.ReadLine());
double Interest = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The loan amount = "+Convert.ToUInt32(Principle*Interest));
*/

//4. Print gender of user by storing it using approriate data type
/*
Console.WriteLine("Enter the Gender M/F/O ");
char gender = Convert.ToChar(Console.Read());
Console.WriteLine("Gender = "+gender);
*/

//5. Accept name of person and print it
/*
Console.WriteLine("Enter the Name of Person");
string name = Console.ReadLine();
Console.WriteLine("Name = "+name);
*/

//6. Get price of product from user and add 10% discount to it and print the price as a whole number
/*
Console.WriteLine("Enter the price of product");
float Price_Of_Prdt = Convert.ToSingle(Console.ReadLine());
Price_Of_Prdt = Price_Of_Prdt*0.1f;             // 10% = 10/100 (0.1)
Console.WriteLine("Price of the product after 10% discount = "+Convert.ToUInt32(Price_Of_Prdt));
*/

//7. Accept age of tree and print it
// input - Enter age of tree : 30.2
// Output - Age = 30
/*
Console.WriteLine("Enter the Age of tree");
float AgeOfTree = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Age of the tree : "+Convert.ToUInt16(AgeOfTree));
*/

//8. Accept details of Employee
// i/p - Enter the name of Employee : emp
//       Enter Address : 
//       Enter Mobile No. :
//       Enter gender : 
//       Enter Email : 
//       Enter DOB :

// O/P - Name: _____, Address: _____, Mobile: ____, Gender: ___, DOB: 12 september 2000
/*
string Emp_Name, Emp_Address, Emp_Email;
char Emp_Gender;
ulong Emp_Phone;
//DateTime Emp_DOB = new DateTime();
DateTime Emp_DOB;

Console.WriteLine("Enter the name of Employee :");
Emp_Name = Console.ReadLine();

Console.WriteLine("Enter the Address of Employee :");
Emp_Address = Console.ReadLine();

Console.WriteLine("Enter the Mobile number of Employee :");
Emp_Phone = Convert.ToUInt64(Console.ReadLine());

Console.WriteLine("Enter the Gender of Employee M/F :");
Emp_Gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Enter the Email Id of Employee :");
Emp_Email = Console.ReadLine();

Console.WriteLine("Enter the Date of birth of Employee :");
Emp_DOB = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Name: {0}, Address: {1}, Mobile: {2}, Gender: {3}, Email: {4}, DOB: {5} ",Emp_Name,Emp_Address,Emp_Phone,Emp_Gender,Emp_Email,Emp_DOB.ToLongDateString());
*/

//9. Create a float arraay which can accept 3 value and print it 

float[] arr = new float[3];

Console.WriteLine("Enter the 3 value in an array");

for(int i=0;i<3;i++)
{
    arr[i] = Convert.ToSingle(Console.ReadLine());
}
Console.Write("Value of Array : ");
for (int i = 0; i<3; i++)
{
    Console.Write(arr[i]+" ");
}

//10. Add 10 to 3rd in array and print it 
Console.WriteLine("Array after add 10 in 3rd value");
for (int i = 0; i<3; i++)
{
    if (i==2)
    {
        Console.Write(arr[i]+10);
    }
    else
    {
        Console.Write(arr[i]+", ");

    }
}
