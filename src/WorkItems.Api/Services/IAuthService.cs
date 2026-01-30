namespace WorkItems.Api.Services;

using WorkItems.Api.Contracts.Auth;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(string username, string email, string password);
    Task<AuthResponse> LoginAsync(string usernameOrEmail, string password);
}
