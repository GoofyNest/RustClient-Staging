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

	// RVA: 0x22C2EA0 Offset: 0x22C14A0 VA: 0x1822C2EA0
	public TerrainData get_terrainData() { }

	// RVA: 0x22C3070 Offset: 0x22C1670 VA: 0x1822C3070
	public void set_heightmapPixelError(float value) { }

	// RVA: 0x22C2EE0 Offset: 0x22C14E0 VA: 0x1822C2EE0
	public void set_basemapDistance(float value) { }

	// RVA: 0x22C3150 Offset: 0x22C1750 VA: 0x1822C3150
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x22C2E60 Offset: 0x22C1460 VA: 0x1822C2E60
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	// RVA: 0x22C3110 Offset: 0x22C1710 VA: 0x1822C3110
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x22C2E20 Offset: 0x22C1420 VA: 0x1822C2E20
	public Material get_materialTemplate() { }

	// RVA: 0x22C30C0 Offset: 0x22C16C0 VA: 0x1822C30C0
	public void set_materialTemplate(Material value) { }

	// RVA: 0x22C2D60 Offset: 0x22C1360 VA: 0x1822C2D60
	public bool get_drawHeightmap() { }

	// RVA: 0x22C2F80 Offset: 0x22C1580 VA: 0x1822C2F80
	public void set_drawHeightmap(bool value) { }

	// RVA: 0x22C2D20 Offset: 0x22C1320 VA: 0x1822C2D20
	public bool get_allowAutoConnect() { }

	// RVA: 0x22C2DE0 Offset: 0x22C13E0 VA: 0x1822C2DE0
	public int get_groupingID() { }

	// RVA: 0x22C2FD0 Offset: 0x22C15D0 VA: 0x1822C2FD0
	public void set_drawInstanced(bool value) { }

	// RVA: 0x22C2DA0 Offset: 0x22C13A0 VA: 0x1822C2DA0
	public bool get_drawTreesAndFoliage() { }

	// RVA: 0x22C3020 Offset: 0x22C1620 VA: 0x1822C3020
	public void set_drawTreesAndFoliage(bool value) { }

	// RVA: 0x22C2C00 Offset: 0x22C1200 VA: 0x1822C2C00
	public float SampleHeight(Vector3 worldPosition) { }

	// RVA: 0x22C2C50 Offset: 0x22C1250 VA: 0x1822C2C50
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x22C2B60 Offset: 0x22C1160 VA: 0x1822C2B60
	public Vector3 GetPosition() { }

	// RVA: 0x22C2AD0 Offset: 0x22C10D0 VA: 0x1822C2AD0
	public void Flush() { }

	// RVA: 0x22C2CC0 Offset: 0x22C12C0 VA: 0x1822C2CC0
	public static Terrain get_activeTerrain() { }

	// RVA: 0x22C2CF0 Offset: 0x22C12F0 VA: 0x1822C2CF0
	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22C2A90 Offset: 0x22C1090 VA: 0x1822C2A90
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	// RVA: 0x22C2F30 Offset: 0x22C1530 VA: 0x1822C2F30
	public void set_castShadows(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_materialType(Terrain.MaterialType value) { }

	// RVA: 0x18F7950 Offset: 0x18F5F50 VA: 0x1818F7950
	public void .ctor() { }

	// RVA: 0x22C2BB0 Offset: 0x22C11B0 VA: 0x1822C2BB0
	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	// RVA: 0x22C2B10 Offset: 0x22C1110 VA: 0x1822C2B10
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
	public static float quality; // 0x2B102F4

	// Methods

	// RVA: 0x36BAF0 Offset: 0x36A0F0 VA: 0x18036BAF0
	public void .ctor() { }

	// RVA: 0x36BAB0 Offset: 0x36A0B0 VA: 0x18036BAB0
	private static void .cctor() { }

}

