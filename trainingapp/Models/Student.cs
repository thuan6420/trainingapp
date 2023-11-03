using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace trainingapp.Models
{
    public enum TypeGender
    {
        Male,
        Female
    }

	public class Student
	{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Email { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [BindProperty]
        public TypeGender Gender { get; set; }

        string ConvertGender()
        {
            if (Gender == TypeGender.Female)
            {
                return "Nữ";
            } else
            {
                return "Nam";
            }
        }
    }
}

