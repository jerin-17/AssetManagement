﻿using System.ComponentModel.DataAnnotations;

namespace AssetManagementAPI.Model
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
