using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Text.Json;
using Pannella.Helpers;
using Pannella.Models;

namespace Pannella.Services;

[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
public static class ExtrasService
{
    static string BASE_URL = "https://www.github.com/{0}/{1}/extras.json";
    public static async Task<ExtraRepo[]> GetExtraRepos()
    {
        string json = await File.ReadAllTextAsync("extras.json");

        ExtraRepo[] repos = JsonSerializer.Deserialize<Repo[]>(json);

        return repos ?? Array.Empty<ExtraRepo>();
    }

    public static async Task<Extra[]> GetExtras()
    {
        ExtraRepo[] repos = await GetExtraRepos();

        foreach (ExtraRepo repo in repos) {
            string url = string.
            string json = HttpHelper.Instance.GetHTML(BLACKLIST);
        }

        foreach
    }
}
