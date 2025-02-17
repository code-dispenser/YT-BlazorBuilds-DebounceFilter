namespace BlazorBuilds.Components.Common.Models;

public record DebouncedTextResult(string TextValue, bool IsValid, string? ExceptionMessage = null);
