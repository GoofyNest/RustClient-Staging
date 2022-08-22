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

	// RVA: 0xA082E0 Offset: 0xA068E0 VA: 0x180A082E0
	public uint GetID() { }

	// RVA: 0xA08360 Offset: 0xA06960 VA: 0x180A08360
	public bool HasMaleParts() { }

	// RVA: 0xA08340 Offset: 0xA06940 VA: 0x180A08340
	public bool HasFemaleParts() { }

	// RVA: 0xA084D0 Offset: 0xA06AD0 VA: 0x180A084D0
	public bool ValidForPlayer(BasePlayer player) { }

	// RVA: 0xA08380 Offset: 0xA06980 VA: 0x180A08380
	public static bool IsFemale(BasePlayer player) { }

	// RVA: 0xA08680 Offset: 0xA06C80 VA: 0x180A08680
	public static bool Validate(Underwear underwear, BasePlayer player) { }

	// RVA: 0xA089C0 Offset: 0xA06FC0 VA: 0x180A089C0
	public void .ctor() { }

}

