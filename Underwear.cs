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

	// RVA: 0xA07DF0 Offset: 0xA063F0 VA: 0x180A07DF0
	public uint GetID() { }

	// RVA: 0xA07E70 Offset: 0xA06470 VA: 0x180A07E70
	public bool HasMaleParts() { }

	// RVA: 0xA07E50 Offset: 0xA06450 VA: 0x180A07E50
	public bool HasFemaleParts() { }

	// RVA: 0xA07FE0 Offset: 0xA065E0 VA: 0x180A07FE0
	public bool ValidForPlayer(BasePlayer player) { }

	// RVA: 0xA07E90 Offset: 0xA06490 VA: 0x180A07E90
	public static bool IsFemale(BasePlayer player) { }

	// RVA: 0xA08190 Offset: 0xA06790 VA: 0x180A08190
	public static bool Validate(Underwear underwear, BasePlayer player) { }

	// RVA: 0xA084D0 Offset: 0xA06AD0 VA: 0x180A084D0
	public void .ctor() { }

}

