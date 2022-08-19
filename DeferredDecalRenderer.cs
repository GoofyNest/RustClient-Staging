public class DeferredDecalRenderer : BaseCommandBuffer // TypeDefIndex: 10650
{	// Fields
	private static ListDictionary<InstancingKey, InstancingBuffer>[] DiffuseBuffer; // 0x0
	private static ListDictionary<InstancingKey, InstancingBuffer>[] SpecularBuffer; // 0x8
	private static ListDictionary<InstancingKey, InstancingBuffer>[] NormalsBuffer; // 0x10
	private static ListDictionary<InstancingKey, InstancingBuffer>[] EmissionBuffer; // 0x18
	private static ListDictionary<InstancingKey, InstancingBuffer>[] CombinedBuffer; // 0x20
	private static MaterialPropertyBlock block; // 0x28

	// Methods

	// RVA: 0x844C90 Offset: 0x843290 VA: 0x180844C90
	private void RefreshCommandBuffer(Camera camera) { }

	// RVA: 0x8449D0 Offset: 0x842FD0 VA: 0x1808449D0
	private void Clear(ListDictionary<InstancingKey, InstancingBuffer> dict) { }

	// RVA: 0x8443C0 Offset: 0x8429C0 VA: 0x1808443C0
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> src, ListDictionary<InstancingKey, InstancingBuffer> dst, MaterialPropertyBlock block) { }

	// RVA: 0x8446B0 Offset: 0x842CB0 VA: 0x1808446B0
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListHashSet<DeferredDecal> src, InstancingBuffer dst, MaterialPropertyBlock block) { }

	// RVA: 0x844A70 Offset: 0x843070 VA: 0x180844A70
	private InstancingBuffer GetBuffer(ListDictionary<InstancingKey, InstancingBuffer> dict, InstancingKey key) { }

	// RVA: 0x844BA0 Offset: 0x8431A0 VA: 0x180844BA0
	protected void OnPreRender() { }

	// RVA: 0x8459C0 Offset: 0x843FC0 VA: 0x1808459C0
	public void .ctor() { }

	// RVA: 0x8453E0 Offset: 0x8439E0 VA: 0x1808453E0
	private static void .cctor() { }

}

