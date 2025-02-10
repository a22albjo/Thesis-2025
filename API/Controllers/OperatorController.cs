using Microsoft.AspNetCore.Mvc;
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
            { new() {
                    Id = Guid.NewGuid(),
                    OpId = "fds456",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Rufus",
                    Description = "Afternoon"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "afg146",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Mattis",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "64fy32" ,
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Lars",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "432jjt",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Ida",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "jgj423342",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Åsa",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "435272",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Mia",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "7u42542",
                    Access1 = false,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Muhammed",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "y54gtr4",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Xi",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "32gretr", //32gretr",
                    Access1 = true,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Lee",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "5uyrwe", //",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Ahmed",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "8634gre",
                    Access1 = false,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Karin",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "ewg43",
                    Access1 = false,
                    Access2 = false,
                    Access3 = false,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Rosa",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "hr432",
                    Access1 = true,
                    Access2 = true,
                    Access3 = false,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Petter",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "qsw563",
                    Access1 = false,
                    Access2 = true,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Egon",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "ii675",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Kia",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "2tgfr3",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Tobias",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "327uy2",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Charles",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "uj6323",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Robert",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "i5645",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Ina",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "25562yy",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Love",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "8434te",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Ahmed",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "eri453",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Lisa",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "jdf432",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Tage",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "857utt",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Amini",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "153jhr",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Pelle",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "8645yre",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Simon",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "864yer",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Sam",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "863erty",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Hector",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "2535ye",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Olle",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "89659utr",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Selma",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "it432",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Pia",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "9863hter",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Hamid",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "9864rewy",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Amanda",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "wey478",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Xi",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "i5546",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Manne",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "9856yrt",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Filip",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "246ury",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Linus",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "9764ytr",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Stina",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "06ytr",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Ulla",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "45i54u",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Lina",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "3463yyt",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Klara",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "nty645",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Tomas",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "g445",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Doris",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "y4uy4",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Rana",
                    Description = "Night"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "78955uj7",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Julie",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "36y335y",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "August",
                    Description = "Evening"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "897545",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Ylva",
                    Description = "Morning"
                },
                new OperatorModel{
                    Id = Guid.NewGuid(),
                    OpId = "843333",
                    Access1 = true,
                    Access2 = false,
                    Access3 = true,
                    ChangedBy = "ger",
                    ChangedTime = DateTime.Now,
                    OpName = "Pål",
                    Description = "Evening"
                }
            };
            return Ok(operatorsData);
        }
    }
}

