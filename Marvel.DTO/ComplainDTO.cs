using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Marvel.DTO
{
    public class ComplainDTO
    {
        [JsonProperty("Guid")]
        public Guid Guid { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string SurName { get; set; }
        [JsonProperty("Email")]
        [MinLength(6)]
        public string Email { get; set; }
        [Required]
        public Need Need { get; set; }
        [Required]
        [MinLength(5)]
        public string Message { get; set; }
        public ComplainDTO()
        {
            Guid = Guid.NewGuid();
        }
    }
    public enum Need { INVOICE, STATUS, CASHBACK, OTHER }
}
