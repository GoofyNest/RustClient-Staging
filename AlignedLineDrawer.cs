public class AlignedLineDrawer : MonoBehaviour, IClientComponent // TypeDefIndex: 8875
{	// Fields
	public MeshFilter Filter; // 0x18
	public MeshRenderer Renderer; // 0x20
	public float LineWidth; // 0x28
	public float SurfaceOffset; // 0x2C
	public float SprayThickness; // 0x30
	public float uvTilingFactor; // 0x34
	public bool DrawEndCaps; // 0x38
	public bool DrawSideMesh; // 0x39
	public bool DrawBackMesh; // 0x3A
	public SprayCanSpray_Freehand Spray; // 0x40
	private static MaterialPropertyBlock propertyBlock; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Mesh <CreatedMesh>k__BackingField; // 0x48
	private bool isQueued; // 0x50
	private bool queuedFinal; // 0x51
	public static AlignedLineDrawer.LineDrawerQueue WorkQueue; // 0x8
	private Action meshUpdateCompleteAction; // 0x58

	// Properties
	public Mesh CreatedMesh { get; set; }
	private List<AlignedLineDrawer.LinePoint> Points { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	public Mesh get_CreatedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD7A0 Offset: 0x5DBDA0 VA: 0x1805DD7A0
	private void set_CreatedMesh(Mesh value) { }

	// RVA: 0xAA62C0 Offset: 0xAA48C0 VA: 0x180AA62C0
	private List<AlignedLineDrawer.LinePoint> get_Points() { }

	// RVA: 0xAA4AF0 Offset: 0xAA30F0 VA: 0x180AA4AF0
	public void QueueMeshUpdate(bool isFinal, Action onComplete) { }

	// RVA: 0xAA3810 Offset: 0xAA1E10 VA: 0x180AA3810
	public void ClearMesh() { }

	// RVA: 0xAA59C0 Offset: 0xAA3FC0 VA: 0x180AA59C0 Slot: 4
	public virtual void UpdateMesh(bool isFinal = False) { }

	// RVA: 0xAA44B0 Offset: 0xAA2AB0 VA: 0x180AA44B0
	private void MakeEndCap(AlignedLineDrawer.LinePoint startPoint, AlignedLineDrawer.LinePoint oppositePoint, List<Vector3> verts, List<int> tris, List<Vector2> uvs, Matrix4x4 localToWorld, int startTriangle, int endTriangle) { }

	// RVA: 0xAA3C40 Offset: 0xAA2240 VA: 0x180AA3C40
	private void ExtrudePoints(List<AlignedLineDrawer.LinePoint> points, List<Vector3> verts, List<int> tris, List<Vector2> uvs, float extrudeDistance) { }

	// RVA: 0xAA3780 Offset: 0xAA1D80 VA: 0x180AA3780 Slot: 5
	protected virtual void AssignMesh() { }

	// RVA: 0xAA4BA0 Offset: 0xAA31A0 VA: 0x180AA4BA0 Slot: 6
	public virtual void SetColour(Color c) { }

	// RVA: 0x87E300 Offset: 0x87C900 VA: 0x18087E300 Slot: 7
	public virtual void SetWidth(float width) { }

	// RVA: 0xAA4120 Offset: 0xAA2720 VA: 0x180AA4120
	public static int GetCompressedPathLength(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	// RVA: 0xAA38A0 Offset: 0xAA1EA0 VA: 0x180AA38A0
	public static void CompressPath(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	// RVA: 0xAA6290 Offset: 0xAA4890 VA: 0x180AA6290
	public void .ctor() { }

	// RVA: 0xAA6210 Offset: 0xAA4810 VA: 0x180AA6210
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAA4D10 Offset: 0xAA3310 VA: 0x180AA4D10
	private void <UpdateMesh>g__GenerateLineSegment|24_0(int startPoint, int endPoint, ref AlignedLineDrawer.<>c__DisplayClass24_0 ) { }

}

public struct AlignedLineDrawer.LinePoint // TypeDefIndex: 8876
{	// Fields
	public Vector3 LocalPosition; // 0x0
	public Vector3 WorldNormal; // 0xC

}

public class AlignedLineDrawer.LineDrawerQueue : ObjectWorkQueue<AlignedLineDrawer> // TypeDefIndex: 8877
{	// Methods

	// RVA: 0xAAB8B0 Offset: 0xAA9EB0 VA: 0x180AAB8B0 Slot: 6
	protected override void RunJob(AlignedLineDrawer entity) { }

	// RVA: 0xAAB900 Offset: 0xAA9F00 VA: 0x180AAB900 Slot: 5
	protected override bool ShouldAdd(AlignedLineDrawer entity) { }

	// RVA: 0xAAB990 Offset: 0xAA9F90 VA: 0x180AAB990
	public void .ctor() { }

}

private struct AlignedLineDrawer.<>c__DisplayClass24_0 // TypeDefIndex: 8878
{	// Fields
	public List<Vector3> verts; // 0x0
	public AlignedLineDrawer <>4__this; // 0x8
	public float distanceTravelled; // 0x10
	public Vector3 leftVertOffset; // 0x14
	public Vector3 rightVertOffset; // 0x20
	public List<Vector2> uvs; // 0x30
	public List<int> tris; // 0x38
	public bool isFinal; // 0x40

}

