using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RazorCrud
{
    public class Customer
    {
        public int Id { get; set; }

        [Required,MaxLength(49)]
        public string Name { get; set; }

        [Required,MaxLength(20)]
        public string Email { get; set; }
    }
}