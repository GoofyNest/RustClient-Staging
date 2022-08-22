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

	// RVA: 0x22C3980 Offset: 0x22C1F80 VA: 0x1822C3980
	public TerrainData get_terrainData() { }

	// RVA: 0x22C3B50 Offset: 0x22C2150 VA: 0x1822C3B50
	public void set_heightmapPixelError(float value) { }

	// RVA: 0x22C39C0 Offset: 0x22C1FC0 VA: 0x1822C39C0
	public void set_basemapDistance(float value) { }

	// RVA: 0x22C3C30 Offset: 0x22C2230 VA: 0x1822C3C30
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x22C3940 Offset: 0x22C1F40 VA: 0x1822C3940
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	// RVA: 0x22C3BF0 Offset: 0x22C21F0 VA: 0x1822C3BF0
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x22C3900 Offset: 0x22C1F00 VA: 0x1822C3900
	public Material get_materialTemplate() { }

	// RVA: 0x22C3BA0 Offset: 0x22C21A0 VA: 0x1822C3BA0
	public void set_materialTemplate(Material value) { }

	// RVA: 0x22C3840 Offset: 0x22C1E40 VA: 0x1822C3840
	public bool get_drawHeightmap() { }

	// RVA: 0x22C3A60 Offset: 0x22C2060 VA: 0x1822C3A60
	public void set_drawHeightmap(bool value) { }

	// RVA: 0x22C3800 Offset: 0x22C1E00 VA: 0x1822C3800
	public bool get_allowAutoConnect() { }

	// RVA: 0x22C38C0 Offset: 0x22C1EC0 VA: 0x1822C38C0
	public int get_groupingID() { }

	// RVA: 0x22C3AB0 Offset: 0x22C20B0 VA: 0x1822C3AB0
	public void set_drawInstanced(bool value) { }

	// RVA: 0x22C3880 Offset: 0x22C1E80 VA: 0x1822C3880
	public bool get_drawTreesAndFoliage() { }

	// RVA: 0x22C3B00 Offset: 0x22C2100 VA: 0x1822C3B00
	public void set_drawTreesAndFoliage(bool value) { }

	// RVA: 0x22C36E0 Offset: 0x22C1CE0 VA: 0x1822C36E0
	public float SampleHeight(Vector3 worldPosition) { }

	// RVA: 0x22C3730 Offset: 0x22C1D30 VA: 0x1822C3730
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x22C3640 Offset: 0x22C1C40 VA: 0x1822C3640
	public Vector3 GetPosition() { }

	// RVA: 0x22C35B0 Offset: 0x22C1BB0 VA: 0x1822C35B0
	public void Flush() { }

	// RVA: 0x22C37A0 Offset: 0x22C1DA0 VA: 0x1822C37A0
	public static Terrain get_activeTerrain() { }

	// RVA: 0x22C37D0 Offset: 0x22C1DD0 VA: 0x1822C37D0
	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22C3570 Offset: 0x22C1B70 VA: 0x1822C3570
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	// RVA: 0x22C3A10 Offset: 0x22C2010 VA: 0x1822C3A10
	public void set_castShadows(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_materialType(Terrain.MaterialType value) { }

	// RVA: 0x18F7330 Offset: 0x18F5930 VA: 0x1818F7330
	public void .ctor() { }

	// RVA: 0x22C3690 Offset: 0x22C1C90 VA: 0x1822C3690
	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	// RVA: 0x22C35F0 Offset: 0x22C1BF0 VA: 0x1822C35F0
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
	public static float quality; // 0x1E5ED

	// Methods

	// RVA: 0x36BAF0 Offset: 0x36A0F0 VA: 0x18036BAF0
	public void .ctor() { }

	// RVA: 0x36BAB0 Offset: 0x36A0B0 VA: 0x18036BAB0
	private static void .cctor() { }

}

