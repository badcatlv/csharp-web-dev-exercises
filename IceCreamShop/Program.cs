using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.
FlavorComparer comparer = new FlavorComparer();
availableFlavors.Sort(comparer);
//availableFlavors.Sort(new FlavorComparer()); //short hand version

// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
availableCones.Sort(new ConeComparer());
foreach (Flavor f in availableFlavors)
{
    Console.WriteLine(f.Name + ": " + f.Cost);
}
foreach (Cone c in availableCones)
{
    Console.WriteLine(c.Name + ": " + c.Cost);
}

// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.