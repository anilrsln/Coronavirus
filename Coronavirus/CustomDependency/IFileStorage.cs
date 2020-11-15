namespace Coronavirus.CustomDependency
{
    public interface IFileStorage
    {
        T Read<T>(string i_FileName);
    }
}
