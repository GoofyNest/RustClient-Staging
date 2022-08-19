public class AchievementGroup // TypeDefIndex: 10819
{	// Fields
	public Translate.Phrase groupTitle; // 0x10
	public static AchievementGroup[] All; // 0x0
	public AchievementGroup.AchievementItem[] Items; // 0x18

	// Properties
	public bool Unlocked { get; }

	// Methods

	// RVA: 0xA98C20 Offset: 0xA97220 VA: 0x180A98C20
	public void .ctor(string token = "", string english = "") { }

	// RVA: 0xA98CF0 Offset: 0xA972F0 VA: 0x180A98CF0
	public bool get_Unlocked() { }

	// RVA: 0xA96A70 Offset: 0xA95070 VA: 0x180A96A70
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

	// RVA: 0xA98EB0 Offset: 0xA974B0 VA: 0x180A98EB0
	public IAchievement get_Achievement() { }

	// RVA: 0xA98DF0 Offset: 0xA973F0 VA: 0x180A98DF0
	public void .ctor(string name, string phrase) { }

	// RVA: 0xA98FA0 Offset: 0xA975A0 VA: 0x180A98FA0
	public bool get_Unlocked() { }

}

private sealed class AchievementGroup.<>c // TypeDefIndex: 10821
{	// Fields
	public static readonly AchievementGroup.<>c <>9; // 0x0
	public static Func<AchievementGroup.AchievementItem, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xAAB710 Offset: 0xAA9D10 VA: 0x180AAB710
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xAAB470 Offset: 0xAA9A70 VA: 0x180AAB470
	internal bool <get_Unlocked>b__6_0(AchievementGroup.AchievementItem x) { }

}

