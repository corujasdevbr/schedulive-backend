﻿using CorujasDev.Schedulive.Core.DomainObjects;
using Flunt.Validations;
using System;

namespace CorujasDev.Schedulive.Domain.Entities
{
    public class LiveDomain : Entity
    {
        public string Title { get; private set; }
        public string Thumbnail { get; private set; }
        public string Description { get; private set; }
        public string Place { get; private set; }
        public DateTime DateTime { get; private set; }
        public Guid CategoryId { get; private set; }
        public CategoryDomain Category { get; private set; }

        public LiveDomain(string title, string thumbnail, string description, string place, DateTime dateTime, Guid categoryId)
        {

            AddNotifications(new Contract()
                .IsNotNullOrEmpty(title, "Title", "Title is required")
                .IsNotNullOrEmpty(thumbnail, "Thumbnail", "Thumbnail is required")
                .IsNotNullOrEmpty(description, "Description", "Description is required")
                .IsNotNullOrEmpty(place, "Place", "Place is required")
            );

            if (Valid)
            {
                Title = title;
                Thumbnail = thumbnail;
                Description = description;
                Place = place;
                DateTime = dateTime;
                CategoryId = categoryId;
            }
        }
    }
}
