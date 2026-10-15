static string GetReadableTime(int seconds)
{
    if (seconds > 359999) return "NA";

    int hourInSecs = 3600;
    int hours = seconds / hourInSecs;
    int mins = seconds % hourInSecs / 60;
    int secs = seconds % 60;

    return $"{hours:D2}:{mins:D2}:{secs:D2}";
}



static string GetReadableTime2(int seconds)
{
    if (seconds > 359999) return "NA";

    TimeSpan t = TimeSpan.FromSeconds(seconds);
    return $"{(int)t.TotalHours:D2}:{t.Minutes:D2}:{t.Seconds:D2}";
}
Console.WriteLine(GetReadableTime2(86400));