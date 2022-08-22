public class DeferredDecalRenderer : BaseCommandBuffer // TypeDefIndex: 10650
{	// Fields
	private static ListDictionary<InstancingKey, InstancingBuffer>[] DiffuseBuffer; // 0x0
	private static ListDictionary<InstancingKey, InstancingBuffer>[] SpecularBuffer; // 0x8
	private static ListDictionary<InstancingKey, InstancingBuffer>[] NormalsBuffer; // 0x10
	private static ListDictionary<InstancingKey, InstancingBuffer>[] EmissionBuffer; // 0x18
	private static ListDictionary<InstancingKey, InstancingBuffer>[] CombinedBuffer; // 0x20
	private static MaterialPropertyBlock block; // 0x28

	// Methods

	// RVA: 0x844DA0 Offset: 0x8433A0 VA: 0x180844DA0
	private void RefreshCommandBuffer(Camera camera) { }

	// RVA: 0x844AE0 Offset: 0x8430E0 VA: 0x180844AE0
	private void Clear(ListDictionary<InstancingKey, InstancingBuffer> dict) { }

	// RVA: 0x8444D0 Offset: 0x842AD0 VA: 0x1808444D0
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> src, ListDictionary<InstancingKey, InstancingBuffer> dst, MaterialPropertyBlock block) { }

	// RVA: 0x8447C0 Offset: 0x842DC0 VA: 0x1808447C0
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListHashSet<DeferredDecal> src, InstancingBuffer dst, MaterialPropertyBlock block) { }

	// RVA: 0x844B80 Offset: 0x843180 VA: 0x180844B80
	private InstancingBuffer GetBuffer(ListDictionary<InstancingKey, InstancingBuffer> dict, InstancingKey key) { }

	// RVA: 0x844CB0 Offset: 0x8432B0 VA: 0x180844CB0
	protected void OnPreRender() { }

	// RVA: 0x845AD0 Offset: 0x8440D0 VA: 0x180845AD0
	public void .ctor() { }

	// RVA: 0x8454F0 Offset: 0x843AF0 VA: 0x1808454F0
	private static void .cctor() { }

}

