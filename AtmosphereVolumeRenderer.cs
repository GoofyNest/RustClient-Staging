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

	// RVA: 0x8340E0 Offset: 0x8326E0 VA: 0x1808340E0
	private static bool get_isSupported() { }

	// RVA: 0x834040 Offset: 0x832640 VA: 0x180834040
	public Camera get_TargetCamera() { }

	// RVA: 0x832010 Offset: 0x830610 VA: 0x180832010
	public static void Clear() { }

	// RVA: 0x832A00 Offset: 0x831000 VA: 0x180832A00
	public static void Register(AtmosphereVolume volume) { }

	// RVA: 0x833C10 Offset: 0x832210 VA: 0x180833C10
	public static void Unregister(AtmosphereVolume volume) { }

	// RVA: 0x832980 Offset: 0x830F80 VA: 0x180832980
	private void OnEnable() { }

	// RVA: 0x8327E0 Offset: 0x830DE0 VA: 0x1808327E0
	private void OnDisable() { }

	// RVA: 0x833E60 Offset: 0x832460 VA: 0x180833E60
	private void Update() { }

	// RVA: 0x831BD0 Offset: 0x8301D0 VA: 0x180831BD0
	private void CheckCommandBuffer() { }

	// RVA: 0x831E20 Offset: 0x830420 VA: 0x180831E20
	private void CleanupCommandBuffer() { }

	// RVA: 0x831D50 Offset: 0x830350 VA: 0x180831D50
	private void CheckMaterials() { }

	// RVA: 0x831EE0 Offset: 0x8304E0 VA: 0x180831EE0
	private void CleanupMaterials() { }

	// RVA: 0x833D20 Offset: 0x832320 VA: 0x180833D20
	private void UpdateVolumeMesh() { }

	// RVA: 0x832440 Offset: 0x830A40 VA: 0x180832440
	public void FindAndSortVolumes(Camera camera) { }

	// RVA: 0x833CD0 Offset: 0x8322D0 VA: 0x180833CD0
	public void UpdateAtmosphere() { }

	// RVA: 0x832AC0 Offset: 0x8310C0 VA: 0x180832AC0
	private void SetFrustumGlobalShaderParams(CommandBuffer cb, Camera camera) { }

	// RVA: 0x8332B0 Offset: 0x8318B0 VA: 0x1808332B0
	private bool SetGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x831F90 Offset: 0x830590 VA: 0x180831F90
	private void ClearGlobalShaderParams(CommandBuffer cb) { }

	// RVA: 0x8320C0 Offset: 0x8306C0 VA: 0x1808320C0
	private void FillCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x833FA0 Offset: 0x8325A0 VA: 0x180833FA0
	public void .ctor() { }

	// RVA: 0x833F20 Offset: 0x832520 VA: 0x180833F20
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

	// RVA: 0x83CE30 Offset: 0x83B430 VA: 0x18083CE30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x83CE10 Offset: 0x83B410 VA: 0x18083CE10
	internal int <FindAndSortVolumes>b__28_0(AtmosphereVolumeRenderer.CurrentVolumeEntry x, AtmosphereVolumeRenderer.CurrentVolumeEntry y) { }

}

