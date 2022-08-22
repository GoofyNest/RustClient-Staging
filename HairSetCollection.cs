public class HairSetCollection : ScriptableObject // TypeDefIndex: 10736
{	// Fields
	public HairSetCollection.HairSetEntry[] Head; // 0x18
	public HairSetCollection.HairSetEntry[] Eyebrow; // 0x20
	public HairSetCollection.HairSetEntry[] Facial; // 0x28
	public HairSetCollection.HairSetEntry[] Armpit; // 0x30
	public HairSetCollection.HairSetEntry[] Pubic; // 0x38

	// Methods

	// RVA: 0x734C10 Offset: 0x733210 VA: 0x180734C10
	public HairSetCollection.HairSetEntry[] GetListByType(HairType hairType) { }

	// RVA: 0x734B80 Offset: 0x733180 VA: 0x180734B80
	public int GetIndex(HairSetCollection.HairSetEntry[] list, float typeNum) { }

	// RVA: 0x734AC0 Offset: 0x7330C0 VA: 0x180734AC0
	public int GetIndex(HairType hairType, float typeNum) { }

	// RVA: 0x734C50 Offset: 0x733250 VA: 0x180734C50
	public HairSetCollection.HairSetEntry Get(HairType hairType, float typeNum) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public struct HairSetCollection.HairSetEntry // TypeDefIndex: 10737
{	// Fields
	public HairSet HairSet; // 0x0
	public GameObjectRef HairPrefab; // 0x8
	public HairDyeCollection HairDyeCollection; // 0x10

}

