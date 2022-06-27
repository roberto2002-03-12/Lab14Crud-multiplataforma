using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14Crud.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
