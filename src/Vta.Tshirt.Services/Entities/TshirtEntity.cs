namespace Vta.Tshirt.Services.Entities;

public class TshirtEntity
{
    public TshirtEntity()
    {
    }

    public TshirtEntity(int id, string size)
    {
        Id = id;
        Size = size;
    }

    public int Id { get; set; }

    public string Size { get; set; }
}
