﻿namespace ContactAPI.Models
{
    public class AddContactRequest
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public long Phone { get; set; }
        public string? Address { get; set; }
    }
}
