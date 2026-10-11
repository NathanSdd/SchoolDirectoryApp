using System.Net.Http.Json;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services;

public class SchoolService
{
    private readonly HttpClient Http;

    public SchoolService(HttpClient http)
    {
        Http = http;
    }

    public async Task<List<School>> GetSchoolsAsync()
    {
        var schools = await Http.GetFromJsonAsync<List<School>>(
            "https://edutots.net/api/school");

        return schools ?? new List<School>();
    }
}
