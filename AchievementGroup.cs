public class AchievementGroup // TypeDefIndex: 10819
{	// Fields
	public Translate.Phrase groupTitle; // 0x10
	public static AchievementGroup[] All; // 0x0
	public AchievementGroup.AchievementItem[] Items; // 0x18

	// Properties
	public bool Unlocked { get; }

	// Methods

	// RVA: 0xA993B0 Offset: 0xA979B0 VA: 0x180A993B0
	public void .ctor(string token = "", string english = "") { }

	// RVA: 0xA99480 Offset: 0xA97A80 VA: 0x180A99480
	public bool get_Unlocked() { }

	// RVA: 0xA97200 Offset: 0xA95800 VA: 0x180A97200
	private static void .cctor() { }

}

public class AchievementGroup.AchievementItem // TypeDefIndex: 10820
{	// Fields
	public string Name; // 0x10
	public Translate.Phrase Phrase; // 0x18

	// Properties
	public IAchievement Achievement { get; }
	public bool Unlocked { get; }

	// Methods

	// RVA: 0xA99640 Offset: 0xA97C40 VA: 0x180A99640
	public IAchievement get_Achievement() { }

	// RVA: 0xA99580 Offset: 0xA97B80 VA: 0x180A99580
	public void .ctor(string name, string phrase) { }

	// RVA: 0xA99730 Offset: 0xA97D30 VA: 0x180A99730
	public bool get_Unlocked() { }

}

private sealed class AchievementGroup.<>c // TypeDefIndex: 10821
{	// Fields
	public static readonly AchievementGroup.<>c <>9; // 0x0
	public static Func<AchievementGroup.AchievementItem, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xAABEA0 Offset: 0xAAA4A0 VA: 0x180AABEA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xAABC00 Offset: 0xAAA200 VA: 0x180AABC00
	internal bool <get_Unlocked>b__6_0(AchievementGroup.AchievementItem x) { }

}

