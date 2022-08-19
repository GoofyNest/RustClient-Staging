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

	// RVA: 0x846D40 Offset: 0x845340 VA: 0x180846D40
	public static bool get_IsEmpty() { }

	// RVA: 0x845D90 Offset: 0x844390 VA: 0x180845D90
	public static void Clear() { }

	// RVA: 0x845F70 Offset: 0x844570 VA: 0x180845F70
	private static ListHashSet<DeferredDecal> GetList(DeferredDecal decal, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> dict, int pass) { }

	// RVA: 0x8459D0 Offset: 0x843FD0 VA: 0x1808459D0
	public static void AddDecal(DeferredDecal decal) { }

	// RVA: 0x846130 Offset: 0x844730 VA: 0x180846130
	public static void RemoveDecal(DeferredDecal decal) { }

	// RVA: 0x8460D0 Offset: 0x8446D0 VA: 0x1808460D0
	public static void RefreshDecal(DeferredDecal decal) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8463A0 Offset: 0x8449A0 VA: 0x1808463A0
	private static void .cctor() { }

}

