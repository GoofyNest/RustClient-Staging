public class AtmosphereVolumeRenderer : MonoBehaviour // TypeDefIndex: 10641
{	// Fields
	public FogMode Mode; // 0x18
	public bool DistanceFog; // 0x1C
	public bool HeightFog; // 0x1D
	public AtmosphereVolume Volume; // 0x20
	private Camera targetCamera; // 0x28
	private CommandBufferManager commandBufferManager; // 0x30
	private CommandBufferDesc commandBufferDesc; // 0x38
	private Material fogMaterial; // 0x40
	private Vector4[] matrixArray; // 0x48
	private static Mesh volumeMesh; // 0x0
	private static HashSet<AtmosphereVolume> registeredVolumes; // 0x8
	private List<AtmosphereVolumeRenderer.CurrentVolumeEntry> currentVolumes; // 0x50

	// Properties
	private static bool isSupported { get; }
	public Camera TargetCamera { get; }

	// Methods

	// RVA: 0x834630 Offset: 0x832C30 VA: 0x180834630
	private static bool get_isSupported() { }

	// RVA: 0x834590 Offset: 0x832B90 VA: 0x180834590
	public Camera get_TargetCamera() { }

	// RVA: 0x832560 Offset: 0x830B60 VA: 0x180832560
	public static void Clear() { }

	// RVA: 0x832F50 Offset: 0x831550 VA: 0x180832F50
	public static void Register(AtmosphereVolume volume) { }

	// RVA: 0x834160 Offset: 0x832760 VA: 0x180834160
	public static void Unregister(AtmosphereVolume volume) { }

	// RVA: 0x832ED0 Offset: 0x8314D0 VA: 0x180832ED0
	private void OnEnable() { }

	// RVA: 0x832D30 Offset: 0x831330 VA: 0x180832D30
	private void OnDisable() { }

	// RVA: 0x8343B0 Offset: 0x8329B0 VA: 0x1808343B0
	private void Update() { }

	// RVA: 0x832120 Offset: 0x830720 VA: 0x180832120
	private void CheckCommandBuffer() { }

	// RVA: 0x832370 Offset: 0x830970 VA: 0x180832370
	private void CleanupCommandBuffer() { }

	// RVA: 0x8322A0 Offset: 0x8308A0 VA: 0x1808322A0
	private void CheckMaterials() { }

	// RVA: 0x832430 Offset: 0x830A30 VA: 0x180832430
	private void CleanupMaterials() { }

	// RVA: 0x834270 Offset: 0x832870 VA: 0x180834270
	private void UpdateVolumeMesh() { }

	// RVA: 0x832990 Offset: 0x830F90 VA: 0x180832990
	public void FindAndSortVolumes(Camera camera) { }

	// RVA: 0x834220 Offset: 0x832820 VA: 0x180834220
	public void UpdateAtmosphere() { }

	// RVA: 0x833010 Offset: 0x831610 VA: 0x180833010
	private void SetFrustumGlobalShaderParams(CommandBuffer cb, Camera camera) { }

	// RVA: 0x833800 Offset: 0x831E00 VA: 0x180833800
	private bool SetGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x8324E0 Offset: 0x830AE0 VA: 0x1808324E0
	private void ClearGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x832610 Offset: 0x830C10 VA: 0x180832610
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x8344F0 Offset: 0x832AF0 VA: 0x1808344F0
	public void .ctor() { }

	// RVA: 0x834470 Offset: 0x832A70 VA: 0x180834470
	private static void .cctor() { }

}

private struct AtmosphereVolumeRenderer.CurrentVolumeEntry // TypeDefIndex: 10642
{	// Fields
	public AtmosphereVolume volume; // 0x0
	public float distanceSqr; // 0x8

	// Methods

	// RVA: 0xF90B0 Offset: 0xF84B0 VA: 0x1800F90B0
	public void .ctor(AtmosphereVolume volume, float distance) { }

}

private sealed class AtmosphereVolumeRenderer.<>c // TypeDefIndex: 10643
{	// Fields
	public static readonly AtmosphereVolumeRenderer.<>c <>9; // 0x0
	public static Comparison<AtmosphereVolumeRenderer.CurrentVolumeEntry> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x83D380 Offset: 0x83B980 VA: 0x18083D380
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x83D360 Offset: 0x83B960 VA: 0x18083D360
	internal int <FindAndSortVolumes>b__28_0(AtmosphereVolumeRenderer.CurrentVolumeEntry x, AtmosphereVolumeRenderer.CurrentVolumeEntry y) { }

}

