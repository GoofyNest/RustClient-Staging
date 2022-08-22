public struct LightDataGI // TypeDefIndex: 3886
{	// Fields
	public int instanceID; // 0x0
	public LinearColor color; // 0x4
	public LinearColor indirectColor; // 0x14
	public Quaternion orientation; // 0x24
	public Vector3 position; // 0x34
	public float range; // 0x40
	public float coneAngle; // 0x44
	public float innerConeAngle; // 0x48
	public float shape0; // 0x4C
	public float shape1; // 0x50
	public LightType type; // 0x54
	public LightMode mode; // 0x55
	public byte shadow; // 0x56
	public FalloffType falloff; // 0x57

	// Methods

	// RVA: 0x212B40 Offset: 0x211F40 VA: 0x180212B40
	public void Init(ref DirectionalLight light) { }

	// RVA: 0x212AC0 Offset: 0x211EC0 VA: 0x180212AC0
	public void Init(ref PointLight light) { }

	// RVA: 0x212B50 Offset: 0x211F50 VA: 0x180212B50
	public void Init(ref SpotLight light) { }

	// RVA: 0x212AD0 Offset: 0x211ED0 VA: 0x180212AD0
	public void Init(ref RectangleLight light) { }

	// RVA: 0x212A50 Offset: 0x211E50 VA: 0x180212A50
	public void Init(ref DiscLight light) { }

	// RVA: 0x212A40 Offset: 0x211E40 VA: 0x180212A40
	public void InitNoBake(int lightInstanceID) { }

}

