using Newtonsoft.Json;

string json = @"[
    '31/01/2019 01:10'
]";

IList<DateTime> dateList = JsonConvert.DeserializeObject<IList<DateTime>>(json, new JsonSerializerSettings
{
    DateFormatString = "yyyy-MM-dd H:mm"
});

foreach (DateTime dateTime in dateList)
{
    Console.WriteLine(dateTime.ToLongDateString());
}

Console.ReadLine();
