namespace mediators;

public interface IMediator
{
    void Notify(object sender, string env);
}
