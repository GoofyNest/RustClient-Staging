public sealed class Terrain : Behaviour // TypeDefIndex: 4088
{
// Namespace: UnityEngine
[RequireComponent] // RVA: 0x73CB0 Offset: 0x730B0 VA: 0x180073CB0
[RequiredByNativeCodeAttribute] // RVA: 0x73CB0 Offset: 0x730B0 VA: 0x180073CB0
[NativeHeaderAttribute] // RVA: 0x73CB0 Offset: 0x730B0 VA: 0x180073CB0
public class Collider2D : Behaviour // TypeDefIndex: 4086

// Namespace: 
internal class <Module> // TypeDefIndex: 4087

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
[UsedByNativeCodeAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
[StaticAccessorAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
[NativeHeaderAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
[NativeHeaderAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
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
	[NativePropertyAttribute] // RVA: 0x7A5E0 Offset: 0x799E0 VA: 0x18007A5E0
	public static Terrain[] activeTerrains { get; }
	[ObsoleteAttribute] // RVA: 0x7A6C0 Offset: 0x79AC0 VA: 0x18007A6C0
	public bool castShadows { set; }
	[ObsoleteAttribute] // RVA: 0x7A860 Offset: 0x79C60 VA: 0x18007A860
	public Terrain.MaterialType materialType { set; }

	// Methods

	// RVA: 0x22C3060 Offset: 0x22C1660 VA: 0x1822C3060
	public TerrainData get_terrainData() { }

	// RVA: 0x22C3230 Offset: 0x22C1830 VA: 0x1822C3230
	public void set_heightmapPixelError(float value) { }

	// RVA: 0x22C30A0 Offset: 0x22C16A0 VA: 0x1822C30A0
	public void set_basemapDistance(float value) { }

	// RVA: 0x22C3310 Offset: 0x22C1910 VA: 0x1822C3310
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x22C3020 Offset: 0x22C1620 VA: 0x1822C3020
	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	// RVA: 0x22C32D0 Offset: 0x22C18D0 VA: 0x1822C32D0
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x22C2FE0 Offset: 0x22C15E0 VA: 0x1822C2FE0
	public Material get_materialTemplate() { }

	// RVA: 0x22C3280 Offset: 0x22C1880 VA: 0x1822C3280
	public void set_materialTemplate(Material value) { }

	// RVA: 0x22C2F20 Offset: 0x22C1520 VA: 0x1822C2F20
	public bool get_drawHeightmap() { }

	// RVA: 0x22C3140 Offset: 0x22C1740 VA: 0x1822C3140
	public void set_drawHeightmap(bool value) { }

	// RVA: 0x22C2EE0 Offset: 0x22C14E0 VA: 0x1822C2EE0
	public bool get_allowAutoConnect() { }

	// RVA: 0x22C2FA0 Offset: 0x22C15A0 VA: 0x1822C2FA0
	public int get_groupingID() { }

	// RVA: 0x22C3190 Offset: 0x22C1790 VA: 0x1822C3190
	public void set_drawInstanced(bool value) { }

	// RVA: 0x22C2F60 Offset: 0x22C1560 VA: 0x1822C2F60
	public bool get_drawTreesAndFoliage() { }

	// RVA: 0x22C31E0 Offset: 0x22C17E0 VA: 0x1822C31E0
	public void set_drawTreesAndFoliage(bool value) { }

	// RVA: 0x22C2DC0 Offset: 0x22C13C0 VA: 0x1822C2DC0
	public float SampleHeight(Vector3 worldPosition) { }

	// RVA: 0x22C2E10 Offset: 0x22C1410 VA: 0x1822C2E10
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x22C2D20 Offset: 0x22C1320 VA: 0x1822C2D20
	public Vector3 GetPosition() { }

	// RVA: 0x22C2C90 Offset: 0x22C1290 VA: 0x1822C2C90
	public void Flush() { }

	// RVA: 0x22C2E80 Offset: 0x22C1480 VA: 0x1822C2E80
	public static Terrain get_activeTerrain() { }

	// RVA: 0x22C2EB0 Offset: 0x22C14B0 VA: 0x1822C2EB0
	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22C2C50 Offset: 0x22C1250 VA: 0x1822C2C50
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	// RVA: 0x22C30F0 Offset: 0x22C16F0 VA: 0x1822C30F0
	public void set_castShadows(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void set_materialType(Terrain.MaterialType value) { }

	// RVA: 0x18F7990 Offset: 0x18F5F90 VA: 0x1818F7990
	public void .ctor() { }

	// RVA: 0x22C2D70 Offset: 0x22C1370 VA: 0x1822C2D70
	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	// RVA: 0x22C2CD0 Offset: 0x22C12D0 VA: 0x1822C2CD0
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
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float quality; // 0x2B112D4

	// Methods

	// RVA: 0x36BAF0 Offset: 0x36A0F0 VA: 0x18036BAF0
	public void .ctor() { }

	// RVA: 0x36BAB0 Offset: 0x36A0B0 VA: 0x18036BAB0
	private static void .cctor() { }

}

