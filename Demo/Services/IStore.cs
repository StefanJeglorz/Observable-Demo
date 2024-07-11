namespace Demo;

public interface IStore
{
    public event EventHandler<List<string>> OnCatalogChanged;

    public List<string> Catalog { get; }
    
    public void AddStoreItem(string item);
    public void RemoveStoreItem(string item);
}
