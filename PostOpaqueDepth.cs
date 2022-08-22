public class PostOpaqueDepth : MonoBehaviour // TypeDefIndex: 10689
{	// Fields
	public RenderTexture postOpaqueDepth; // 0x18
	private Camera camera; // 0x20
	private CommandBufferManager commandBufferManager; // 0x28
	private CommandBufferDesc commandBufferDesc; // 0x30
	private Material copyDepthMat; // 0x38
	public RenderTexture cameraDepth; // 0x40

	// Properties
	public RenderTexture PostOpaque { get; }
	public Material CopyDepthMat { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public RenderTexture get_PostOpaque() { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Material get_CopyDepthMat() { }

	// RVA: 0x99C120 Offset: 0x99A720 VA: 0x18099C120
	private void OnEnable() { }

	// RVA: 0x99BF70 Offset: 0x99A570 VA: 0x18099BF70
	private void OnDisable() { }

	// RVA: 0x99B8C0 Offset: 0x999EC0 VA: 0x18099B8C0
	private void CheckCommandBuffer() { }

	// RVA: 0x99BA40 Offset: 0x99A040 VA: 0x18099BA40
	private void CleanupCommandBuffer() { }

	// RVA: 0x99BB00 Offset: 0x99A100 VA: 0x18099BB00
	private void CreateMaterial() { }

	// RVA: 0x99BBA0 Offset: 0x99A1A0 VA: 0x18099BBA0
	private void DestroyMaterial() { }

	// RVA: 0x99BC50 Offset: 0x99A250 VA: 0x18099BC50
	private void DestroyRenderTextures() { }

	// RVA: 0x99B540 Offset: 0x999B40 VA: 0x18099B540
	private bool CheckBindRenderTextures() { }

	// RVA: 0x99BDA0 Offset: 0x99A3A0 VA: 0x18099BDA0
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x99C200 Offset: 0x99A800 VA: 0x18099C200
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

