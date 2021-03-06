﻿using System.Collections.Generic;

namespace Pub.App.Core.DTOs
{
    public class ManagerDto
    {
        public ManagerDto()
        {
            this.EmployeesDto = new HashSet<EmployeeDto>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int EmployeesCount => EmployeesDto.Count;  

        public ICollection<EmployeeDto> EmployeesDto { get; set; }
    }
}
