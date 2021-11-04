using NodaTime;
using NodaTime.Extensions;

LocalDate releaseDateSpot = new LocalDate(2016, 6, 23);//robot spot
DateTimeZone zone = DateTimeZoneProviders.Tzdb["America/New_York"];
ZonedClock clock = SystemClock.Instance.InZone(zone);
LocalDate today = clock.GetCurrentDate();
Console.WriteLine($"Today's date: {today:yyyy-MM-dd}");
Period age = Period.Between(releaseDateSpot, today);
Console.WriteLine(
    $"Robot Spot is: {age.Years} years, {age.Months} months, {age.Days} days old.");
