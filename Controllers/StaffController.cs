using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using mvctest.Models;

namespace mvctest.Controllers;

public class StaffController : Controller /*paket vi använder*/
{

    //få tillgång vår service vå skapade

    private readonly IStaffRepository _staffRepository;


    public StaffController(IStaffRepository staffRepository)
    {
        _staffRepository = staffRepository;
    } 
public IActionResult Index()
    {
        ViewBag.message="Hej från personalen";

        return View(_staffRepository.AllStaff);


    }
    public IActionResult Info(int id)
    {
        var staff = _staffRepository.GetStaffById(id);

        return View(staff);


    }
}
