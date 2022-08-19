public class HairSetCollection : ScriptableObject // TypeDefIndex: 10736
{	// Fields
	public HairSetCollection.HairSetEntry[] Head; // 0x18
	public HairSetCollection.HairSetEntry[] Eyebrow; // 0x20
	public HairSetCollection.HairSetEntry[] Facial; // 0x28
	public HairSetCollection.HairSetEntry[] Armpit; // 0x30
	public HairSetCollection.HairSetEntry[] Pubic; // 0x38

	// Methods

	// RVA: 0x734BB0 Offset: 0x7331B0 VA: 0x180734BB0
	public HairSetCollection.HairSetEntry[] GetListByType(HairType hairType) { }

	// RVA: 0x734B20 Offset: 0x733120 VA: 0x180734B20
	public int GetIndex(HairSetCollection.HairSetEntry[] list, float typeNum) { }

	// RVA: 0x734A60 Offset: 0x733060 VA: 0x180734A60
	public int GetIndex(HairType hairType, float typeNum) { }

	// RVA: 0x734BF0 Offset: 0x7331F0 VA: 0x180734BF0
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

