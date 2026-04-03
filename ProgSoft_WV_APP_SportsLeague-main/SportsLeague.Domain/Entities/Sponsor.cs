
using System;
using System.Collections.Generic;
using SportsLeague.Domain.Enums;

public class Sponsor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContactEmail { get; set; }
    public string Phone { get; set; }
    public string WebsiteUrl { get; set; }
    public SponsorCategory Category { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public ICollection<TournamentSponsor> TournamentSponsors { get; set; }
}
