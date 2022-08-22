public class HairSetCollection : ScriptableObject // TypeDefIndex: 10736
{	// Fields
	public HairSetCollection.HairSetEntry[] Head; // 0x18
	public HairSetCollection.HairSetEntry[] Eyebrow; // 0x20
	public HairSetCollection.HairSetEntry[] Facial; // 0x28
	public HairSetCollection.HairSetEntry[] Armpit; // 0x30
	public HairSetCollection.HairSetEntry[] Pubic; // 0x38

	// Methods

	// RVA: 0x734CC0 Offset: 0x7332C0 VA: 0x180734CC0
	public HairSetCollection.HairSetEntry[] GetListByType(HairType hairType) { }

	// RVA: 0x734C30 Offset: 0x733230 VA: 0x180734C30
	public int GetIndex(HairSetCollection.HairSetEntry[] list, float typeNum) { }

	// RVA: 0x734B70 Offset: 0x733170 VA: 0x180734B70
	public int GetIndex(HairType hairType, float typeNum) { }

	// RVA: 0x734D00 Offset: 0x733300 VA: 0x180734D00
	public HairSetCollection.HairSetEntry Get(HairType hairType, float typeNum) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public struct HairSetCollection.HairSetEntry // TypeDefIndex: 10737
{	// Fields
	public HairSet HairSet; // 0x0
	public GameObjectRef HairPrefab; // 0x8
	public HairDyeCollection HairDyeCollection; // 0x10

}

