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

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Material get_CopyDepthMat() { }

	// RVA: 0x99C610 Offset: 0x99AC10 VA: 0x18099C610
	private void OnEnable() { }

	// RVA: 0x99C460 Offset: 0x99AA60 VA: 0x18099C460
	private void OnDisable() { }

	// RVA: 0x99BDB0 Offset: 0x99A3B0 VA: 0x18099BDB0
	private void CheckCommandBuffer() { }

	// RVA: 0x99BF30 Offset: 0x99A530 VA: 0x18099BF30
	private void CleanupCommandBuffer() { }

	// RVA: 0x99BFF0 Offset: 0x99A5F0 VA: 0x18099BFF0
	private void CreateMaterial() { }

	// RVA: 0x99C090 Offset: 0x99A690 VA: 0x18099C090
	private void DestroyMaterial() { }

	// RVA: 0x99C140 Offset: 0x99A740 VA: 0x18099C140
	private void DestroyRenderTextures() { }

	// RVA: 0x99BA30 Offset: 0x99A030 VA: 0x18099BA30
	private bool CheckBindRenderTextures() { }

	// RVA: 0x99C290 Offset: 0x99A890 VA: 0x18099C290
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x99C6F0 Offset: 0x99ACF0 VA: 0x18099C6F0
	public void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

