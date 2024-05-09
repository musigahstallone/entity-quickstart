namespace entity_quickstart;

public class GetDataAPIUsingNewtonSoft
{
    // var url = "https://eastus2.azure.data.mongodb-api.com/app/data-loizr/endpoint/data/v1/action/find";
    // var apiKey = "Ql8uItzS8dEvIJNVNoF2RBTguim8LFk2AkQbMgA3fOkEXHsrfnAUHzJWbr1dZPxg";

    // var payload = new
    // {
    //     collection = "posts",
    //     database = "sample_training",
    //     dataSource = "Cluster0",
    //     limit = 0
    // };

    // var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(payload), System.Text.Encoding.UTF8, "application/json");
    // content.Headers.Add("apiKey", apiKey);

    //     using var client = new HttpClient();

    // var response = await client.PostAsync(url, content);

    //     if (response.IsSuccessStatusCode)
    //     {
    //         var result = await response.Content.ReadAsStringAsync();
    // Console.WriteLine("Find operation successful.");
    //         Console.WriteLine("Writing response to file...");

    //         // Parse JSON string to JObject
    //         var json = JObject.Parse(result);

    // // Convert JObject to indented JSON string
    // var formattedJson = json.ToString(Formatting.Indented);

    // // Define the path to save the JSON file
    // var filePath = "response.json";

    // // Write the formatted JSON response to a file
    // await File.WriteAllTextAsync(filePath, formattedJson);

    // Console.WriteLine($"Response saved to '{filePath}'.");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"Failed to perform find operation. Status code: {response.StatusCode}");
    //     }
    // }

}

