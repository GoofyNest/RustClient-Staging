public class HitchTrough : StorageContainer // TypeDefIndex: 8697
{	// Fields
	public HitchTrough.HitchSpot[] hitchSpots; // 0x3D0
	public float caloriesToDecaySeconds; // 0x3D8

	// Methods

	// RVA: 0x7419C0 Offset: 0x73FFC0 VA: 0x1807419C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x741A90 Offset: 0x740090 VA: 0x180741A90
	public void .ctor() { }

}

public class HitchTrough.HitchSpot // TypeDefIndex: 8698
{	// Fields
	public HitchTrough owner; // 0x10
	public Transform spot; // 0x18
	public EntityRef horse; // 0x20

	// Methods

	// RVA: 0x741910 Offset: 0x73FF10 VA: 0x180741910
	public RidableHorse GetHorse(bool isServer = True) { }

	// RVA: 0x7419A0 Offset: 0x73FFA0 VA: 0x1807419A0
	public bool IsOccupied(bool isServer = True) { }

	// RVA: 0x7419B0 Offset: 0x73FFB0 VA: 0x1807419B0
	public void SetOccupiedBy(RidableHorse newHorse) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

