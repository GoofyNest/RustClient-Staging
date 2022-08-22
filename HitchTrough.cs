public class HitchTrough : StorageContainer // TypeDefIndex: 8697
{	// Fields
	public HitchTrough.HitchSpot[] hitchSpots; // 0x3D0
	public float caloriesToDecaySeconds; // 0x3D8

	// Methods

	// RVA: 0x741A70 Offset: 0x740070 VA: 0x180741A70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x741B40 Offset: 0x740140 VA: 0x180741B40
	public void .ctor() { }

}

public class HitchTrough.HitchSpot // TypeDefIndex: 8698
{	// Fields
	public HitchTrough owner; // 0x10
	public Transform spot; // 0x18
	public EntityRef horse; // 0x20

	// Methods

	// RVA: 0x7419C0 Offset: 0x73FFC0 VA: 0x1807419C0
	public RidableHorse GetHorse(bool isServer = True) { }

	// RVA: 0x741A50 Offset: 0x740050 VA: 0x180741A50
	public bool IsOccupied(bool isServer = True) { }

	// RVA: 0x741A60 Offset: 0x740060 VA: 0x180741A60
	public void SetOccupiedBy(RidableHorse newHorse) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

