public class Config : ScriptableObject // TypeDefIndex: 11538
{	// Fields
	public int geometryLayerID; // 0x18
	public string geometryTag; // 0x20
	public int geometryRenderQueue; // 0x28
	public bool forceSinglePass; // 0x2C
	[SerializeField] // RVA: 0x93470 Offset: 0x92870 VA: 0x180093470
	[HighlightNullAttribute] // RVA: 0x93470 Offset: 0x92870 VA: 0x180093470
	private Shader beamShader1Pass; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xBF150 Offset: 0xBE550 VA: 0x1800BF150
	[FormerlySerializedAsAttribute] // RVA: 0xBF150 Offset: 0xBE550 VA: 0x1800BF150
	[SerializeField] // RVA: 0xBF150 Offset: 0xBE550 VA: 0x1800BF150
	[HighlightNullAttribute] // RVA: 0xBF150 Offset: 0xBE550 VA: 0x1800BF150
	private Shader beamShader2Pass; // 0x38
	public int sharedMeshSides; // 0x40
	public int sharedMeshSegments; // 0x44
	[RangeAttribute] // RVA: 0xBF2E0 Offset: 0xBE6E0 VA: 0x1800BF2E0
	public float globalNoiseScale; // 0x48
	public Vector3 globalNoiseVelocity; // 0x4C
	[HighlightNullAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public TextAsset noise3DData; // 0x58
	public int noise3DSize; // 0x60
	[HighlightNullAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public ParticleSystem dustParticlesPrefab; // 0x68
	private static Config m_Instance; // 0x0

	// Properties
	public Shader beamShader { get; }
	public Vector4 globalNoiseParam { get; }
	public static Config Instance { get; }

	// Methods

	// RVA: 0x111D9D0 Offset: 0x111BFD0 VA: 0x18111D9D0
	public Shader get_beamShader() { }

	// RVA: 0x111D9E0 Offset: 0x111BFE0 VA: 0x18111D9E0
	public Vector4 get_globalNoiseParam() { }

	// RVA: 0x111D5A0 Offset: 0x111BBA0 VA: 0x18111D5A0
	public void Reset() { }

	// RVA: 0x111D3D0 Offset: 0x111B9D0 VA: 0x18111D3D0
	public ParticleSystem NewVolumetricDustParticles() { }

	// RVA: 0x111D810 Offset: 0x111BE10 VA: 0x18111D810
	public static Config get_Instance() { }

	// RVA: 0x111D760 Offset: 0x111BD60 VA: 0x18111D760
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}
