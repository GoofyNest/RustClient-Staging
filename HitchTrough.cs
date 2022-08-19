public class HitchTrough : StorageContainer // TypeDefIndex: 8697
{	// Fields
	public HitchTrough.HitchSpot[] hitchSpots; // 0x3D0
	public float caloriesToDecaySeconds; // 0x3D8

	// Methods

	// RVA: 0x741960 Offset: 0x73FF60 VA: 0x180741960 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x741A30 Offset: 0x740030 VA: 0x180741A30
	public void .ctor() { }

}

public class HitchTrough.HitchSpot // TypeDefIndex: 8698
{	// Fields
	public HitchTrough owner; // 0x10
	public Transform spot; // 0x18
	public EntityRef horse; // 0x20

	// Methods

	// RVA: 0x7418B0 Offset: 0x73FEB0 VA: 0x1807418B0
	public RidableHorse GetHorse(bool isServer = True) { }

	// RVA: 0x741940 Offset: 0x73FF40 VA: 0x180741940
	public bool IsOccupied(bool isServer = True) { }

	// RVA: 0x741950 Offset: 0x73FF50 VA: 0x180741950
	public void SetOccupiedBy(RidableHorse newHorse) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

