
using System.ComponentModel;

public enum UserRoles
{
    Admin = 1,
    Coach = 2,
    User = 3
}

public enum Gender
{
    Male = 1,
    Female = 2
}

public enum LookingFor
{
    Male = 1,
    Female = 2
}

public enum Smoking
{
    Yes = 1,
    No = 2,
    Occasionally = 3
}

public enum Drinking
{
    Yes = 1,
    No = 2,
    Occasionally = 3
}

public enum Zodiac
{
    Aries = 1,
    Taurus = 2,
    Gemini = 3,
    Cancer = 4,
    Leo = 5,
    Virgo = 6,
    Libra = 7,
    Scorpio = 8,
    Sagittarius = 9,
    Capricorn = 10,
    Aquarius = 11,
    Pisces = 12
}

public enum Workout
{
    Yes = 1,
    No = 2,
    Occasionally = 3
}

public enum WantChildren
{
    Yes = 1,
    No = 2,
    Do_not_want = 3,
    Want = 4
}

public enum DurationType
{
    Days = 1,
    Months,
    Years
}

public enum FileType
{
    Text = 1,
    Image = 2,
    Doc = 3
}

public enum RequestStatus
{
    Requested = 1,
    Accepted,
    Rejected,
    Removed,
    Maybe
}

public enum HubCenter
{
    ChatRoom = 1,
    MysteryRoom,
    LiveStream
}

public enum FriendRequestStatus
{
    Requested = 1,
    Accepted,
    Rejected
}

public enum SchedulePeriod
{
    Daily = 1,
    Alternative = 2
}

public enum NotificationType
{
    Info = 1,
    Request
}

public enum CoachSessionRequestStatus
{
    Requested = 1,
    Accepted,
    Completed,
    Rejected,
    Deleted
}


public enum PlanType
{
    OneTime = 1,
    Recurring = 2
}

public enum DurationPeriod
{
    Day = 1,
    Week = 2,
    Month = 3,
    Year = 4
}

public enum IsTrial
{
    Yes = 1,
    No = 2
}

public enum MessageType
{
    Text = 1,
    Attachment,
    Donation
}
public enum FromModule
{
    Chat = 1,
    ChemistryRoom = 2,
    Coach = 3,
    CoachJoinedUser = 4,
    LiveSession = 5
}

public enum CardBrand
{
    [Description("visa")]
    visa,
    [Description("mastercard")]
    mastercard,
    [Description("amex")]
    amex
}

public enum DeviceType
{
    Browser = 1,
    Android,
    IOS
}