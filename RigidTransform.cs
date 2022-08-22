public struct RigidTransform // TypeDefIndex: 7113
{	// Fields
	public quaternion rot; // 0x0
	public float3 pos; // 0x10
	public static readonly RigidTransform identity; // 0x0

	// Methods

	// RVA: 0x22A4E0 Offset: 0x2298E0 VA: 0x18022A4E0
	public void .ctor(quaternion rotation, float3 translation) { }

	// RVA: 0x239880 Offset: 0x238C80 VA: 0x180239880
	public bool Equals(RigidTransform x) { }

	// RVA: 0x239920 Offset: 0x238D20 VA: 0x180239920 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x239A30 Offset: 0x238E30 VA: 0x180239A30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239A60 Offset: 0x238E60 VA: 0x180239A60 Slot: 3
	public override string ToString() { }

	// RVA: 0x22ADD00 Offset: 0x22AC300 VA: 0x1822ADD00
	private static void .cctor() { }

}

