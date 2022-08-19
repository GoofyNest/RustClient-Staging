public class DeferredMeshDecalRenderer : MonoBehaviour // TypeDefIndex: 10670
{	// Fields
	private Camera targetCamera; // 0x18
	private const string commandBufferName = "DeferredMeshDecals";
	private CameraEvent commandBufferEvent; // 0x20
	private CommandBuffer commandBuffer; // 0x28
	private RenderTargetIdentifier[] targets; // 0x30
	private Material multiCopyMat; // 0x38
	private MaterialPropertyBlock block; // 0x40
	private static HashSet<DeferredMeshDecal> registered; // 0x0
	private static HashSet<DeferredMeshDecal> visible; // 0x8
	private static Dictionary<DeferredMeshDecal.InstanceData, SimpleList<Matrix4x4>> batches; // 0x10

	// Properties
	public Camera TargetCamera { get; }

	// Methods

	// RVA: 0x84B550 Offset: 0x849B50 VA: 0x18084B550
	public Camera get_TargetCamera() { }

	// RVA: 0x84AEF0 Offset: 0x8494F0 VA: 0x18084AEF0
	public static void Register(DeferredMeshDecal decal) { }

	// RVA: 0x84AF70 Offset: 0x849570 VA: 0x18084AF70
	public static void Unregister(DeferredMeshDecal decal) { }

	// RVA: 0x84AD30 Offset: 0x849330 VA: 0x18084AD30
	private void OnEnable() { }

	// RVA: 0x84ACA0 Offset: 0x8492A0 VA: 0x18084ACA0
	private void OnDisable() { }

	// RVA: 0x84A3F0 Offset: 0x8489F0 VA: 0x18084A3F0
	private void CreateCommandBuffer() { }

	// RVA: 0x84A230 Offset: 0x848830 VA: 0x18084A230
	private void CleanupCommandBuffer() { }

	// RVA: 0x84A4A0 Offset: 0x848AA0 VA: 0x18084A4A0
	private void CreateMaterials() { }

	// RVA: 0x84A340 Offset: 0x848940 VA: 0x18084A340
	private void CleanupMaterials() { }

	// RVA: 0x849FF0 Offset: 0x8485F0 VA: 0x180849FF0
	public static void BecameVisible(DeferredMeshDecal decal) { }

	// RVA: 0x849F70 Offset: 0x848570 VA: 0x180849F70
	public static void BecameInvisible(DeferredMeshDecal decal) { }

	// RVA: 0x84A070 Offset: 0x848670 VA: 0x18084A070
	private void CleanupBatches() { }

	// RVA: 0x84AFF0 Offset: 0x8495F0 VA: 0x18084AFF0
	private void UpdateBatches() { }

	// RVA: 0x84A540 Offset: 0x848B40 VA: 0x18084A540
	public void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x84AE60 Offset: 0x849460 VA: 0x18084AE60
	private void OnPreRender() { }

	// RVA: 0x84B4F0 Offset: 0x849AF0 VA: 0x18084B4F0
	public void .ctor() { }

	// RVA: 0x84B410 Offset: 0x849A10 VA: 0x18084B410
	private static void .cctor() { }

}

