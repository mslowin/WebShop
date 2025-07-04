namespace WebShop.Application.Interfaces;

public interface IItemService
{
    public List<int> GetItems();
    public int GetItems(int id);
}
