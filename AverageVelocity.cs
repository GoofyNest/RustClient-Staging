public class AverageVelocity // TypeDefIndex: 9117
{	// Fields
	private Vector3 pos; // 0x10
	private float time; // 0x1C
	private float lastEntry; // 0x20
	private float averageSpeed; // 0x24
	private Vector3 averageVelocity; // 0x28

	// Properties
	public float Speed { get; }
	public Vector3 Average { get; }

	// Methods

	// RVA: 0x79B670 Offset: 0x799C70 VA: 0x18079B670
	public void Record(Vector3 newPos) { }

	// RVA: 0x79B800 Offset: 0x799E00 VA: 0x18079B800
	public float get_Speed() { }

	// RVA: 0x79B7E0 Offset: 0x799DE0 VA: 0x18079B7E0
	public Vector3 get_Average() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

