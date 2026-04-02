Console.WriteLine("Reading the css file");
string css = File.ReadAllText("kappaduck.css");

using HttpClient client = new();

Console.WriteLine("Minimize the css file");

using FormUrlEncodedContent content = new([new KeyValuePair<string, string>("input", css)]);
using HttpResponseMessage response = await client.PostAsync("https://www.toptal.com/developers/cssminifier/api/raw", content);

if (!response.IsSuccessStatusCode)
{
    Console.Error.WriteLine("Failed to minize the css file");
    return 1;
}

Console.WriteLine("Writing the minimized css file");

string minifiedCss = await response.Content.ReadAsStringAsync();
File.WriteAllText("kappaduck.min.css", minifiedCss);

return 0;
