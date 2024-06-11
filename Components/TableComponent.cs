using Microsoft.AspNetCore.Mvc;

public class ListComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string jsonData)
    {
        var data = await Task.Run(() =>
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<SiteAlarm>>(jsonData);
        });
        return View(data);
    }
}

public class SiteAlarm
{
    public string? Site { get; set; } // Nullable string
    public string? TimeStamp { get; set; }
    public string? Message { get; set; }
    public bool? Ack { get; set; }
    public string? Note { get; set; }
}
