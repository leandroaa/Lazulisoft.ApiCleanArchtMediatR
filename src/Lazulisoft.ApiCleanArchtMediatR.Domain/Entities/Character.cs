﻿using Lazulisoft.ApiCleanArchtMediatR.Domain.Enums;

namespace Lazulisoft.ApiCleanArchtMediatR.Domain.Entities
{
    public class Character : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public string Homeworld { get; set; }

        public string Species { get; set; }

        public Gender Gender { get; set; }

        public string Occupation { get; set; }
    }
}
