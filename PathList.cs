internal class PathList // TypeDefIndex: 2945
{	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1347F70 Offset: 0x1346570 VA: 0x181347F70
	public void .ctor() { }

	// RVA: 0x1348040 Offset: 0x1346640 VA: 0x181348040
	public int get_Count() { }

	// RVA: 0x1347CB0 Offset: 0x13462B0 VA: 0x181347CB0
	public int GetCookiesCount() { }

	// RVA: 0x13480D0 Offset: 0x13466D0 VA: 0x1813480D0
	public ICollection get_Values() { }

	// RVA: 0x1348070 Offset: 0x1346670 VA: 0x181348070
	public object get_Item(string s) { }

	// RVA: 0x1348100 Offset: 0x1346700 VA: 0x181348100
	public void set_Item(string s, object value) { }

	// RVA: 0xB9F640 Offset: 0xB9DC40 VA: 0x180B9F640
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13480A0 Offset: 0x13466A0 VA: 0x1813480A0
	public object get_SyncRoot() { }

}

private class PathList.PathListComparer : IComparer // TypeDefIndex: 2946
{	// Fields
	internal static readonly PathList.PathListComparer StaticInstance; // 0x1436D

	// Methods

	// RVA: 0x1347AE0 Offset: 0x13460E0 VA: 0x181347AE0 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1347C50 Offset: 0x1346250 VA: 0x181347C50
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

	// RVA: 0x885510 Offset: 0x883B10 VA: 0x180885510
	public void .ctor(string name, Vector3[] points) { }

	// RVA: 0x883DF0 Offset: 0x8823F0 VA: 0x180883DF0
	private void SpawnObjectsNeighborAligned(ref uint seed, Prefab[] prefabs, List<Vector3> positions, SpawnFilter filter) { }

	// RVA: 0x883560 Offset: 0x881B60 VA: 0x180883560
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x883BF0 Offset: 0x8821F0 VA: 0x180883BF0
	private bool SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 position, Quaternion rotation, List<Prefab> previousSpawns, out Prefab spawned, int pathLength, int index, SpawnFilter filter) { }

	// RVA: 0x8812C0 Offset: 0x87F8C0 VA: 0x1808812C0
	private bool CheckObjects(Prefab[] prefabs, Vector3 position, Quaternion rotation, SpawnFilter filter) { }

	// RVA: 0x8836F0 Offset: 0x881CF0 VA: 0x1808836F0
	private void SpawnObject(ref uint seed, Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x880DC0 Offset: 0x87F3C0 VA: 0x180880DC0
	private bool CheckObjects(Prefab[] prefabs, Vector3 pos, Vector3 dir, PathList.BasicObject obj) { }

	// RVA: 0x884140 Offset: 0x882740 VA: 0x180884140
	public void SpawnSide(ref uint seed, PathList.SideObject obj) { }

	// RVA: 0x882610 Offset: 0x880C10 VA: 0x180882610
	public void SpawnAlong(ref uint seed, PathList.PathObject obj) { }

	// RVA: 0x882DD0 Offset: 0x8813D0 VA: 0x180882DD0
	public void SpawnBridge(ref uint seed, PathList.BridgeObject obj) { }

	// RVA: 0x884B20 Offset: 0x883120 VA: 0x180884B20
	public void SpawnStart(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x883340 Offset: 0x881940 VA: 0x180883340
	public void SpawnEnd(ref uint seed, PathList.BasicObject obj) { }

	// RVA: 0x884F90 Offset: 0x883590 VA: 0x180884F90
	public void TrimStart(PathList.BasicObject obj) { }

	// RVA: 0x884CE0 Offset: 0x8832E0 VA: 0x180884CE0
	public void TrimEnd(PathList.BasicObject obj) { }

	// RVA: 0x8851B0 Offset: 0x8837B0 VA: 0x1808851B0
	public void TrimTopology(int topology) { }

	// RVA: 0x8825D0 Offset: 0x880BD0 VA: 0x1808825D0
	public void ResetTrims() { }

	// RVA: 0x87EB40 Offset: 0x87D140 VA: 0x18087EB40
	public void AdjustTerrainHeight(float intensity = 1, float fade = 1) { }

	// RVA: 0x87F8E0 Offset: 0x87DEE0 VA: 0x18087F8E0
	public void AdjustTerrainTexture() { }

	// RVA: 0x880350 Offset: 0x87E950 VA: 0x180880350
	public void AdjustTerrainTopology() { }

	// RVA: 0x87E320 Offset: 0x87C920 VA: 0x18087E320
	public void AdjustPlacementMap(float width) { }

	// RVA: 0x881400 Offset: 0x87FA00 VA: 0x180881400
	public List<PathList.MeshObject> CreateMesh(Mesh[] meshes, float normalSmoothing, bool snapToTerrain, bool snapStartToTerrain, bool snapEndToTerrain) { }

	// RVA: 0x8853B0 Offset: 0x8839B0 VA: 0x1808853B0
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

	// RVA: 0x874B60 Offset: 0x873160 VA: 0x180874B60
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

	// RVA: 0x890BC0 Offset: 0x88F1C0 VA: 0x180890BC0
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

	// RVA: 0x8855A0 Offset: 0x883BA0 VA: 0x1808855A0
	public void .ctor() { }

}

public class PathList.BridgeObject // TypeDefIndex: 10299
{	// Fields
	public string Folder; // 0x10
	public float Distance; // 0x18

	// Methods

	// RVA: 0x874B70 Offset: 0x873170 VA: 0x180874B70
	public void .ctor() { }

}

public class PathList.MeshObject // TypeDefIndex: 10300
{	// Fields
	public Vector3 Position; // 0x10
	public Mesh[] Meshes; // 0x20

	// Methods

	// RVA: 0x874B80 Offset: 0x873180 VA: 0x180874B80
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

	// RVA: 0x890C90 Offset: 0x88F290 VA: 0x180890C90
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

	// RVA: 0x8910B0 Offset: 0x88F6B0 VA: 0x1808910B0
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

	// RVA: 0x891330 Offset: 0x88F930 VA: 0x180891330
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

	// RVA: 0x8915B0 Offset: 0x88FBB0 VA: 0x1808915B0
	internal void <AdjustPlacementMap>b__0(int x, int z) { }

}

