public sealed class Terrain : Behaviour // TypeDefIndex: 4088
{
[RequireComponent] // RVA: 0x73D80 Offset: 0x73180 VA: 0x180073D80
[RequiredByNativeCodeAttribute] // RVA: 0x73D80 Offset: 0x73180 VA: 0x180073D80
[NativeHeaderAttribute] // RVA: 0x73D80 Offset: 0x73180 VA: 0x180073D80
public class Collider2D : Behaviour // TypeDefIndex: 4086

internal class <Module> // TypeDefIndex: 4087

[NativeHeaderAttribute] // RVA: 0x7A100 Offset: 0x79500 VA: 0x18007A100
[UsedByNativeCodeAttribute] // RVA: 0x7A100 Offset: 0x79500 VA: 0x18007A100
[StaticAccessorAttribute] // RVA: 0x7A100 Offset: 0x79500 VA: 0x18007A100
[NativeHeaderAttribute] // RVA: 0x7A100 Offset: 0x79500 VA: 0x18007A100
[NativeHeaderAttribute] // RVA: 0x7A100 Offset: 0x79500 VA: 0x18007A100
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
	[NativePropertyAttribute] // RVA: 0x7A7B0 Offset: 0x79BB0 VA: 0x18007A7B0
	public static Terrain[] activeTerrains { get; }
	[ObsoleteAttribute] // RVA: 0x7A810 Offset: 0x79C10 VA: 0x18007A810
	public bool castShadows { set; }
	[ObsoleteAttribute] // RVA: 0x7A980 Offset: 0x79D80 VA: 0x18007A980
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

	[UsedByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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

public class Terrain : ConsoleSystem // TypeDefIndex: 11971
{	[ClientVar] // RVA: 0x813F0 Offset: 0x807F0 VA: 0x1800813F0
	public static float quality; // 0x2B11960


	public void .ctor() { }

	private static void .cctor() { }

}

