namespace DataStealer;

/// <summary>
/// Краска.
/// </summary>
public class Paint
{
    /// <summary>
    /// Штрих-код.
    /// </summary>
    public string? EAN { get; set; }

    /// <summary>
    /// Бренд.
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// Название.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Цвет.
    /// </summary>
    public string? Color { get; set; }      
    
    /// <summary>
    /// Объем.
    /// </summary>
    public string? Volume { get; set; }      

    /// <summary>
    /// Рекомендуемая цена товара.
    /// </summary>
    public string? PriceRec { get; set; }

    /// <summary>
    /// Текущая цена товара.
    /// </summary>
    public double? PriceCur { get; set; }

    /// <summary>
    /// Ссылка на товар.
    /// </summary>
    public string? URL { get; set; }
}
