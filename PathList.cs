internal class PathList // TypeDefIndex: 2945
{	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1348E70 Offset: 0x1347470 VA: 0x181348E70
	public void .ctor() { }

	// RVA: 0x1348F40 Offset: 0x1347540 VA: 0x181348F40
	public int get_Count() { }

	// RVA: 0x1348BB0 Offset: 0x13471B0 VA: 0x181348BB0
	public int GetCookiesCount() { }

	// RVA: 0x1348FD0 Offset: 0x13475D0 VA: 0x181348FD0
	public ICollection get_Values() { }

	// RVA: 0x1348F70 Offset: 0x1347570 VA: 0x181348F70
	public object get_Item(string s) { }

	// RVA: 0x1349000 Offset: 0x1347600 VA: 0x181349000
	public void set_Item(string s, object value) { }

	// RVA: 0xB9F170 Offset: 0xB9D770 VA: 0x180B9F170
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1348FA0 Offset: 0x13475A0 VA: 0x181348FA0
	public object get_SyncRoot() { }

}

private class PathList.PathListComparer : IComparer // TypeDefIndex: 2946
{	// Fields
	internal static readonly PathList.PathListComparer StaticInstance; // 0x2B11370

	// Methods

	// RVA: 0x13489E0 Offset: 0x1346FE0 VA: 0x1813489E0 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1348B50 Offset: 0x1347150 VA: 0x181348B50
	private static void .cctor() { }

}

public class PathList // TypeDefIndex: 10292
{	// Fields
	private static Quaternion rot90; // 0x0
	private static Quaternion rot180; // 0x10
	private static Quaternion rot270; // 0x20
	public string Name; // 0x10
	public PathInterpolator Path; // 0x18
	public bool Spline; // 0x20
	public bool Start; // 0x21
	public bool End; // 0x22
	public float Width; // 0x24
	public float InnerPadding; // 0x28
	public float OuterPadding; // 0x2C
	public float InnerFade; // 0x30
	public float OuterFade; // 0x34
	public float RandomScale; // 0x38
	public float MeshOffset; // 0x3C
	public float TerrainOffset; // 0x40
	public int Topology; // 0x44
	public int Splat; // 0x48
	public int Hierarchy; // 0x4C
	public PathFinder.Node ProcgenStartNode; // 0x50
	public PathFinder.Node ProcgenEndNode; // 0x58
	public const float StepSize = 1;
	private static float[] placements; // 0x30

	// Methods

	// RVA: 0x869DB0 Offset: 0x8683B0 VA: 0x180869DB0
	public void .ctor(string name, Vector3[] points) { }

	// RVA: 0x868690 Offset: 0x866C90 VA: 0x180868690
	private void SpawnObjectsNeighborAligned(ref uint seed, Prefab[] prefabs, List<Vector3> positions, SpawnFilter filter) { }

