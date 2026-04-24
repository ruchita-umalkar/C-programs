// REST API with File Upload/Download 
using System;
using System.IO;    
class FileController
{
    public void UploadFile(string filePath)
    {
        // Code to handle file upload
        if (File.Exists(filePath))
        {
            Console.WriteLine("File uploaded successfully.");
        }
        else
        {
            Console.WriteLine("File upload failed.");
        }
    }

    public void DownloadFile(string fileName)
    {
        // Code to handle file download
        string filePath = Path.Combine("uploads", fileName);
        if (File.Exists(filePath))
        {
            Console.WriteLine("File downloaded successfully.");
        }
        else
        {
            Console.WriteLine("File download failed.");
        }
    }
}