using System;

namespace mvctest.Models;

public interface IStaffRepository
{
    IEnumerable<Staff> AllStaff { get; }
    Staff? GetStaffById(int staffId);
}
