﻿using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperatorController : ControllerBase
    {
        [HttpGet(Name = "GetOperators")]
        public IActionResult GetOperators()
        {
            List<OperatorModel> operatorsData = new()
            {   new() {
                    Id = Guid.NewGuid(),
                    OpId = "ZUL43571",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-12-28 16:56:56"),
                    OpName = "Jesse Reyes",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "AAR77840",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-06-05 21:59:46"),
                    OpName = "Portia Valencia",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "QYD63738",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-11-23 11:04:32"),
                    OpName = "Zoe Mcclain",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "KMI95423",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-07-29 12:02:12"),
                    OpName = "Keelie Robles",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "EPK09885",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-11-05 15:44:09"),
                    OpName = "Lacey Burt",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "CKB14208",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-11-19 02:06:41"),
                    OpName = "Grady Lawson",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "IQQ24386",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-12-06 03:03:16"),
                    OpName = "Nyssa Kline",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "ITO78786",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-08-31 03:16:36"),
                    OpName = "Clarke Woodard",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "AJJ22657",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2026-02-15 00:37:33"),
                    OpName = "Yoshi Black",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "ZMJ33759",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-09-08 08:56:36"),
                    OpName = "Lillith Sargent",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "DWG89375",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-03-13 21:44:12"),
                    OpName = "Leila Mitchell",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "YAJ32376",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-03-18 15:04:27"),
                    OpName = "Quinn Small",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "IFG33348",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-07-11 06:30:59"),
                    OpName = "April Sandoval",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "LRD77463",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-11-16 00:08:38"),
                    OpName = "Stacey Elliott",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "BKC15346",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2026-01-02 03:58:35"),
                    OpName = "Shad Ramos",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "VVL18232",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-06-25 14:06:41"),
                    OpName = "Alma Casey",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "QZY93186",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-10-23 17:26:36"),
                    OpName = "Uriah Hart",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "DYU10698",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-10-02 20:06:53"),
                    OpName = "Karly Crawford",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "SGE56460",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2026-01-15 13:34:22"),
                    OpName = "Courtney Mooney",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "RCD07206",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-11-29 20:10:05"),
                    OpName = "Melyssa Bush",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "RFS36865",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-11-09 08:42:06"),
                    OpName = "Eugenia Henry",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "WPV57414",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-03-17 17:53:58"),
                    OpName = "Phillip Mcgee",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "LPT96655",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-03-24 13:33:16"),
                    OpName = "Adrian Bishop",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "JDB55175",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-09-08 13:38:30"),
                    OpName = "Marshall Hartman",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "QNJ37565",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-08-09 07:47:43"),
                    OpName = "Christian Strickland",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "GPE74514",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-11-30 03:27:57"),
                    OpName = "Burton Bryant",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "PJJ15294",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-06-24 08:52:54"),
                    OpName = "Fallon Paul",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "XHX58148",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-06-22 02:01:43"),
                    OpName = "Jade Mcpherson",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "YJV41884",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-09-15 10:15:16"),
                    OpName = "Berk Ward",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "MFN25796",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2026-02-19 11:32:41"),
                    OpName = "Hoyt Hughes",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "ZQQ41160",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-03-19 01:24:51"),
                    OpName = "Mechelle Pena",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "PCJ68053",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-04-15 19:08:58"),
                    OpName = "Vera Osborn",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "VJC86814",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2026-01-01 03:54:07"),
                    OpName = "Laurel Gilliam",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "HCR90122",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-03-29 22:39:31"),
                    OpName = "Xena Small",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "JKP51385",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-11-15 01:40:13"),
                    OpName = "Beau Hoover",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "NFC71397",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-07-24 07:52:29"),
                    OpName = "Ignacia Callahan",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "YYU04452",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-07-26 22:58:15"),
                    OpName = "Akeem Schneider",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "VLF77988",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-07-03 02:57:12"),
                    OpName = "Keefe Heath",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "OFG68734",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-08-04 13:38:06"),
                    OpName = "Ronan Levy",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "BOV52226",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-02-21 12:05:01"),
                    OpName = "Beverly Wade",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "YKE92475",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-02-12 21:53:34"),
                    OpName = "Isabella Lang",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "BNX93753",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-05-04 22:41:45"),
                    OpName = "Kellie Gray",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "FRP08712",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-06-12 05:59:45"),
                    OpName = "Winifred Johns",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "OBQ14306",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-08-03 11:31:26"),
                    OpName = "Isaac Anthony",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "TNE83665",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-04-12 05:39:15"),
                    OpName = "Amy Sexton",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "ISU85294",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-11-23 19:49:50"),
                    OpName = "Oleg Riggs",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "XSF73085",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-04-06 20:54:57"),
                    OpName = "Cooper Gilbert",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "BET49104",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-09-22 11:46:54"),
                    OpName = "Colby Rojas",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "TDM22870",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-12-29 07:26:54"),
                    OpName = "Colette Carey",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "KVZ32674",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-01-17 14:55:33"),
                    OpName = "Maggy Flynn",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "PYM51528",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-05-13 21:47:38"),
                    OpName = "Dante Moses",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "MBI78199",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-01-29 22:13:00"),
                    OpName = "Nero Durham",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "RLD37753",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-01-26 15:48:29"),
                    OpName = "Kenneth Hewitt",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "JNU13941",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-03-03 16:01:31"),
                    OpName = "Dillon Day",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "TQK68307",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-12-06 18:29:52"),
                    OpName = "Simon Cole",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "SXV52297",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2026-02-02 01:03:09"),
                    OpName = "Sybil Buck",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "LZS64863",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-05-28 18:07:31"),
                    OpName = "Nomlanga Mckee",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "CEP38535",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-03-12 00:52:42"),
                    OpName = "Karleigh Jarvis",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "ZDH66956",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-12-23 04:02:31"),
                    OpName = "Leah Benton",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "GIB51768",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-06-16 01:20:24"),
                    OpName = "Coby Villarreal",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "MRE63381",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-07-26 10:20:16"),
                    OpName = "Adam Mcbride",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "PEA61826",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-10-11 14:46:25"),
                    OpName = "Bo Sweet",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "SFL74852",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-07-24 14:15:24"),
                    OpName = "Maya Gallagher",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "EQF27257",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-05-25 13:42:33"),
                    OpName = "Denton Vasquez",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "CHI88424",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-06-03 21:59:33"),
                    OpName = "Oliver Goff",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "YDI61615",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-04-26 22:05:01"),
                    OpName = "Branden Morales",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "HQY46353",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-02-01 09:17:23"),
                    OpName = "Moana Hogan",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "HZD65778",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-09-24 12:22:33"),
                    OpName = "Holmes Nash",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "GDM61253",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-04-12 21:18:40"),
                    OpName = "Iona Koch",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "YTI87363",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2026-02-20 20:50:22"),
                    OpName = "Jayme Mooney",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "HKT13311",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-12-17 19:43:39"),
                    OpName = "Emery Stone",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "RUM14158",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-09-24 02:44:59"),
                    OpName = "Oliver Hurst",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "UQG74377",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-09-27 23:57:46"),
                    OpName = "Yoshio Lang",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "VLY56402",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-03-12 19:28:24"),
                    OpName = "Ingrid Chan",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "HZW30685",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-07-12 17:31:04"),
                    OpName = "Blake Dawson",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "MJQ78333",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-10-20 22:03:49"),
                    OpName = "Gray Leon",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "FPB02323",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-05-17 19:26:49"),
                    OpName = "Bradley Hernandez",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "FDM17461",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-12-08 08:45:21"),
                    OpName = "Kiona Soto",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "XDM73146",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-08-30 18:16:02"),
                    OpName = "Aurelia Stevens",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "JPT63822",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-12-28 09:12:12"),
                    OpName = "Dacey Beasley",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "AWQ72365",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-01-29 00:05:21"),
                    OpName = "Russell Davis",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "HVQ95771",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-12-21 12:46:17"),
                    OpName = "Burke Patel",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "JOP79526",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-12-14 13:00:04"),
                    OpName = "Rigel Meadows",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "GSK85811",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-11-05 04:19:10"),
                    OpName = "Aphrodite Alford",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "QVT21434",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-06-10 20:33:36"),
                    OpName = "Erich Stevenson",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "NKV32942",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-06-04 06:47:44"),
                    OpName = "Marvin Sharpe",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "RCD83674",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-08-31 04:34:43"),
                    OpName = "Norman Joseph",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "VRW06446",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2024-05-22 20:33:27"),
                    OpName = "Quon Bean",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "PRG57951",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-10-31 09:52:01"),
                    OpName = "Madaline Cabrera",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "TMC38117",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2026-02-07 16:37:43"),
                    OpName = "Halla Cantrell",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "NDJ48161",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "Admin",
                    ChangedTime = DateTime.Parse("2025-12-26 12:03:18"),
                    OpName = "Marvin Guy",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "SPI73583",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-04-21 01:03:30"),
                    OpName = "Rebekah Bright",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "SOC83341",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-09-17 04:32:05"),
                    OpName = "Kirk Good",
                    Description = "Night"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "OQY53276",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-07-16 15:08:27"),
                    OpName = "Shana Benjamin",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "XCU92698",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-09-19 04:09:15"),
                    OpName = "Wendy Moreno",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "DPM95319",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-04-02 11:47:45"),
                    OpName = "Ezra Hendricks",
                    Description = "Evening"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "GQY60872",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-04-25 21:12:03"),
                    OpName = "Carla Gould",
                    Description = "Day"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "CVN83632",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-09-12 01:10:22"),
                    OpName = "Travis Mckay",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "AFI36667",
                    Access1 = true,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2024-10-12 00:07:34"),
                    OpName = "Winifred Herring",
                    Description = "Afternoon"
                },
                new() {
                    Id = Guid.NewGuid(),
                    OpId = "GWT24861",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "WebGUI",
                    ChangedTime = DateTime.Parse("2025-04-21 05:15:07"),
                    OpName = "Lois Giles",
                    Description = "Evening"
                },
            };
            Random random = new();
            int[] possibleBatchSizes = { 20, 40, 60, 80, 100 };
            int randomSize = possibleBatchSizes[random.Next(possibleBatchSizes.Length)];

            var selectedOperators = operatorsData.Take(randomSize).ToList();

            return Ok(selectedOperators);
        }
    }
}

