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

	// RVA: 0x213790 Offset: 0x212B90 VA: 0x180213790
	public void Init(ref DirectionalLight light) { }

	// RVA: 0x213710 Offset: 0x212B10 VA: 0x180213710
	public void Init(ref PointLight light) { }

	// RVA: 0x2137A0 Offset: 0x212BA0 VA: 0x1802137A0
	public void Init(ref SpotLight light) { }

	// RVA: 0x213720 Offset: 0x212B20 VA: 0x180213720
	public void Init(ref RectangleLight light) { }

	// RVA: 0x2136A0 Offset: 0x212AA0 VA: 0x1802136A0
	public void Init(ref DiscLight light) { }

	// RVA: 0x213690 Offset: 0x212A90 VA: 0x180213690
	public void InitNoBake(int lightInstanceID) { }

}

