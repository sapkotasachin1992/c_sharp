//to get the access of file class and it's methods we have to import the Namespace System.IO
using System.IO;


internal class FileIO
{
    public void LearnFileReading()
    {
        //let of tell you something..
        // File f=new File();
        //as file is a class then why we  do not need to create object of that file to access it's properties.
        // The reason is The File class is static class. you can go and see. which means all the methods and properties can be directly accessed through class Name
        //so below is possible
        //to read existing files
        string result = File.ReadAllText(@"/home/proxima/Desktop/c_sharp/README.md");//we use @ to tell that the path we are providing is completly string .we are doing this because it causes problem in windows path as it uses fordward slash and compiler read it as escape or sequence or say /n or /t these type of things.so we have to do this.
        Console.WriteLine(result);

        //what if the file doesnot exits .so first we have to check whether the target file exits or not.
        bool isFile = File.Exists("/home/proxima/Desktop/c_sharp/README.md");
        if (isFile)
        {
            File.ReadAllText("/home/proxima/Desktop/c_sharp/README.md");
            // File.ReadAllLines(""); //return each lines in array form

        }


    }

    public void LearnFileWriting()
    {
        string filePath = "Abc.txt";
        File.WriteAllText(filePath, "hi i am sachin"); //remember if you hover this WriteAllText it returns void which means you can not assign any variable for void return type.
        if (File.Exists("Abc.txt"))
        {
            Console.WriteLine(File.ReadAllText("Abc.txt"));//if file already exit the content will be override in it
        }

    }

    public void LearnFileInfo()
    {
        string filePath = "Abc.txt";
        FileInfo fileinfo = new FileInfo(filePath);//filepath is passed as constructor
        var filesize = fileinfo.Length;
        var createDate = fileinfo.CreationTime;
    }

    public void LearnDirectory()
    {
        //Directory is also static class means you can directly access it
        string folderPath = "ABC"; //for now we have given relative path but you can give absolute path too like home/proxima/Desktop/c_sharp/ABC

        Directory.CreateDirectory(folderPath);
        Directory.Delete(folderPath);
        Directory.GetLogicalDrives();//there are more different things to explore
    }
}