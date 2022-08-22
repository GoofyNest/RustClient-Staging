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

	// RVA: 0x7D03E0 Offset: 0x7CE9E0 VA: 0x1807D03E0
	public void Record(Vector3 newPos) { }

	// RVA: 0x7D0570 Offset: 0x7CEB70 VA: 0x1807D0570
	public float get_Speed() { }

	// RVA: 0x7D0550 Offset: 0x7CEB50 VA: 0x1807D0550
	public Vector3 get_Average() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

