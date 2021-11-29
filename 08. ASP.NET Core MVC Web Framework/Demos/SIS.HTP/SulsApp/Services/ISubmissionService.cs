namespace SulsApp.Services
{
    public interface ISubmissionService
    {
        void Create(string userId, string problemId, string code);

        void Delete(string id);
    }
}
