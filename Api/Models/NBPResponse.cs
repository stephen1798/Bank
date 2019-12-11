using System.Collections.Generic;

public class Rate
{
    public string no { get; set; }
    public string effectiveDate { get; set; }
    public double mid { get; set; }
}

public class NBPResponse
{
    public string table { get; set; }
    public string currency { get; set; }
    public string code { get; set; }
    public List<Rate> rates { get; set; }
}