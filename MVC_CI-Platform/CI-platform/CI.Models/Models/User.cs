﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CI.Models;

public partial class User
{
    public long UserId { get; set; }
    [Required(ErrorMessage = "FirstName can't be null")]
    public string? FirstName { get; set; }
    [Required(ErrorMessage = "FirstName can't be null")]

    public string? LastName { get; set; }
    [Required(ErrorMessage = "FirstName can't be null")]

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Avatar { get; set; }

    public string? WhyIVolunteer { get; set; }

    public string? EmployeeId { get; set; }

    public string? Department { get; set; }

    public long? CityId { get; set; }

    public long? CountryId { get; set; }

    public string? ProfileText { get; set; }

    public string? LinkedInUrl { get; set; }

    public string? Title { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Availablity { get; set; }

    public string? Manager { get; set; }

    public string? Role { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<FavoriteMission> FavoriteMissions { get; } = new List<FavoriteMission>();

    public virtual ICollection<MissionApplication> MissionApplications { get; } = new List<MissionApplication>();

    public virtual ICollection<MissionInvite> MissionInvites { get; } = new List<MissionInvite>();

    public virtual ICollection<MissionRating> MissionRatings { get; } = new List<MissionRating>();

    public virtual ICollection<Story> Stories { get; } = new List<Story>();

    public virtual ICollection<StoryView> StoryViews { get; } = new List<StoryView>();

    public virtual ICollection<UserSkill> UserSkills { get; } = new List<UserSkill>();
}
