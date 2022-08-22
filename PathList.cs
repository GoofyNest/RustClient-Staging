internal class PathList // TypeDefIndex: 2945
{	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1348BB0 Offset: 0x13471B0 VA: 0x181348BB0
	public void .ctor() { }

	// RVA: 0x1348C80 Offset: 0x1347280 VA: 0x181348C80
	public int get_Count() { }

	// RVA: 0x13488F0 Offset: 0x1346EF0 VA: 0x1813488F0
	public int GetCookiesCount() { }

	// RVA: 0x1348D10 Offset: 0x1347310 VA: 0x181348D10
	public ICollection get_Values() { }

	// RVA: 0x1348CB0 Offset: 0x13472B0 VA: 0x181348CB0
	public object get_Item(string s) { }

	// RVA: 0x1348D40 Offset: 0x1347340 VA: 0x181348D40
	public void set_Item(string s, object value) { }

	// RVA: 0xB9EEB0 Offset: 0xB9D4B0 VA: 0x180B9EEB0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1348CE0 Offset: 0x13472E0 VA: 0x181348CE0
	public object get_SyncRoot() { }

}

private class PathList.PathListComparer : IComparer // TypeDefIndex: 2946
{	// Fields
	internal static readonly PathList.PathListComparer StaticInstance; // 0x2B10330

	// Methods

	// RVA: 0x1348720 Offset: 0x1346D20 VA: 0x181348720 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1348890 Offset: 0x1346E90 VA: 0x181348890
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

	// RVA: 0x869CA0 Offset: 0x8682A0 VA: 0x180869CA0
	public void .ctor(string name, Vector3[] points) { }

	// RVA: 0x868580 Offset: 0x866B80 VA: 0x180868580
	private void SpawnObjectsNeighborAligned(ref uint seed, Prefab[] prefabs, List<Vector3> positions, SpawnFilter filter) { }

	// RVA: 0x867CF0 Offset: 0x8662F0 VA: 0x180867CF0
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x868380 Offset: 0x866980 VA: 0x180868380
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, List<Prefab> previousSpawns, out Prefab spawned, int pathLength, int index, SpawnFilter filter) { }

	// RVA: 0x865A50 Offset: 0x864050 VA: 0x180865A50
	private bool CheckObjects(Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x867E80 Offset: 0x866480 VA: 0x180867E80
	private void SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x865550 Offset: 0x863B50 VA: 0x180865550
	private bool CheckObjects(Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x8688D0 Offset: 0x866ED0 VA: 0x1808688D0
	public void SpawnSide(ref uint seed, PathList.SideObject obj) { }

	// RVA: 0x866DA0 Offset: 0x8653A0 VA: 0x180866DA0
	public void SpawnAlong(ref uint seed, PathList.PathObject obj) { }

	// RVA: 0x867560 Offset: 0x865B60 VA: 0x180867560
	public void SpawnBridge(ref uint seed, PathList.BridgeObject obj) { }

	// RVA: 0x8692B0 Offset: 0x8678B0 VA: 0x1808692B0
	public void SpawnStart(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x867AD0 Offset: 0x8660D0 VA: 0x180867AD0
	public void SpawnEnd(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x869720 Offset: 0x867D20 VA: 0x180869720
	public void TrimStart(PathList.BasicObject obj) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470
	public void TrimEnd(PathList.BasicObject obj) { }

	// RVA: 0x869940 Offset: 0x867F40 VA: 0x180869940
	public void TrimTopology(int topology) { }

	// RVA: 0x866D60 Offset: 0x865360 VA: 0x180866D60
	public void ResetTrims() { }

	// RVA: 0x8632D0 Offset: 0x8618D0 VA: 0x1808632D0
	public void AdjustTerrainHeight(float intensity = 1, float fade = 1) { }

	// RVA: 0x864070 Offset: 0x862670 VA: 0x180864070
	public void AdjustTerrainTexture() { }

	// RVA: 0x864AE0 Offset: 0x8630E0 VA: 0x180864AE0
	public void AdjustTerrainTopology() { }

	// RVA: 0x862AB0 Offset: 0x8610B0 VA: 0x180862AB0
	public void AdjustPlacementMap(float width) { }

	// RVA: 0x865B90 Offset: 0x864190 VA: 0x180865B90
	public List<PathList.MeshObject> CreateMesh(Mesh[] meshes, float normalSmoothing, bool snapToTerrain, bool snapStartToTerrain, bool snapEndToTerrain) { }

	// RVA: 0x869B40 Offset: 0x868140 VA: 0x180869B40
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

	// RVA: 0x8592F0 Offset: 0x8578F0 VA: 0x1808592F0
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

	// RVA: 0x875390 Offset: 0x873990 VA: 0x180875390
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

	// RVA: 0x869D30 Offset: 0x868330 VA: 0x180869D30
	public void .ctor() { }

}

public class PathList.BridgeObject // TypeDefIndex: 10299
{	// Fields
	public string Folder; // 0x10
	public float Distance; // 0x18

	// Methods

	// RVA: 0x859300 Offset: 0x857900 VA: 0x180859300
	public void .ctor() { }

}

public class PathList.MeshObject // TypeDefIndex: 10300
{	// Fields
	public Vector3 Position; // 0x10
	public Mesh[] Meshes; // 0x20

	// Methods

	// RVA: 0x859310 Offset: 0x857910 VA: 0x180859310
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

	// RVA: 0x875460 Offset: 0x873A60 VA: 0x180875460
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

	// RVA: 0x875880 Offset: 0x873E80 VA: 0x180875880
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

	// RVA: 0x875B00 Offset: 0x874100 VA: 0x180875B00
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

	// RVA: 0x875D80 Offset: 0x874380 VA: 0x180875D80
	internal void <AdjustPlacementMap>b__0(int x, int z) { }

}

