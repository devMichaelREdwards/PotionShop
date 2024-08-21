using System.Security.Claims;
using Api.Data;
using Api.Models;
using AutoMapper;

namespace Api.Classes;

public class EmployeeUser
{
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required EmployeeDto Employee { get; set; }
}
