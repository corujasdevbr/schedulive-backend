﻿using CorujasDev.Schedulive.Core.DomainObjects;
using Flunt.Validations;
using System.Collections.Generic;

namespace CorujasDev.Schedulive.Domain.Entities
{
    public class CategoryDomain : Entity
    {
        public string Name { get; private set; }
        public List<LiveDomain> Lives { get; set; }

        public CategoryDomain(string name)
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(name, "Firstname", "FirstName is required")
            );

            if (Valid)
            {
                Name = name;
            }
        }
    }
}
