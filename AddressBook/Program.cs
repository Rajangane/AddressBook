// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Address Book *****************");
using AddressBook;
Console.Write("Select Number:\n1)CreateContacts\n2)AddNewContacts\n3)EditContacts\n4)DeleteContacts\n5)AddingMultiplePerson\n6)UniqueName\n");
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
    case 4:
        DeleteContacts.NewContact();
        DeleteContacts.ListContacts();
        DeleteContacts.RemovePerson();
        break;
    case 5:
        Adding_MultiplePerson.NewContact();
        Adding_MultiplePerson.ListPeople();
        Adding_MultiplePerson.AddNew();
        break;
    case 6:
        Unique_Name.ContactDetails();
        Unique_Name.ListAllPeople();
        Unique_Name.AddUniqueAddress();
        break;



    default:
        Console.Write("Please Select Correct Number");
        break;
}