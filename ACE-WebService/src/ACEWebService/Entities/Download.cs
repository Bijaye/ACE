﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACEWebService.Entities
{
    public class Download
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string ComputerName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FullPath { get; set; }
        [Required]
        public byte[] Content { get; set; }
        [Required]
        public DateTime DownloadTime { get; set; }
    }
}