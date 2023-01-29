namespace Kmarchant.Home.Models;

public record Job(string Position, string Company, string DateFrom, string DateTo, string Summary, List<string> Details);
    
