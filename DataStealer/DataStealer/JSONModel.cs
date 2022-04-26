namespace DataStealer.JObjects;

public class JSONModel
{
    public bool Success { get; set; }          // Successfulity bool.
    public JSONProduct? Product { get; set; }  // Product data.
}

public class JSONProduct
{
    public string? OnlineDescription { get; set; }      // Full paint's title.
    public double? PriceInclTax { get; set; }           // Current price.
    public JSONBrand? Brand { get; set; }               // Brand data.
    public JSONScanCode? DefaultScanCode { get; set; }  // EAN data.

    // Recommended price has a "Adviesprijs" code.
    public JSONField[]? Fields { get; set; }            // Fields array.

    // Find "TextMemo" for color and volume.
    // <td>Kleur:</td><td>Wit en op kleur te mengen</td></tr>
    // <tr><td>Inhoud:</td><td>1 liter, 5 liter of 10 liter</td></tr>
    public JSONMemo[]? Memos { get; set; }              // Memos array.
}

public class JSONBrand
{
    public string? Description { get; set; }  // Brand title.
}

public class JSONScanCode
{
    public string? Code { get; set; }  // EAN code.
}

public class JSONField
{ 
    public string? Code { get; set; }   // Field title.
    public string? Value { get; set; }  // Field value.
}

public class JSONMemo
{
    public string? MemoType { get; set; }
    public string? Text { get; set; }
}
