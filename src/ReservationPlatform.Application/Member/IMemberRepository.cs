using ReservationPlatform.Domain;

public interface IMemberRepository
{
    Task<bool> CheckEmailExistsAsync(string email);   
    Task AddAsync(Member member);                      
}