namespace Kmarchant.Home.Models;

public record Resume(
    string Title,
    string Description,
    string Author,
    Profile Profile,
    List<Contact> Contacts,
    List<Education> Education,
    List<Interest> Interests,
    Summary Summary,
    Experience Experience,
    List<string> Skills
);
