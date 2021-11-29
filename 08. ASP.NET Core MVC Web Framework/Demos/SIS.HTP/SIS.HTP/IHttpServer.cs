namespace SIS.HTTP
{
    using System.Threading.Tasks;

    public interface IHttpServer 
    {
        // What I want to have my HTTP server:

        Task StartAsync();

        Task ResetAsync();

        void Stop();
    }
}