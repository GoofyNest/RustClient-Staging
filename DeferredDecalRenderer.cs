public class DeferredDecalRenderer : BaseCommandBuffer // TypeDefIndex: 10650
{	// Fields
	private static ListDictionary<InstancingKey, InstancingBuffer>[] DiffuseBuffer; // 0x0
	private static ListDictionary<InstancingKey, InstancingBuffer>[] SpecularBuffer; // 0x8
	private static ListDictionary<InstancingKey, InstancingBuffer>[] NormalsBuffer; // 0x10
	private static ListDictionary<InstancingKey, InstancingBuffer>[] EmissionBuffer; // 0x18
	private static ListDictionary<InstancingKey, InstancingBuffer>[] CombinedBuffer; // 0x20
	private static MaterialPropertyBlock block; // 0x28

	// Methods

	// RVA: 0x8452F0 Offset: 0x8438F0 VA: 0x1808452F0
	private void RefreshCommandBuffer(Camera camera) { }

	// RVA: 0x845030 Offset: 0x843630 VA: 0x180845030
	private void Clear(ListDictionary<InstancingKey, InstancingBuffer> dict) { }

	// RVA: 0x844A20 Offset: 0x843020 VA: 0x180844A20
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> src, ListDictionary<InstancingKey, InstancingBuffer> dst, MaterialPropertyBlock block) { }

	// RVA: 0x844D10 Offset: 0x843310 VA: 0x180844D10
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListHashSet<DeferredDecal> src, InstancingBuffer dst, MaterialPropertyBlock block) { }

	// RVA: 0x8450D0 Offset: 0x8436D0 VA: 0x1808450D0
	private InstancingBuffer GetBuffer(ListDictionary<InstancingKey, InstancingBuffer> dict, InstancingKey key) { }

	// RVA: 0x845200 Offset: 0x843800 VA: 0x180845200
	protected void OnPreRender() { }

	// RVA: 0x846020 Offset: 0x844620 VA: 0x180846020
	public void .ctor() { }

	// RVA: 0x845A40 Offset: 0x844040 VA: 0x180845A40
	private static void .cctor() { }

}

