﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        [Required]
        public int? NumberInStock { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;

        }

        public string Title { get { return Id != 0 ? "Edit Movie" : "New Movie"; } }
    }
}