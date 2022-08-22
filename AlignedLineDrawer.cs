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
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	public Mesh get_CreatedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DD810 Offset: 0x5DBE10 VA: 0x1805DD810
	private void set_CreatedMesh(Mesh value) { }

	// RVA: 0xAA5DF0 Offset: 0xAA43F0 VA: 0x180AA5DF0
	private List<AlignedLineDrawer.LinePoint> get_Points() { }

	// RVA: 0xAA4620 Offset: 0xAA2C20 VA: 0x180AA4620
	public void QueueMeshUpdate(bool isFinal, Action onComplete) { }

	// RVA: 0xAA3340 Offset: 0xAA1940 VA: 0x180AA3340
	public void ClearMesh() { }

	// RVA: 0xAA54F0 Offset: 0xAA3AF0 VA: 0x180AA54F0 Slot: 4
	public virtual void UpdateMesh(bool isFinal = False) { }

	// RVA: 0xAA3FE0 Offset: 0xAA25E0 VA: 0x180AA3FE0
	private void MakeEndCap(AlignedLineDrawer.LinePoint startPoint, AlignedLineDrawer.LinePoint oppositePoint, List<Vector3> verts, List<int> tris, List<Vector2> uvs, Matrix4x4 localToWorld, int startTriangle, int endTriangle) { }

	// RVA: 0xAA3770 Offset: 0xAA1D70 VA: 0x180AA3770
	private void ExtrudePoints(List<AlignedLineDrawer.LinePoint> points, List<Vector3> verts, List<int> tris, List<Vector2> uvs, float extrudeDistance) { }

	// RVA: 0xAA32B0 Offset: 0xAA18B0 VA: 0x180AA32B0 Slot: 5
	protected virtual void AssignMesh() { }

	// RVA: 0xAA46D0 Offset: 0xAA2CD0 VA: 0x180AA46D0 Slot: 6
	public virtual void SetColour(Color c) { }

	// RVA: 0x862BA0 Offset: 0x8611A0 VA: 0x180862BA0 Slot: 7
	public virtual void SetWidth(float width) { }

	// RVA: 0xAA3C50 Offset: 0xAA2250 VA: 0x180AA3C50
	public static int GetCompressedPathLength(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	// RVA: 0xAA33D0 Offset: 0xAA19D0 VA: 0x180AA33D0
	public static void CompressPath(List<AlignedLineDrawer.LinePoint> toCompress, float tolerance) { }

	// RVA: 0xAA5DC0 Offset: 0xAA43C0 VA: 0x180AA5DC0
	public void .ctor() { }

	// RVA: 0xAA5D40 Offset: 0xAA4340 VA: 0x180AA5D40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAA4840 Offset: 0xAA2E40 VA: 0x180AA4840
	private void <UpdateMesh>g__GenerateLineSegment|24_0(int startPoint, int endPoint, ref AlignedLineDrawer.<>c__DisplayClass24_0 ) { }

}

public struct AlignedLineDrawer.LinePoint // TypeDefIndex: 8876
{	// Fields
	public Vector3 LocalPosition; // 0x0
	public Vector3 WorldNormal; // 0xC

}

public class AlignedLineDrawer.LineDrawerQueue : ObjectWorkQueue<AlignedLineDrawer> // TypeDefIndex: 8877
{	// Methods

	// RVA: 0xAAB3E0 Offset: 0xAA99E0 VA: 0x180AAB3E0 Slot: 6
	protected override void RunJob(AlignedLineDrawer entity) { }

	// RVA: 0xAAB430 Offset: 0xAA9A30 VA: 0x180AAB430 Slot: 5
	protected override bool ShouldAdd(AlignedLineDrawer entity) { }

	// RVA: 0xAAB4C0 Offset: 0xAA9AC0 VA: 0x180AAB4C0
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

