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

	// RVA: 0x84BBB0 Offset: 0x84A1B0 VA: 0x18084BBB0
	public Camera get_TargetCamera() { }

	// RVA: 0x84B550 Offset: 0x849B50 VA: 0x18084B550
	public static void Register(DeferredMeshDecal decal) { }

	// RVA: 0x84B5D0 Offset: 0x849BD0 VA: 0x18084B5D0
	public static void Unregister(DeferredMeshDecal decal) { }

	// RVA: 0x84B390 Offset: 0x849990 VA: 0x18084B390
	private void OnEnable() { }

	// RVA: 0x84B300 Offset: 0x849900 VA: 0x18084B300
	private void OnDisable() { }

	// RVA: 0x84AA50 Offset: 0x849050 VA: 0x18084AA50
	private void CreateCommandBuffer() { }

	// RVA: 0x84A890 Offset: 0x848E90 VA: 0x18084A890
	private void CleanupCommandBuffer() { }

	// RVA: 0x84AB00 Offset: 0x849100 VA: 0x18084AB00
	private void CreateMaterials() { }

	// RVA: 0x84A9A0 Offset: 0x848FA0 VA: 0x18084A9A0
	private void CleanupMaterials() { }

	// RVA: 0x84A650 Offset: 0x848C50 VA: 0x18084A650
	public static void BecameVisible(DeferredMeshDecal decal) { }

	// RVA: 0x84A5D0 Offset: 0x848BD0 VA: 0x18084A5D0
	public static void BecameInvisible(DeferredMeshDecal decal) { }

	// RVA: 0x84A6D0 Offset: 0x848CD0 VA: 0x18084A6D0
	private void CleanupBatches() { }

	// RVA: 0x84B650 Offset: 0x849C50 VA: 0x18084B650
	private void UpdateBatches() { }

	// RVA: 0x84ABA0 Offset: 0x8491A0 VA: 0x18084ABA0
	public void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x84B4C0 Offset: 0x849AC0 VA: 0x18084B4C0
	private void OnPreRender() { }

	// RVA: 0x84BB50 Offset: 0x84A150 VA: 0x18084BB50
	public void .ctor() { }

	// RVA: 0x84BA70 Offset: 0x84A070 VA: 0x18084BA70
	private static void .cctor() { }

}

