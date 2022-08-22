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

	// RVA: 0x846E50 Offset: 0x845450 VA: 0x180846E50
	public static bool get_IsEmpty() { }

	// RVA: 0x845EA0 Offset: 0x8444A0 VA: 0x180845EA0
	public static void Clear() { }

	// RVA: 0x846080 Offset: 0x844680 VA: 0x180846080
	private static ListHashSet<DeferredDecal> GetList(DeferredDecal decal, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> dict, int pass) { }

	// RVA: 0x845AE0 Offset: 0x8440E0 VA: 0x180845AE0
	public static void AddDecal(DeferredDecal decal) { }

	// RVA: 0x846240 Offset: 0x844840 VA: 0x180846240
	public static void RemoveDecal(DeferredDecal decal) { }

	// RVA: 0x8461E0 Offset: 0x8447E0 VA: 0x1808461E0
	public static void RefreshDecal(DeferredDecal decal) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8464B0 Offset: 0x844AB0 VA: 0x1808464B0
	private static void .cctor() { }

}

