using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Contracts;

// за улеснение на работата с различни файлове
public interface IIOManager
{
    //тук ще се съхранява само текущата директория в която пишем 
    string CurrentDirectoryPath {  get; }

    //тук ще се съхранява само текущата директория и фаила в които пишем 
    string CurrentFilePath { get; }

    //метод за взимане на текуща директория
    string GetCurrentDirectory();

    //метод които проверява дали съществува директорията и ако не я създава
    void EnsureDirectoryAndFileExist();
}
