public class LocalPositionAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9199
{	// Fields
	public Vector3 centerPosition; // 0x18
	public bool worldSpace; // 0x24
	public float scaleX; // 0x28
	public float timeScaleX; // 0x2C
	public AnimationCurve movementX; // 0x30
	public float scaleY; // 0x38
	public float timeScaleY; // 0x3C
	public AnimationCurve movementY; // 0x40
	public float scaleZ; // 0x48
	public float timeScaleZ; // 0x4C
	public AnimationCurve movementZ; // 0x50
	private const float maxDistSq = 10000;

	// Methods

	// RVA: 0x4FE270 Offset: 0x4FC870 VA: 0x1804FE270
	protected void Update() { }

	// RVA: 0x4FE660 Offset: 0x4FCC60 VA: 0x1804FE660
	public void .ctor() { }

}

