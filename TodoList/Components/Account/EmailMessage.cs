﻿using System.ComponentModel.DataAnnotations;

namespace TodoList.Components.Account
{
    public class EmailMessage
    {
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Subject { get; set; } = string.Empty;

        [Required]
        public string Message { get; set; } = string.Empty;
    }
}
