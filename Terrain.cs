public sealed class Terrain : Behaviour // TypeDefIndex: 4088
{
[RequireComponent] // RVA: 0x73D30 Offset: 0x73130 VA: 0x180073D30
[RequiredByNativeCodeAttribute] // RVA: 0x73D30 Offset: 0x73130 VA: 0x180073D30
[NativeHeaderAttribute] // RVA: 0x73D30 Offset: 0x73130 VA: 0x180073D30
public class Collider2D : Behaviour // TypeDefIndex: 4086

internal class <Module> // TypeDefIndex: 4087

[NativeHeaderAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[UsedByNativeCodeAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[StaticAccessorAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[NativeHeaderAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
[NativeHeaderAttribute] // RVA: 0x7A040 Offset: 0x79440 VA: 0x18007A040
public sealed class Terrain : Behaviour // TypeDefIndex: 4088
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


	public TerrainData get_terrainData() { }

	public void set_heightmapPixelError(float value) { }

	public void set_basemapDistance(float value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public ReflectionProbeUsage get_reflectionProbeUsage() { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	public Material get_materialTemplate() { }

	public void set_materialTemplate(Material value) { }

	public bool get_drawHeightmap() { }

	public void set_drawHeightmap(bool value) { }

	public bool get_allowAutoConnect() { }

	public int get_groupingID() { }

	public void set_drawInstanced(bool value) { }

	public bool get_drawTreesAndFoliage() { }

	public void set_drawTreesAndFoliage(bool value) { }

	public float SampleHeight(Vector3 worldPosition) { }

	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	public Vector3 GetPosition() { }

	public void Flush() { }

	public static Terrain get_activeTerrain() { }

	public static Terrain[] get_activeTerrains() { }

	[UsedByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static GameObject CreateTerrainGameObject(TerrainData assignTerrain) { }

	public void set_castShadows(bool value) { }

	public void set_materialType(Terrain.MaterialType value) { }

	public void .ctor() { }

	private float SampleHeight_Injected(ref Vector3 worldPosition) { }

	private void GetPosition_Injected(out Vector3 ret) { }

}

public enum Terrain.MaterialType // TypeDefIndex: 4089
{	public int value__; // 0x0
	public const Terrain.MaterialType BuiltInStandard = 0;
	public const Terrain.MaterialType BuiltInLegacyDiffuse = 1;
	public const Terrain.MaterialType BuiltInLegacySpecular = 2;
	public const Terrain.MaterialType Custom = 3;

}

public class Terrain : ConsoleSystem // TypeDefIndex: 11967
{	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float quality; // 0x1E5ED


	public void .ctor() { }

	private static void .cctor() { }

}

