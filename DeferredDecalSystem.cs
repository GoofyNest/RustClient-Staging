public class DeferredDecalSystem // TypeDefIndex: 10652
{	// Fields
	internal static bool IsDirty; // 0x0
	internal const int QueueSize = 2;
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] DiffuseDecals; // 0x8
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] SpecularDecals; // 0x10
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] NormalsDecals; // 0x18
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] EmissionDecals; // 0x20
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] CombinedDecals; // 0x28
	internal static int DiffusePass; // 0x30
	internal static int SpecularPass; // 0x34
	internal static int NormalsPass; // 0x38
	internal static int EmissionPass; // 0x3C
	internal static int CombinedPass; // 0x40
	internal static RenderTargetIdentifier[] DiffuseRenderTarget; // 0x48
	internal static RenderTargetIdentifier[] SpecularRenderTarget; // 0x50
	internal static RenderTargetIdentifier[] NormalsRenderTarget; // 0x58
	internal static RenderTargetIdentifier[] EmissionRenderTarget; // 0x60
	internal static RenderTargetIdentifier[] CombinedRenderTarget; // 0x68

	// Properties
	public static bool IsEmpty { get; }

	// Methods

	// RVA: 0x8473A0 Offset: 0x8459A0 VA: 0x1808473A0
	public static bool get_IsEmpty() { }

	// RVA: 0x8463F0 Offset: 0x8449F0 VA: 0x1808463F0
	public static void Clear() { }

	// RVA: 0x8465D0 Offset: 0x844BD0 VA: 0x1808465D0
	private static ListHashSet<DeferredDecal> GetList(DeferredDecal decal, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> dict, int pass) { }

	// RVA: 0x846030 Offset: 0x844630 VA: 0x180846030
	public static void AddDecal(DeferredDecal decal) { }

	// RVA: 0x846790 Offset: 0x844D90 VA: 0x180846790
	public static void RemoveDecal(DeferredDecal decal) { }

	// RVA: 0x846730 Offset: 0x844D30 VA: 0x180846730
	public static void RefreshDecal(DeferredDecal decal) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x846A00 Offset: 0x845000 VA: 0x180846A00
	private static void .cctor() { }

}