	// RVA: 0x867E00 Offset: 0x866400 VA: 0x180867E00
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x868490 Offset: 0x866A90 VA: 0x180868490
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, List<Prefab> previousSpawns, out Prefab spawned, int pathLength, int index, SpawnFilter filter) { }

	// RVA: 0x865B60 Offset: 0x864160 VA: 0x180865B60
	private bool CheckObjects(Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x867F90 Offset: 0x866590 VA: 0x180867F90
	private void SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x865660 Offset: 0x863C60 VA: 0x180865660
	private bool CheckObjects(Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x8689E0 Offset: 0x866FE0 VA: 0x1808689E0
	public void SpawnSide(ref uint seed, PathList.SideObject obj) { }

	// RVA: 0x866EB0 Offset: 0x8654B0 VA: 0x180866EB0
	public void SpawnAlong(ref uint seed, PathList.PathObject obj) { }

	// RVA: 0x867670 Offset: 0x865C70 VA: 0x180867670
	public void SpawnBridge(ref uint seed, PathList.BridgeObject obj) { }

	// RVA: 0x8693C0 Offset: 0x8679C0 VA: 0x1808693C0
	public void SpawnStart(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x867BE0 Offset: 0x8661E0 VA: 0x180867BE0
	public void SpawnEnd(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x869830 Offset: 0x867E30 VA: 0x180869830
	public void TrimStart(PathList.BasicObject obj) { }

	// RVA: 0x869580 Offset: 0x867B80 VA: 0x180869580
	public void TrimEnd(PathList.BasicObject obj) { }

	// RVA: 0x869A50 Offset: 0x868050 VA: 0x180869A50
	public void TrimTopology(int topology) { }

	// RVA: 0x866E70 Offset: 0x865470 VA: 0x180866E70
	public void ResetTrims() { }

	// RVA: 0x8633E0 Offset: 0x8619E0 VA: 0x1808633E0
	public void AdjustTerrainHeight(float intensity = 1, float fade = 1) { }

	// RVA: 0x864180 Offset: 0x862780 VA: 0x180864180
	public void AdjustTerrainTexture() { }

	// RVA: 0x864BF0 Offset: 0x8631F0 VA: 0x180864BF0
	public void AdjustTerrainTopology() { }

	// RVA: 0x862BC0 Offset: 0x8611C0 VA: 0x180862BC0
	public void AdjustPlacementMap(float width) { }

	// RVA: 0x865CA0 Offset: 0x8642A0 VA: 0x180865CA0
	public List<PathList.MeshObject> CreateMesh(Mesh[] meshes, float normalSmoothing, bool snapToTerrain, bool snapStartToTerrain, bool snapEndToTerrain) { }

	// RVA: 0x869C50 Offset: 0x868250 VA: 0x180869C50
	private static void .cctor() { }

}

public enum PathList.Side // TypeDefIndex: 10293
{	// Fields
	public int value__; // 0x0
	public const PathList.Side Both = 0;
	public const PathList.Side Left = 1;
	public const PathList.Side Right = 2;
	public const PathList.Side Any = 3;

}

public enum PathList.Placement // TypeDefIndex: 10294
{	// Fields
	public int value__; // 0x0
	public const PathList.Placement Center = 0;
	public const PathList.Placement Side = 1;

}

public enum PathList.Alignment // TypeDefIndex: 10295
{	// Fields
	public int value__; // 0x0
	public const PathList.Alignment None = 0;
	public const PathList.Alignment Neighbor = 1;
	public const PathList.Alignment Forward = 2;
	public const PathList.Alignment Inward = 3;

}

public class PathList.BasicObject // TypeDefIndex: 10296
{	// Fields
	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Placement Placement; // 0x20
	public bool AlignToNormal; // 0x24
	public bool HeightToTerrain; // 0x25
	public float Offset; // 0x28

	// Methods

	// RVA: 0x859400 Offset: 0x857A00 VA: 0x180859400
	public void .ctor() { }

}

public class PathList.SideObject // TypeDefIndex: 10297
{	// Fields
	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Side Side; // 0x20
	public PathList.Alignment Alignment; // 0x24
	public float Density; // 0x28
	public float Distance; // 0x2C
	public float Offset; // 0x30

	// Methods

	// RVA: 0x8754A0 Offset: 0x873AA0 VA: 0x1808754A0
	public void .ctor() { }

}

public class PathList.PathObject // TypeDefIndex: 10298
{	// Fields
	public string Folder; // 0x10
	public SpawnFilter Filter; // 0x18
	public PathList.Alignment Alignment; // 0x20
	public float Density; // 0x24
	public float Distance; // 0x28
	public float Dithering; // 0x2C

	// Methods

	// RVA: 0x869E40 Offset: 0x868440 VA: 0x180869E40
	public void .ctor() { }

}

public class PathList.BridgeObject // TypeDefIndex: 10299
{	// Fields
	public string Folder; // 0x10
	public float Distance; // 0x18

	// Methods

	// RVA: 0x859410 Offset: 0x857A10 VA: 0x180859410
	public void .ctor() { }

}

public class PathList.MeshObject // TypeDefIndex: 10300
{	// Fields
	public Vector3 Position; // 0x10
	public Mesh[] Meshes; // 0x20

	// Methods

	// RVA: 0x859420 Offset: 0x857A20 VA: 0x180859420
	public void .ctor(Vector3 meshPivot, MeshData[] meshData) { }

}

private sealed class PathList.<>c__DisplayClass47_0 // TypeDefIndex: 10301
{	// Fields
	public TerrainHeightMap heightmap; // 0x10
	public Line prev_line; // 0x18
	public Line cur_line; // 0x30
	public float outerPadding; // 0x48
	public float outerFade; // 0x4C
	public float innerPadding; // 0x50
	public float innerFade; // 0x54
	public float offset01; // 0x58
	public float intensity; // 0x5C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass47_1 // TypeDefIndex: 10302
{	// Fields
	public float yn; // 0x10
	public Line next_line; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass47_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x875570 Offset: 0x873B70 VA: 0x180875570
	internal void <AdjustTerrainHeight>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass48_0 // TypeDefIndex: 10303
{	// Fields
	public TerrainSplatMap splatmap; // 0x10
	public float outerPadding; // 0x18
	public float innerPadding; // 0x1C
	public PathList <>4__this; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass48_1 // TypeDefIndex: 10304
{	// Fields
	public float yn; // 0x10
	public Ray ray; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass48_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x875990 Offset: 0x873F90 VA: 0x180875990
	internal void <AdjustTerrainTexture>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass49_0 // TypeDefIndex: 10305
{	// Fields
	public TerrainTopologyMap topomap; // 0x10
	public float outerPadding; // 0x18
	public float innerPadding; // 0x1C
	public PathList <>4__this; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass49_1 // TypeDefIndex: 10306
{	// Fields
	public float yn; // 0x10
	public Ray ray; // 0x14
	public float radius; // 0x2C
	public float opacity; // 0x30
	public PathList.<>c__DisplayClass49_0 CS$<>8__locals1; // 0x38

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x875C10 Offset: 0x874210 VA: 0x180875C10
	internal void <AdjustTerrainTopology>b__0(int x, int z) { }

}

private sealed class PathList.<>c__DisplayClass50_0 // TypeDefIndex: 10307
{	// Fields
	public TerrainPlacementMap placementmap; // 0x10
	public float radius; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class PathList.<>c__DisplayClass50_1 // TypeDefIndex: 10308
{	// Fields
	public float yn; // 0x10
	public Ray ray; // 0x14
	public PathList.<>c__DisplayClass50_0 CS$<>8__locals1; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x875E90 Offset: 0x874490 VA: 0x180875E90
	internal void <AdjustPlacementMap>b__0(int x, int z) { }

}

