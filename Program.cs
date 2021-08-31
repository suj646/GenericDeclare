using System;
using System.IO;


namespace genericdeclare
{

    class IOOps
    {
        static void Main(string[] args)
        {
            //craete a text file @"C:\Test\SampleFile.txt
            using (FileStream fs = new FileStream(@"F:\sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamWriter m_StramWriter = new StreamWriter(fs);
                //write to the file using StremWriter class
                m_StramWriter.BaseStream.Seek(0, SeekOrigin.End);     //stert from first(0 brigining till end)
                m_StramWriter.WriteLine("File Write Operation Starts");
                m_StramWriter.WriteLine("Welcome to the Sample file");
                m_StramWriter.WriteLine("This is next line in the text file");
                m_StramWriter.Flush();    //once write the strem clear the buffer or temporary memory
                //Test

            }  //the use using block is to claerthe iobject memory so at this point file will close if u use
            StreamReader m_StreamReader = new StreamReader(@"F:\sample.txt");
            string str;
            while ((str = m_StreamReader.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
    }
}
