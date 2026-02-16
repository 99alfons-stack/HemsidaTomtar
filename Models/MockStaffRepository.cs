using System;

namespace mvctest.Models;

public class MockStaffRepository : IStaffRepository
{
    public IEnumerable<Staff> AllStaff =>
    new List<Staff>
    {
        new Staff { StaffId = 1, Name = "Bengt", Admin = false, Age = 52, Email = "BengtNord@gmail.com", Bio = "Bengt är en skicklig träarbetare med över 30 års erfarenhet.\n Han älskar att skapa detaljer och är känd för sitt noggranna arbete. Hans passion för traditionellt hantverk gör varje tomte till ett mästerverk." },
        new Staff { StaffId = 2, Name = "Marie", Admin = true, Age = 55, Email = "MarieHern@gmail.com", Bio = "Marie är företagets grundare och ledare. Hon designar och planerar alla nya kollektion med passion och kreativitet. \n Med hennes vision har Tre Träiga Tomtar blivit känt för unika och vackra tomtefigurer." },
        new Staff { StaffId = 3, Name = "Åke", Admin = false, Age = 59, Email = "Åkesson@gmail.com", Bio = "Åke är vår specialist på målning och finishing. Han ger varje tomte sin egen personlighet och charm genom sitt konstnärliga arbete. \n Hans färgval och detaljer gör varje figur till något speciellt." }
    };

    public Staff? GetStaffById(int staffId) => AllStaff.FirstOrDefault(s => s.StaffId == staffId);
}
