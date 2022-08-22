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

	// RVA: 0x833FD0 Offset: 0x8325D0 VA: 0x180833FD0
	private static bool get_isSupported() { }

	// RVA: 0x833F30 Offset: 0x832530 VA: 0x180833F30
	public Camera get_TargetCamera() { }

	// RVA: 0x831F00 Offset: 0x830500 VA: 0x180831F00
	public static void Clear() { }

	// RVA: 0x8328F0 Offset: 0x830EF0 VA: 0x1808328F0
	public static void Register(AtmosphereVolume volume) { }

	// RVA: 0x833B00 Offset: 0x832100 VA: 0x180833B00
	public static void Unregister(AtmosphereVolume volume) { }

	// RVA: 0x832870 Offset: 0x830E70 VA: 0x180832870
	private void OnEnable() { }

	// RVA: 0x8326D0 Offset: 0x830CD0 VA: 0x1808326D0
	private void OnDisable() { }

	// RVA: 0x833D50 Offset: 0x832350 VA: 0x180833D50
	private void Update() { }

	// RVA: 0x831AC0 Offset: 0x8300C0 VA: 0x180831AC0
	private void CheckCommandBuffer() { }

	// RVA: 0x831D10 Offset: 0x830310 VA: 0x180831D10
	private void CleanupCommandBuffer() { }

	// RVA: 0x831C40 Offset: 0x830240 VA: 0x180831C40
	private void CheckMaterials() { }

	// RVA: 0x831DD0 Offset: 0x8303D0 VA: 0x180831DD0
	private void CleanupMaterials() { }

	// RVA: 0x833C10 Offset: 0x832210 VA: 0x180833C10
	private void UpdateVolumeMesh() { }

	// RVA: 0x832330 Offset: 0x830930 VA: 0x180832330
	public void FindAndSortVolumes(Camera camera) { }

	// RVA: 0x833BC0 Offset: 0x8321C0 VA: 0x180833BC0
	public void UpdateAtmosphere() { }

	// RVA: 0x8329B0 Offset: 0x830FB0 VA: 0x1808329B0
	private void SetFrustumGlobalShaderParams(CommandBuffer cb, Camera camera) { }

	// RVA: 0x8331A0 Offset: 0x8317A0 VA: 0x1808331A0
	private bool SetGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x831E80 Offset: 0x830480 VA: 0x180831E80
	private void ClearGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x831FB0 Offset: 0x8305B0 VA: 0x180831FB0
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x833E90 Offset: 0x832490 VA: 0x180833E90
	public void .ctor() { }

	// RVA: 0x833E10 Offset: 0x832410 VA: 0x180833E10
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

	// RVA: 0x83CD20 Offset: 0x83B320 VA: 0x18083CD20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x83CD00 Offset: 0x83B300 VA: 0x18083CD00
	internal int <FindAndSortVolumes>b__28_0(AtmosphereVolumeRenderer.CurrentVolumeEntry x, AtmosphereVolumeRenderer.CurrentVolumeEntry y) { }

}

