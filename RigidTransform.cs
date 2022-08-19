public struct RigidTransform // TypeDefIndex: 7113
{	// Fields
	public quaternion rot; // 0x0
	public float3 pos; // 0x10
	public static readonly RigidTransform identity; // 0x0

	// Methods

	// RVA: 0x22A560 Offset: 0x229960 VA: 0x18022A560
	public void .ctor(quaternion rotation, float3 translation) { }

	// RVA: 0x239900 Offset: 0x238D00 VA: 0x180239900
	public bool Equals(RigidTransform x) { }

	// RVA: 0x2399A0 Offset: 0x238DA0 VA: 0x1802399A0 Slot: 0
	public override bool Equals(object x) { }

	// RVA: 0x239AB0 Offset: 0x238EB0 VA: 0x180239AB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x239AE0 Offset: 0x238EE0 VA: 0x180239AE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x22ADC00 Offset: 0x22AC200 VA: 0x1822ADC00
	private static void .cctor() { }

}

