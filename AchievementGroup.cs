public class AchievementGroup // TypeDefIndex: 10819
{	// Fields
	public Translate.Phrase groupTitle; // 0x10
	public static AchievementGroup[] All; // 0x0
	public AchievementGroup.AchievementItem[] Items; // 0x18

	// Properties
	public bool Unlocked { get; }

	// Methods

	// RVA: 0xA98EE0 Offset: 0xA974E0 VA: 0x180A98EE0
	public void .ctor(string token = "", string english = "") { }

	// RVA: 0xA98FB0 Offset: 0xA975B0 VA: 0x180A98FB0
	public bool get_Unlocked() { }

	// RVA: 0xA96D30 Offset: 0xA95330 VA: 0x180A96D30
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

	// RVA: 0xA99170 Offset: 0xA97770 VA: 0x180A99170
	public IAchievement get_Achievement() { }

	// RVA: 0xA990B0 Offset: 0xA976B0 VA: 0x180A990B0
	public void .ctor(string name, string phrase) { }

	// RVA: 0xA99260 Offset: 0xA97860 VA: 0x180A99260
	public bool get_Unlocked() { }

}

private sealed class AchievementGroup.<>c // TypeDefIndex: 10821
{	// Fields
	public static readonly AchievementGroup.<>c <>9; // 0x0
	public static Func<AchievementGroup.AchievementItem, bool> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xAAB9D0 Offset: 0xAA9FD0 VA: 0x180AAB9D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xAAB730 Offset: 0xAA9D30 VA: 0x180AAB730
	internal bool <get_Unlocked>b__6_0(AchievementGroup.AchievementItem x) { }

}

