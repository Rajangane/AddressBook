// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Address Book *****************");
using AddressBook;
Console.Write("Select Number:\n1)CreateContacts\n2)AddNewContacts\n3)EditContacts");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new UC1_CreateContacts().DisplayContacts();
        break;
    case 2:
        UC2_AddNewContacts.DisplayNewContacts();
        UC2_AddNewContacts.ListPeople();
        UC2_AddNewContacts.AddNew();
        break;
    case 3:
        EditContacts.NewContact();
        EditContacts.ListAllContacts();
        EditContacts.Update();

        break;
         


    default:
        Console.Write("Please Select Correct Number");
        break;
}