﻿namespace BlazorApp1.Models;

public class RegisterDto
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string ConfirmPassword { get; set; } = "";
}
