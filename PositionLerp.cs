public class PositionLerp : IDisposable // TypeDefIndex: 9222
{	// Fields
	private static ListHashSet<PositionLerp> InstanceList; // 0x0
	public static bool DebugLog; // 0x8
	public static bool DebugDraw; // 0x9
	public static int TimeOffsetInterval; // 0xC
	public static float TimeOffset; // 0x10
	public const int TimeOffsetIntervalMin = 4;
	public const int TimeOffsetIntervalMax = 64;
	private bool enabled; // 0x10
	private Action idleDisable; // 0x18
	private Interpolator<TransformSnapshot> interpolator; // 0x20
	private IPosLerpTarget target; // 0x28
	private static TransformSnapshot snapshotPrototype; // 0x14
	private float timeOffset0; // 0x30
	private float timeOffset1; // 0x34
	private float timeOffset2; // 0x38
	private float timeOffset3; // 0x3C
	private int timeOffsetCount; // 0x40
	private float lastClientTime; // 0x44
	private float lastServerTime; // 0x48
	private float extrapolatedTime; // 0x4C
	private float enabledTime; // 0x50

	// Properties
	public bool Enabled { get; set; }
	public static float LerpTime { get; }

	// Methods

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Enabled() { }

	// RVA: 0x99B330 Offset: 0x999930 VA: 0x18099B330
	public void set_Enabled(bool value) { }

	// RVA: 0x99B290 Offset: 0x999890 VA: 0x18099B290
	public static float get_LerpTime() { }

	// RVA: 0x999D90 Offset: 0x998390 VA: 0x180999D90
	private void OnEnable() { }

	// RVA: 0x999D10 Offset: 0x998310 VA: 0x180999D10
	private void OnDisable() { }

	// RVA: 0x999C70 Offset: 0x998270 VA: 0x180999C70
	public void Initialize(IPosLerpTarget target) { }

	// RVA: 0x99A490 Offset: 0x998A90 VA: 0x18099A490
	public void Snapshot(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x99A3D0 Offset: 0x9989D0 VA: 0x18099A3D0
	public void Snapshot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x99A1E0 Offset: 0x9987E0 VA: 0x18099A1E0
	public void SnapTo(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x99A0B0 Offset: 0x9986B0 VA: 0x18099A0B0
	public void SnapTo(Vector3 position, Quaternion rotation) { }

	// RVA: 0x999E20 Offset: 0x998420 VA: 0x180999E20
	public void SnapToEnd() { }

	// RVA: 0x99B0C0 Offset: 0x9996C0 VA: 0x18099B0C0
	public void Wipe() { }

	// RVA: 0x99AF30 Offset: 0x999530 VA: 0x18099AF30
	public static void WipeAll() { }

	// RVA: 0x998E00 Offset: 0x997400 VA: 0x180998E00
	protected void DoCycle() { }

	// RVA: 0x99ACD0 Offset: 0x9992D0 VA: 0x18099ACD0
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x9996F0 Offset: 0x997CF0 VA: 0x1809996F0
	public Quaternion GetEstimatedAngularVelocity() { }

	// RVA: 0x9999E0 Offset: 0x997FE0 VA: 0x1809999E0
	public Vector3 GetEstimatedVelocity() { }

	// RVA: 0x998D00 Offset: 0x997300 VA: 0x180998D00 Slot: 4
	public void Dispose() { }

	// RVA: 0x998BB0 Offset: 0x9971B0 VA: 0x180998BB0
	public static void Clear() { }

	// RVA: 0x998C20 Offset: 0x997220 VA: 0x180998C20
	public static void Cycle() { }

	// RVA: 0x99B200 Offset: 0x999800 VA: 0x18099B200
	public void .ctor() { }

	// RVA: 0x99B130 Offset: 0x999730 VA: 0x18099B130
	private static void .cctor() { }

}

