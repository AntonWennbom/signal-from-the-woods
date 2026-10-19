using System.Globalization;
using Microsoft.JSInterop;

namespace SignalFromTheWoods.Web.Infrastructure;

public class CultureService(IJSRuntime js)
{
    private const string StorageKey = "sftw.culture";

    public static readonly string[] Supported = ["sv", "en"];

    public async Task InitializeAsync()
    {
        var stored = await js.InvokeAsync<string?>("localStorage.getItem", StorageKey);
        var culture = Supported.Contains(stored) ? stored! : "sv";
        Apply(culture);
    }

    public async Task SetCultureAsync(string culture)
    {
        await js.InvokeVoidAsync("localStorage.setItem", StorageKey, culture);
    }

    public static string Current => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

    private static void Apply(string culture)
    {
        var info = new CultureInfo(culture);
        CultureInfo.DefaultThreadCurrentCulture = info;
        CultureInfo.DefaultThreadCurrentUICulture = info;
    }
}
