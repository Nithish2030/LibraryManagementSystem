using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmt
{
    //Inheritence
    public class EBook : Book
    {
        public int FileSize { get; set; }

        // Constructor
        public EBook(string title, string author, string isbn, bool available, int fileSize)
            : base(title, author, isbn, available)
        {
            FileSize = fileSize;
        }

        //To include file size attribute
        public override string ToString()
        {
            return base.ToString() + $", File Size: {FileSize} MB";
        }
    }

}
