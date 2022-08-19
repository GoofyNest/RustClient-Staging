public struct Triangle // TypeDefIndex: 6594
{	// Fields
	public Vector3 point0; // 0x0
	public Vector3 point1; // 0xC
	public Vector3 point2; // 0x18

	// Properties
	public Vector3 Normal { get; }
	public Vector3 Center { get; }

	// Methods

	// RVA: 0x22DF30 Offset: 0x22D330 VA: 0x18022DF30
	public void .ctor(Vector3 point0, Vector3 point1, Vector3 point2) { }

	// RVA: 0x22DEE0 Offset: 0x22D2E0 VA: 0x18022DEE0
	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22DD10 Offset: 0x22D110 VA: 0x18022DD10
	private bool LineTest(Vector3 a, Vector3 b, Ray ray, float radius, out RaycastHit hit, float maxDistance) { }

	// RVA: 0x22E0B0 Offset: 0x22D4B0 VA: 0x18022E0B0
	public Vector3 get_Normal() { }

	// RVA: 0x22DF70 Offset: 0x22D370 VA: 0x18022DF70
	public Vector3 get_Center() { }

	// RVA: 0x22DBE0 Offset: 0x22CFE0 VA: 0x18022DBE0
	public Vector3 ClosestPoint(Vector3 pos) { }

	// RVA: 0x22DC20 Offset: 0x22D020 VA: 0x18022DC20
	public float Distance(Vector3 pos) { }

	// RVA: 0x22DDF0 Offset: 0x22D1F0 VA: 0x18022DDF0
	public float SqrDistance(Vector3 pos) { }

}

