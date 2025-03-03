namespace BlazorBuilds.Components.Common.Extensions;

public static class UtilityExtensions
{
    public static async Task WhenTrue(this bool boolValue, Func<Task> do_whenTrue)
    {
        if (boolValue) await do_whenTrue();
    }
    public static async ValueTask WhenTrue(this bool boolValue, Func<ValueTask> do_whenTrue)
    {
        if (boolValue) await do_whenTrue();
    }
}
