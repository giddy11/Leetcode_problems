// See https://aka.ms/new-console-template for more information


List<string> mostActive (List<string> customers)
{
    var customerCounts = new Dictionary<string, int>();

    foreach (var customer in customers)
    {
        if (customerCounts.ContainsKey(customer))
        {
            customerCounts[customer]++;
        }
        else
        {
            customerCounts[customer] = 1;
        }
    }

    var filteredCustomers = customerCounts
        .Where(kv => kv.Value >= 5)
        .Select(kv => kv.Key)
        .OrderBy(customer => customer)
        .ToList();

    return filteredCustomers;
}

List<string> list = new List<string>() 
{
    "Bigcorp",
    "Bigcorp",
    "Acme",
    "Bigcorp",
    "Zork",
    "Zork",
    "Abc",
    "Bigcorp",
    "Acme",
    "Bigcorp",
    "Bigcorp",
    "Zork",
    "Bigcorp",
    "Zork",
    "Zork",
    "Bigcorp",
    "Acme",
    "Bigcorp",
    "Acme",
    "Bigcorp",
    "Acme",
    "Littlecorp",
    "Nadircorp"
};

mostActive(list);

Console.WriteLine();