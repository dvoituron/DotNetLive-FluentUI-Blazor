namespace DemoFluentUI.Services;

/// <summary>
/// Extension methods on <see cref="ExpenseService"/> used by the
/// <c>ExpenseTracker</c> page to feed the <c>FluentDataGrid</c>.
/// </summary>
public static class ExpenseServiceExtensions
{
    /// <summary>
    /// Exposes the service items as an <see cref="IQueryable{Expense}"/>
    /// so they can be consumed by the <c>Items</c> parameter of
    /// <c>FluentDataGrid</c> (which supports sorting/paging on IQueryable).
    /// </summary>
    public static IQueryable<Expense> AsQueryable(this ExpenseService service)
        => service.Items.AsQueryable();

    /// <summary>
    /// Applies a case-insensitive filter on the description / category fields.
    /// Returns the source unchanged when the search term is empty.
    /// </summary>
    public static IQueryable<Expense> Filter(this IQueryable<Expense> source, string? searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
        {
            return source;
        }

        var term = searchTerm.Trim();
        return source.Where(e =>
            e.Description.Contains(term, StringComparison.OrdinalIgnoreCase) ||
            e.Category.ToString().Contains(term, StringComparison.OrdinalIgnoreCase));
    }
}
