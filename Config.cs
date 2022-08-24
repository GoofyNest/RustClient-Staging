public class Config : ScriptableObject // TypeDefIndex: 11542
{	public int geometryLayerID; // 0x18
	public string geometryTag; // 0x20
	public int geometryRenderQueue; // 0x28
	public bool forceSinglePass; // 0x2C
	[SerializeField] // RVA: 0x934E0 Offset: 0x928E0 VA: 0x1800934E0
	[HighlightNullAttribute] // RVA: 0x934E0 Offset: 0x928E0 VA: 0x1800934E0
	private Shader beamShader1Pass; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xBF040 Offset: 0xBE440 VA: 0x1800BF040
	[FormerlySerializedAsAttribute] // RVA: 0xBF040 Offset: 0xBE440 VA: 0x1800BF040
	[SerializeField] // RVA: 0xBF040 Offset: 0xBE440 VA: 0x1800BF040
	[HighlightNullAttribute] // RVA: 0xBF040 Offset: 0xBE440 VA: 0x1800BF040
	private Shader beamShader2Pass; // 0x38
	public int sharedMeshSides; // 0x40
	public int sharedMeshSegments; // 0x44
	[RangeAttribute] // RVA: 0xBF1A0 Offset: 0xBE5A0 VA: 0x1800BF1A0
	public float globalNoiseScale; // 0x48
	public Vector3 globalNoiseVelocity; // 0x4C
	[HighlightNullAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public TextAsset noise3DData; // 0x58
	public int noise3DSize; // 0x60
	[HighlightNullAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public ParticleSystem dustParticlesPrefab; // 0x68
	private static Config m_Instance; // 0x0

	public Shader beamShader { get; }
	public Vector4 globalNoiseParam { get; }
	public static Config Instance { get; }


	public Shader get_beamShader() { }

	public Vector4 get_globalNoiseParam() { }

	public void Reset() { }

	public ParticleSystem NewVolumetricDustParticles() { }

	public static Config get_Instance() { }

	public void .ctor() { }

	private static void .cctor() { }

}

