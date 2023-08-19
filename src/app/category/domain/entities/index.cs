using Utilities;

namespace Entity;
public class Category : Entity {
    public string Id {get;}
    public required string Name {get; set;}
    public DateTime Created_at {get; set;}

    public Category(){
        Id = UUID.V4();
        Created_at = DateTime.Now;
    }

}