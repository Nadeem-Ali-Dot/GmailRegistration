using GmailRegistration.Models;

namespace GmailRegistration.Services
{
    public interface IRegistrationSessionService
    {
        Task<RegistrationSession> GetOrCreateSessionAsync(string? registrationId);
        Task<RegistrationSession> CreateNewSessionAsync();
        Task SaveChangesAsync();
        Task DeleteSessionAsync(RegistrationSession session);
    }
}
