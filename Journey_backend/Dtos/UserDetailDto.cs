﻿using System.ComponentModel.DataAnnotations;

namespace Journey.Dtos
{
    public class UserDetailDto
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string[]? Roles { get; set; }
        public string? PhoneNumber {  get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool PhonNumberConfirmed {  get; set; }
        public int AccessFailedCount {  get; set; }
    }
}