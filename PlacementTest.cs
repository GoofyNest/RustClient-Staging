public class PlacementTest : MonoBehaviour // TypeDefIndex: 8812
{	// Fields
	public MeshCollider myMeshCollider; // 0x18
	public Transform testTransform; // 0x20
	public Transform visualTest; // 0x28
	public float hemisphere; // 0x30
	public float clampTest; // 0x34
	public float testDist; // 0x38
	private float nextTest; // 0x3C

	// Methods

	// RVA: 0x91A1A0 Offset: 0x9187A0 VA: 0x18091A1A0
	public Vector3 RandomHemisphereDirection(Vector3 input, float degreesOffset) { }

	// RVA: 0x91A0B0 Offset: 0x9186B0 VA: 0x18091A0B0
	public Vector3 RandomCylinderPointAroundVector(Vector3 input, float distance, float minHeight = 0, float maxHeight = 0) { }

	// RVA: 0x919E10 Offset: 0x918410 VA: 0x180919E10
	public Vector3 ClampToHemisphere(Vector3 hemiInput, float degreesOffset, Vector3 inputVec) { }

	// RVA: 0x91A330 Offset: 0x918930 VA: 0x18091A330
	private void Update() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnDrawGizmos() { }

	// RVA: 0x91A810 Offset: 0x918E10 VA: 0x18091A810
	public void .ctor() { }

}

