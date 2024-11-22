namespace cs_functional_programming;

public class ListManager
{
    public List<string> nameList = new List<string>();

    public ListManager(List<string> nameList)
    {
        this.nameList = nameList;
    }

    public List<string> Filter(Predicate<string> predicate)
    {
        return nameList.Where(new Func<string, bool>(predicate)).ToList();
    }
}