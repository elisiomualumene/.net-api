
using Entity;
using Microsoft.AspNetCore.Mvc;
using UseCases;

namespace movie_api.Controllers;
[Route("[controller]")]
[ApiController]
public class TestController : ControllerBase {

    [HttpGet(Name = "GetTest")]
    public TestEntity Get(){
        string name = "mualumene";

        TestUseCase test = new();

        string value = test.Execute(name);

        TestEntity entity = new() { Name = value};

        return entity;
    }
}