
using System;
using System.Collections.Generic;

public class SponsorService
{
    private static List<SponsorResponseDTO> data = new();

    public IEnumerable<SponsorResponseDTO> GetAll()
    {
        return data;
    }

    public SponsorResponseDTO Create(SponsorRequestDTO dto)
    {
        var sponsor = new SponsorResponseDTO
        {
            Id = data.Count + 1,
            Name = dto.Name
        };

        data.Add(sponsor);
        return sponsor;
    }
}
