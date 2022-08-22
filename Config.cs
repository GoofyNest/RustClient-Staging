public class Config : ScriptableObject // TypeDefIndex: 11538
{	// Fields
	public int geometryLayerID; // 0x18
	public string geometryTag; // 0x20
	public int geometryRenderQueue; // 0x28
	public bool forceSinglePass; // 0x2C
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[HighlightNullAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private Shader beamShader1Pass; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xBF1F0 Offset: 0xBE5F0 VA: 0x1800BF1F0
	[FormerlySerializedAsAttribute] // RVA: 0xBF1F0 Offset: 0xBE5F0 VA: 0x1800BF1F0
	[SerializeField] // RVA: 0xBF1F0 Offset: 0xBE5F0 VA: 0x1800BF1F0
	[HighlightNullAttribute] // RVA: 0xBF1F0 Offset: 0xBE5F0 VA: 0x1800BF1F0
	private Shader beamShader2Pass; // 0x38
	public int sharedMeshSides; // 0x40
	public int sharedMeshSegments; // 0x44
	[RangeAttribute] // RVA: 0xBF380 Offset: 0xBE780 VA: 0x1800BF380
	public float globalNoiseScale; // 0x48
	public Vector3 globalNoiseVelocity; // 0x4C
	[HighlightNullAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public TextAsset noise3DData; // 0x58
	public int noise3DSize; // 0x60
	[HighlightNullAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ParticleSystem dustParticlesPrefab; // 0x68
	private static Config m_Instance; // 0x0

	// Properties
	public Shader beamShader { get; }
	public Vector4 globalNoiseParam { get; }
	public static Config Instance { get; }

	// Methods

	// RVA: 0x111DC90 Offset: 0x111C290 VA: 0x18111DC90
	public Shader get_beamShader() { }

	// RVA: 0x111DCA0 Offset: 0x111C2A0 VA: 0x18111DCA0
	public Vector4 get_globalNoiseParam() { }

	// RVA: 0x111D860 Offset: 0x111BE60 VA: 0x18111D860
	public void Reset() { }

	// RVA: 0x111D690 Offset: 0x111BC90 VA: 0x18111D690
	public ParticleSystem NewVolumetricDustParticles() { }

	// RVA: 0x111DAD0 Offset: 0x111C0D0 VA: 0x18111DAD0
	public static Config get_Instance() { }

	// RVA: 0x111DA20 Offset: 0x111C020 VA: 0x18111DA20
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

