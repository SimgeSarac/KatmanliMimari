using System;
using System.Collections.Generic;
using System.Text;

namespace Katmanli_AutoMapper.Entity
{
    public class FilterRepositoryDto
    {
        public string CompanyName { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return $"{CompanyName}";
        }
    }
}
