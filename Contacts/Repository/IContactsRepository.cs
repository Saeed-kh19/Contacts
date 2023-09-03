using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal interface IContactsRepository
    {
        DataTable showAll();
        DataTable SelectRow(int Id);
        DataTable Search(string parameter);
        DataTable SearchPhone(string parameter);
        bool Insert(string name, string number, string email, int age, string address);
        bool Delete(int id);
        bool Update(int id, string name, string number, string email, int age, string address);
    }
}
