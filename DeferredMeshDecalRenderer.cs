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

	// RVA: 0x84B660 Offset: 0x849C60 VA: 0x18084B660
	public Camera get_TargetCamera() { }

	// RVA: 0x84B000 Offset: 0x849600 VA: 0x18084B000
	public static void Register(DeferredMeshDecal decal) { }

	// RVA: 0x84B080 Offset: 0x849680 VA: 0x18084B080
	public static void Unregister(DeferredMeshDecal decal) { }

	// RVA: 0x84AE40 Offset: 0x849440 VA: 0x18084AE40
	private void OnEnable() { }

	// RVA: 0x84ADB0 Offset: 0x8493B0 VA: 0x18084ADB0
	private void OnDisable() { }

	// RVA: 0x84A500 Offset: 0x848B00 VA: 0x18084A500
	private void CreateCommandBuffer() { }

	// RVA: 0x84A340 Offset: 0x848940 VA: 0x18084A340
	private void CleanupCommandBuffer() { }

	// RVA: 0x84A5B0 Offset: 0x848BB0 VA: 0x18084A5B0
	private void CreateMaterials() { }

	// RVA: 0x84A450 Offset: 0x848A50 VA: 0x18084A450
	private void CleanupMaterials() { }

	// RVA: 0x84A100 Offset: 0x848700 VA: 0x18084A100
	public static void BecameVisible(DeferredMeshDecal decal) { }

	// RVA: 0x84A080 Offset: 0x848680 VA: 0x18084A080
	public static void BecameInvisible(DeferredMeshDecal decal) { }

	// RVA: 0x84A180 Offset: 0x848780 VA: 0x18084A180
	private void CleanupBatches() { }

	// RVA: 0x84B100 Offset: 0x849700 VA: 0x18084B100
	private void UpdateBatches() { }

	// RVA: 0x84A650 Offset: 0x848C50 VA: 0x18084A650
	public void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x84AF70 Offset: 0x849570 VA: 0x18084AF70
	private void OnPreRender() { }

	// RVA: 0x84B600 Offset: 0x849C00 VA: 0x18084B600
	public void .ctor() { }

	// RVA: 0x84B520 Offset: 0x849B20 VA: 0x18084B520
	private static void .cctor() { }

}

