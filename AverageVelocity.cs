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

	// RVA: 0x7D02D0 Offset: 0x7CE8D0 VA: 0x1807D02D0
	public void Record(Vector3 newPos) { }

	// RVA: 0x7D0460 Offset: 0x7CEA60 VA: 0x1807D0460
	public float get_Speed() { }

	// RVA: 0x7D0440 Offset: 0x7CEA40 VA: 0x1807D0440
	public Vector3 get_Average() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

