using OmniReserve.Domain.Enums;

namespace OmniReserve.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public Role Role { get; private set; }

    public User(string firstName, string lastName, string email, string passwordHash, Role role)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentNullException(nameof(firstName), "El nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new ArgumentNullException(nameof(lastName), "El apellido es obligatorio.");

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentNullException(nameof(email), "El correo electrónico es obligatorio.");

        if (string.IsNullOrWhiteSpace(passwordHash))
            throw new ArgumentNullException(nameof(passwordHash), "El hash de contraseña es obligatorio.");

        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }
}