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

	// RVA: 0x99C010 Offset: 0x99A610 VA: 0x18099C010
	private void OnEnable() { }

	// RVA: 0x99BE60 Offset: 0x99A460 VA: 0x18099BE60
	private void OnDisable() { }

	// RVA: 0x99B7B0 Offset: 0x999DB0 VA: 0x18099B7B0
	private void CheckCommandBuffer() { }

	// RVA: 0x99B930 Offset: 0x999F30 VA: 0x18099B930
	private void CleanupCommandBuffer() { }

	// RVA: 0x99B9F0 Offset: 0x999FF0 VA: 0x18099B9F0
	private void CreateMaterial() { }

	// RVA: 0x99BA90 Offset: 0x99A090 VA: 0x18099BA90
	private void DestroyMaterial() { }

	// RVA: 0x99BB40 Offset: 0x99A140 VA: 0x18099BB40
	private void DestroyRenderTextures() { }

	// RVA: 0x99B430 Offset: 0x999A30 VA: 0x18099B430
	private bool CheckBindRenderTextures() { }

	// RVA: 0x99BC90 Offset: 0x99A290 VA: 0x18099BC90
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x99C0F0 Offset: 0x99A6F0 VA: 0x18099C0F0
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

