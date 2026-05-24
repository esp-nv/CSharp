namespace Logger.Models.Contracts;
public interface IFile
{
    //ILayout Layout { get; }
    string Path { get; }

    long Size { get; }

    //той никаде не пише, просто ще връне форматираното съобщение

    //String.Format(format,data)
    //format ->идва от ILayout
    //data ->error
    //това нещо ще трябва в FileAppender
    string Write(ILayout layout, IError error);

}
