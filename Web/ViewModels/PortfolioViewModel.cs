﻿namespace Web.ViewModels
{
    public class PortfolioViewModel
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string? ImageUrl { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }
    }
}
