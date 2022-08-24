public class Underwear : ScriptableObject // TypeDefIndex: 10778
{	public string shortname; // 0x18
	public Translate.Phrase displayName; // 0x20
	public Sprite icon; // 0x28
	public Sprite iconFemale; // 0x30
	public SkinReplacement[] replacementsMale; // 0x38
	public SkinReplacement[] replacementsFemale; // 0x40
	[TooltipAttribute] // RVA: 0x7B970 Offset: 0x7AD70 VA: 0x18007B970
	public SteamInventoryItem steamItem; // 0x48
	[TooltipAttribute] // RVA: 0x7BB40 Offset: 0x7AF40 VA: 0x18007BB40
	public SteamDLCItem steamDLC; // 0x50
	public bool adminOnly; // 0x58


	public uint GetID() { }

	public bool HasMaleParts() { }

	public bool HasFemaleParts() { }

	public bool ValidForPlayer(BasePlayer player) { }

	public static bool IsFemale(BasePlayer player) { }

	public static bool Validate(Underwear underwear, BasePlayer player) { }

	public void .ctor() { }

}

