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

	// RVA: 0x113EE70 Offset: 0x113D470 VA: 0x18113EE70
	public Texture get_AlbedoArray() { }

	// RVA: 0x113EF10 Offset: 0x113D510 VA: 0x18113EF10
	public Texture get_NormalArray() { }

	// RVA: 0x113E5E0 Offset: 0x113CBE0 VA: 0x18113E5E0
	public PhysicMaterial[] GetPhysicMaterials() { }

	// RVA: 0x113DBA0 Offset: 0x113C1A0 VA: 0x18113DBA0
	public Color[] GetAridColors() { }

	// RVA: 0x113DC70 Offset: 0x113C270 VA: 0x18113DC70
	public void GetAridOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113E7F0 Offset: 0x113CDF0 VA: 0x18113E7F0
	public Color[] GetTemperateColors() { }

	// RVA: 0x113E8C0 Offset: 0x113CEC0 VA: 0x18113E8C0
	public void GetTemperateOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113EAC0 Offset: 0x113D0C0 VA: 0x18113EAC0
	public Color[] GetTundraColors() { }

	// RVA: 0x113EB90 Offset: 0x113D190 VA: 0x18113EB90
	public void GetTundraOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113D8D0 Offset: 0x113BED0 VA: 0x18113D8D0
	public Color[] GetArcticColors() { }

	// RVA: 0x113D9A0 Offset: 0x113BFA0 VA: 0x18113D9A0
	public void GetArcticOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x113E720 Offset: 0x113CD20 VA: 0x18113E720
	public float[] GetSplatTiling() { }

	// RVA: 0x113E3B0 Offset: 0x113C9B0 VA: 0x18113E3B0
	public float GetMaxSplatTiling() { }

	// RVA: 0x113E420 Offset: 0x113CA20 VA: 0x18113E420
	public float GetMinSplatTiling() { }

	// RVA: 0x113E490 Offset: 0x113CA90 VA: 0x18113E490
	public Vector3[] GetPackedUVMIX() { }

	// RVA: 0x113DE70 Offset: 0x113C470 VA: 0x18113DE70
	public TerrainConfig.GroundType GetCurrentGroundType(bool isGrounded, RaycastHit hit) { }

	// RVA: 0x113ED90 Offset: 0x113D390 VA: 0x18113ED90
	public void .ctor() { }

}

public class TerrainConfig.SplatOverlay // TypeDefIndex: 10311
{	// Fields
	public Color Color; // 0x10
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float Smoothness; // 0x20
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float NormalIntensity; // 0x24
	[RangeAttribute] // RVA: 0xC6750 Offset: 0xC5B50 VA: 0x1800C6750
	public float BlendFactor; // 0x28
	[RangeAttribute] // RVA: 0xC6A60 Offset: 0xC5E60 VA: 0x1800C6A60
	public float BlendFalloff; // 0x2C

	// Methods

	// RVA: 0x1134BE0 Offset: 0x11331E0 VA: 0x181134BE0
	public void .ctor() { }

}

public class TerrainConfig.SplatType // TypeDefIndex: 10312
{	// Fields
	public string Name; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xC6AB0 Offset: 0xC5EB0 VA: 0x1800C6AB0
	public Color AridColor; // 0x18
	public TerrainConfig.SplatOverlay AridOverlay; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xC6B70 Offset: 0xC5F70 VA: 0x1800C6B70
	public Color TemperateColor; // 0x30
	public TerrainConfig.SplatOverlay TemperateOverlay; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xC6CB0 Offset: 0xC60B0 VA: 0x1800C6CB0
	public Color TundraColor; // 0x48
	public TerrainConfig.SplatOverlay TundraOverlay; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xC6CB0 Offset: 0xC60B0 VA: 0x1800C6CB0
	public Color ArcticColor; // 0x60
	public TerrainConfig.SplatOverlay ArcticOverlay; // 0x70
	public PhysicMaterial Material; // 0x78
	public float SplatTiling; // 0x80
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float UVMIXMult; // 0x84
	public float UVMIXStart; // 0x88
	public float UVMIXDist; // 0x8C

	// Methods

	// RVA: 0x1134C50 Offset: 0x1133250 VA: 0x181134C50
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

