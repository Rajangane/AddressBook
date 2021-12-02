// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Address Book *****************");
using AddressBook;
Console.Write("Select Number:\n1)CreateContacts\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new UC1_CreateContacts().DisplayContacts();
        break;

    default:
        Console.Write("Please Select Correct Number");
        break;
}