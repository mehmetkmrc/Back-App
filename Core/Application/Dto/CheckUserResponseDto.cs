﻿namespace UdemyJwtApp.Back.Core.Application.Dto
{
    public class CheckUserResponseDto
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsExist { get; set; }
        public string? Role { get; internal set; }
    }
}