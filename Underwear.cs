public class Underwear : ScriptableObject // TypeDefIndex: 10774
{	// Fields
	public string shortname; // 0x18
	public Translate.Phrase displayName; // 0x20
	public Sprite icon; // 0x28
	public Sprite iconFemale; // 0x30
	public SkinReplacement[] replacementsMale; // 0x38
	public SkinReplacement[] replacementsFemale; // 0x40
	[TooltipAttribute] // RVA: 0x7B760 Offset: 0x7AB60 VA: 0x18007B760
	public SteamInventoryItem steamItem; // 0x48
	[TooltipAttribute] // RVA: 0x7B860 Offset: 0x7AC60 VA: 0x18007B860
	public SteamDLCItem steamDLC; // 0x50
	public bool adminOnly; // 0x58

	// Methods

	// RVA: 0xA07B30 Offset: 0xA06130 VA: 0x180A07B30
	public uint GetID() { }

	// RVA: 0xA07BB0 Offset: 0xA061B0 VA: 0x180A07BB0
	public bool HasMaleParts() { }

	// RVA: 0xA07B90 Offset: 0xA06190 VA: 0x180A07B90
	public bool HasFemaleParts() { }

	// RVA: 0xA07D20 Offset: 0xA06320 VA: 0x180A07D20
	public bool ValidForPlayer(BasePlayer player) { }

	// RVA: 0xA07BD0 Offset: 0xA061D0 VA: 0x180A07BD0
	public static bool IsFemale(BasePlayer player) { }

	// RVA: 0xA07ED0 Offset: 0xA064D0 VA: 0x180A07ED0
	public static bool Validate(Underwear underwear, BasePlayer player) { }

	// RVA: 0xA08210 Offset: 0xA06810 VA: 0x180A08210
	public void .ctor() { }

}

