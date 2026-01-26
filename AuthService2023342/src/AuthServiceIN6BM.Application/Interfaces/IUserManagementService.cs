using AuthServiceIN6BM.Application.DTOs;
using AuthServiceIN6BM.Domain.Entities;

namespace AuthServiceIN6BM.Application.Interfaces;

public interface IUserManagementService
{
    Task<UserResponseDto> UpdateUserRoleAsync(string userId, string roleName);
    Task<IReadOnlyList<string>> GetUserRolesAsync(string userId);
    Task<IReadOnlyList<UserResponseDto>> GetUserByRoleAsync(string roleName);
}