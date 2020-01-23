﻿using System.ComponentModel.DataAnnotations;
using System;
//TODO: Add the library for Data Annotations
namespace LuckySpin.Models
{
    public class Player
    {
        //TODO: Include two annotations for FirstName
        // one that makes it Required (no empty strings)
        // and another that sets its Display prompt to "Your First Name"
        [Required()]
        [Display(Prompt = "Please enter your name")]
        public string FirstName { get; set; }
        //TODO: Include one annotation for LuckyNumber
        // one that limits its Range between 1 and 9
        [Range(1, 9, ErrorMessage ="Choose a number")]
  
        public int LuckyNumber { get; set; }
    }
}