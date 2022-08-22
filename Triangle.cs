public struct Triangle // TypeDefIndex: 6594
{	// Fields
	public Vector3 point0; // 0x0
	public Vector3 point1; // 0xC
	public Vector3 point2; // 0x18

	// Properties
	public Vector3 Normal { get; }
	public Vector3 Center { get; }

	// Methods

	// RVA: 0x22DEB0 Offset: 0x22D2B0 VA: 0x18022DEB0
	public void .ctor(Vector3 point0, Vector3 point1, Vector3 point2) { }

	// RVA: 0x22DE60 Offset: 0x22D260 VA: 0x18022DE60
	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22DC90 Offset: 0x22D090 VA: 0x18022DC90
	private bool LineTest(Vector3 a, Vector3 b, Ray ray, float radius, out RaycastHit hit, float maxDistance) { }

	// RVA: 0x22E030 Offset: 0x22D430 VA: 0x18022E030
	public Vector3 get_Normal() { }

	// RVA: 0x22DEF0 Offset: 0x22D2F0 VA: 0x18022DEF0
	public Vector3 get_Center() { }

	// RVA: 0x22DB60 Offset: 0x22CF60 VA: 0x18022DB60
	public Vector3 ClosestPoint(Vector3 pos) { }

	// RVA: 0x22DBA0 Offset: 0x22CFA0 VA: 0x18022DBA0
	public float Distance(Vector3 pos) { }

	// RVA: 0x22DD70 Offset: 0x22D170 VA: 0x18022DD70
	public float SqrDistance(Vector3 pos) { }

}

