using FolderSelect;
using System;

namespace GetDirectory
{
    class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
           var openFileDialog = new FolderSelectDialog
            {
                Title = args.Length > 0 ? args[0] : null,
                InitialDirectory = args.Length > 1? args[1] : null
            };
            if (openFileDialog.ShowDialog())
            {
                //Get the path of specified file
                Console.Write(openFileDialog.FileName);
                return 0;
            }

            return 1;
        }
    }
}
