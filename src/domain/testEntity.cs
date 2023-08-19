using Utilities;

namespace Entity;

public class TestEntity {
    public string Id {get;}

    public TestEntity(){
        Id = UUID.V4();
    }

    public required string Name {get; set;}
}