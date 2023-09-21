Dictionary<String, List<int>> dict_aankopen = new Dictionary<String, List<int>>();
dict_aankopen.Add("jan", new List<int>() { 100, 50, 20 });
dict_aankopen.Add("piet", new List<int>() { 10, 70, 20, 4, 58, 542 });
dict_aankopen.Add("karel", new List<int>() { 9 });
dict_aankopen.Add("sandra", new List<int>() { 45, 45, 10 });

List<string> expensiveBaskets = GetExpensiveShoppingBaskets(dict_aankopen, 200);


foreach (var person in expensiveBaskets)
{
    Console.WriteLine(person);
}

List<string> GetExpensiveShoppingBaskets(Dictionary<string, List<int>> baskets, int threshold)
{
    List<string> returnValue = new List<string>();
    foreach (var person in baskets.Keys)
    {
        List<int> basket = baskets[person];
        int som = basket.Sum();
        if (som > threshold)
        {
            returnValue.Add(person);
        }
    }
    return returnValue;
}

