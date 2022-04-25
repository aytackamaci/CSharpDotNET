using static System.Console;

//ThisCannotBeNull = null;

int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());


Address address = new();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;

string? authorName = null;

int? y = authorName?.Length;

int result = authorName?.Length ?? 3;
WriteLine(result);

class Address
{
    public string? Building;
    public string? Street = string.Empty;
    public string City = string.Empty;
    public string? Region = string.Empty;
}




