public class TerrainConfig : ScriptableObject // TypeDefIndex: 10310
{	// Fields
	public bool CastShadows; // 0x18
	public LayerMask GroundMask; // 0x1C
	public LayerMask WaterMask; // 0x20
	public PhysicMaterial GenericMaterial; // 0x28
	public Material Material; // 0x30
	public Material MarginMaterial; // 0x38
	public Texture[] AlbedoArrays; // 0x40
	public Texture[] NormalArrays; // 0x48
	public float HeightMapErrorMin; // 0x50
	public float HeightMapErrorMax; // 0x54
	public float BaseMapDistanceMin; // 0x58
	public float BaseMapDistanceMax; // 0x5C
	public float ShaderLodMin; // 0x60
	public float ShaderLodMax; // 0x64
	public TerrainConfig.SplatType[] Splats; // 0x68
	private string snowMatName; // 0x70
	private string grassMatName; // 0x78
	private string sandMatName; // 0x80
	private List<string> dirtMatNames; // 0x88
	private List<string> stoneyMatNames; // 0x90

	// Properties
	public Texture AlbedoArray { get; }
	public Texture NormalArray { get; }

	// Methods

	// RVA: 0x113FBA0 Offset: 0x113E1A0 VA: 0x18113FBA0
	public Texture get_AlbedoArray() { }

	// RVA: 0x113FC40 Offset: 0x113E240 VA: 0x18113FC40
	public Texture get_NormalArray() { }

	// RVA: 0x113F310 Offset: 0x113D910 VA: 0x18113F310
	public PhysicMaterial[] GetPhysicMaterials() { }

	// RVA: 0x113E8D0 Offset: 0x113CED0 VA: 0x18113E8D0
	public Color[] GetAridColors() { }

	// RVA: 0x113E9A0 Offset: 0x113CFA0 VA: 0x18113E9A0
	public void GetAridOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113F520 Offset: 0x113DB20 VA: 0x18113F520
	public Color[] GetTemperateColors() { }

	// RVA: 0x113F5F0 Offset: 0x113DBF0 VA: 0x18113F5F0
	public void GetTemperateOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113F7F0 Offset: 0x113DDF0 VA: 0x18113F7F0
	public Color[] GetTundraColors() { }

	// RVA: 0x113F8C0 Offset: 0x113DEC0 VA: 0x18113F8C0
	public void GetTundraOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113E600 Offset: 0x113CC00 VA: 0x18113E600
	public Color[] GetArcticColors() { }

	// RVA: 0x113E6D0 Offset: 0x113CCD0 VA: 0x18113E6D0
	public void GetArcticOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113F450 Offset: 0x113DA50 VA: 0x18113F450
	public float[] GetSplatTiling() { }

	// RVA: 0x113F0E0 Offset: 0x113D6E0 VA: 0x18113F0E0
	public float GetMaxSplatTiling() { }

	// RVA: 0x113F150 Offset: 0x113D750 VA: 0x18113F150
	public float GetMinSplatTiling() { }

	// RVA: 0x113F1C0 Offset: 0x113D7C0 VA: 0x18113F1C0
	public Vector3[] GetPackedUVMIX() { }

	// RVA: 0x113EBA0 Offset: 0x113D1A0 VA: 0x18113EBA0
	public TerrainConfig.GroundType GetCurrentGroundType(bool isGrounded, RaycastHit hit) { }

	// RVA: 0x113FAC0 Offset: 0x113E0C0 VA: 0x18113FAC0
	public void .ctor() { }

}

public class TerrainConfig.SplatOverlay // TypeDefIndex: 10311
{	// Fields
	public Color Color; // 0x10
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Smoothness; // 0x20
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float NormalIntensity; // 0x24
	[RangeAttribute] // RVA: 0xC6A60 Offset: 0xC5E60 VA: 0x1800C6A60
	public float BlendFactor; // 0x28
	[RangeAttribute] // RVA: 0xC6B20 Offset: 0xC5F20 VA: 0x1800C6B20
	public float BlendFalloff; // 0x2C

	// Methods

	// RVA: 0x1135910 Offset: 0x1133F10 VA: 0x181135910
	public void .ctor() { }

}

public class TerrainConfig.SplatType // TypeDefIndex: 10312
{	// Fields
	public string Name; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xC6B80 Offset: 0xC5F80 VA: 0x1800C6B80
	public Color AridColor; // 0x18
	public TerrainConfig.SplatOverlay AridOverlay; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xC6C40 Offset: 0xC6040 VA: 0x1800C6C40
	public Color TemperateColor; // 0x30
	public TerrainConfig.SplatOverlay TemperateOverlay; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xC6D80 Offset: 0xC6180 VA: 0x1800C6D80
	public Color TundraColor; // 0x48
	public TerrainConfig.SplatOverlay TundraOverlay; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xC6D80 Offset: 0xC6180 VA: 0x1800C6D80
	public Color ArcticColor; // 0x60
	public TerrainConfig.SplatOverlay ArcticOverlay; // 0x70
	public PhysicMaterial Material; // 0x78
	public float SplatTiling; // 0x80
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float UVMIXMult; // 0x84
	public float UVMIXStart; // 0x88
	public float UVMIXDist; // 0x8C

	// Methods

	// RVA: 0x1135980 Offset: 0x1133F80 VA: 0x181135980
	public void .ctor() { }

}

public enum TerrainConfig.GroundType // TypeDefIndex: 10313
{	// Fields
	public int value__; // 0x0
	public const TerrainConfig.GroundType None = 0;
	public const TerrainConfig.GroundType HardSurface = 1;
	public const TerrainConfig.GroundType Grass = 2;
	public const TerrainConfig.GroundType Sand = 3;
	public const TerrainConfig.GroundType Snow = 4;
	public const TerrainConfig.GroundType Dirt = 5;
	public const TerrainConfig.GroundType Gravel = 6;

}

