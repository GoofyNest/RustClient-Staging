public sealed class Terrain : Behaviour // TypeDefIndex: 4088
{
// Namespace: UnityEngine
[RequireComponent] // RVA: 0x73D30 Offset: 0x73130 VA: 0x180073D30
[RequiredByNativeCodeAttribute] // RVA: 0x73D30 Offset: 0x73130 VA: 0x180073D30
[NativeHeaderAttribute] // RVA: 0x73D30 Offset: 0x73130 VA: 0x180073D30
public class Collider2D : Behaviour // TypeDefIndex: 4086

// Namespace: 
internal class <Module> // TypeDefIndex: 4087

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[UsedByNativeCodeAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[StaticAccessorAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[NativeHeaderAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[NativeHeaderAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
public sealed class Terrain : Behaviour // TypeDefIndex: 4088
	// Properties
	public TerrainData terrainData { get; }
	public float heightmapPixelError { set; }
	public float basemapDistance { set; }
	public ShadowCastingMode shadowCastingMode { set; }
	public ReflectionProbeUsage reflectionProbeUsage { get; set; }
	public Material materialTemplate { get; set; }
	public bool drawHeightmap { get; set; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	public bool drawInstanced { set; }
	public bool drawTreesAndFoliage { get; set; }
	public static Terrain activeTerrain { get; }
	[NativePropertyAttribute] // RVA: 0x7A6C0 Offset: 0x79AC0 VA: 0x18007A6C0
	public static Terrain[] activeTerrains { get; }
	[ObsoleteAttribute] // RVA: 0x7A760 Offset: 0x79B60 VA: 0x18007A760
	public bool castShadows { set; }
	[ObsoleteAttribute] // RVA: 0x7A920 Offset: 0x79D20 VA: 0x18007A920
	public Terrain.MaterialType materialType { set; }

	// Methods

	// RVA: 0x22C3160 Offset: 0x22C1760 VA: 0x1822C3160
	public TerrainData get_terrainData() { }

	// RVA: 0x22C3330 Offset: 0x22C1930 VA: 0x1822C3330
	public void set_heightmapPixelError(float value) { }

	// RVA: 0x22C31A0 Offset: 0x22C17A0 VA: 0x1822C31A0
	public void set_basemapDistance(float value) { }

	// RVA: 0x22C3410 Offset: 0x22C1A10 VA: 0x1822C3410
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x22C3120 Offset: 0x22C1720 VA: 0x1822C3120
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	// RVA: 0x22C33D0 Offset: 0x22C19D0 VA: 0x1822C33D0
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x22C30E0 Offset: 0x22C16E0 VA: 0x1822C30E0
	public Material get_materialTemplate() { }

	// RVA: 0x22C3380 Offset: 0x22C1980 VA: 0x1822C3380
	public void set_materialTemplate(Material value) { }

	// RVA: 0x22C3020 Offset: 0x22C1620 VA: 0x1822C3020
	public bool get_drawHeightmap() { }

	// RVA: 0x22C3240 Offset: 0x22C1840 VA: 0x1822C3240
	public void set_drawHeightmap(bool value) { }

	// RVA: 0x22C2FE0 Offset: 0x22C15E0 VA: 0x1822C2FE0
	public bool get_allowAutoConnect() { }

	// RVA: 0x22C30A0 Offset: 0x22C16A0 VA: 0x1822C30A0
	public int get_groupingID() { }

	// RVA: 0x22C3290 Offset: 0x22C1890 VA: 0x1822C3290
	public void set_drawInstanced(bool value) { }

	// RVA: 0x22C3060 Offset: 0x22C1660 VA: 0x1822C3060
	public bool get_drawTreesAndFoliage() { }

	// RVA: 0x22C32E0 Offset: 0x22C18E0 VA: 0x1822C32E0
	public void set_drawTreesAndFoliage(bool value) { }

	// RVA: 0x22C2EC0 Offset: 0x22C14C0 VA: 0x1822C2EC0
	public float SampleHeight(Vector3 worldPosition) { }

	// RVA: 0x22C2F10 Offset: 0x22C1510 VA: 0x1822C2F10
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x22C2E20 Offset: 0x22C1420 VA: 0x1822C2E20
	public Vector3 GetPosition() { }

	// RVA: 0x22C2D90 Offset: 0x22C1390 VA: 0x1822C2D90
	public void Flush() { }

	// RVA: 0x22C2F80 Offset: 0x22C1580 VA: 0x1822C2F80
	public static Terrain get_activeTerrain() { }

	// RVA: 0x22C2FB0 Offset: 0x22C15B0 VA: 0x1822C2FB0
	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22C2D50 Offset: 0x22C1350 VA: 0x1822C2D50
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	// RVA: 0x22C31F0 Offset: 0x22C17F0 VA: 0x1822C31F0
	public void set_castShadows(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_materialType(Terrain.MaterialType value) { }

	// RVA: 0x18F7C10 Offset: 0x18F6210 VA: 0x1818F7C10
	public void .ctor() { }

	// RVA: 0x22C2E70 Offset: 0x22C1470 VA: 0x1822C2E70
	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	// RVA: 0x22C2DD0 Offset: 0x22C13D0 VA: 0x1822C2DD0
	private void GetPosition_Injected(out Vector3 ret) { }

}

public enum Terrain.MaterialType // TypeDefIndex: 4089
{	// Fields
	public int value__; // 0x0
	public const Terrain.MaterialType BuiltInStandard = 0;
	public const Terrain.MaterialType BuiltInLegacyDiffuse = 1;
	public const Terrain.MaterialType BuiltInLegacySpecular = 2;
	public const Terrain.MaterialType Custom = 3;

}

public class Terrain : ConsoleSystem // TypeDefIndex: 11967
{	// Fields
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quality; // 0x2B11334

	// Methods

	// RVA: 0x36BAF0 Offset: 0x36A0F0 VA: 0x18036BAF0
	public void .ctor() { }

	// RVA: 0x36BAB0 Offset: 0x36A0B0 VA: 0x18036BAB0
	private static void .cctor() { }

}

