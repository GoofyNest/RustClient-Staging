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

	// RVA: 0x99B440 Offset: 0x999A40 VA: 0x18099B440
	public void set_Enabled(bool value) { }

	// RVA: 0x99B3A0 Offset: 0x9999A0 VA: 0x18099B3A0
	public static float get_LerpTime() { }

	// RVA: 0x999EA0 Offset: 0x9984A0 VA: 0x180999EA0
	private void OnEnable() { }

	// RVA: 0x999E20 Offset: 0x998420 VA: 0x180999E20
	private void OnDisable() { }

	// RVA: 0x999D80 Offset: 0x998380 VA: 0x180999D80
	public void Initialize(IPosLerpTarget target) { }

	// RVA: 0x99A5A0 Offset: 0x998BA0 VA: 0x18099A5A0
	public void Snapshot(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x99A4E0 Offset: 0x998AE0 VA: 0x18099A4E0
	public void Snapshot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x99A2F0 Offset: 0x9988F0 VA: 0x18099A2F0
	public void SnapTo(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x99A1C0 Offset: 0x9987C0 VA: 0x18099A1C0
	public void SnapTo(Vector3 position, Quaternion rotation) { }

	// RVA: 0x999F30 Offset: 0x998530 VA: 0x180999F30
	public void SnapToEnd() { }

	// RVA: 0x99B1D0 Offset: 0x9997D0 VA: 0x18099B1D0
	public void Wipe() { }

	// RVA: 0x99B040 Offset: 0x999640 VA: 0x18099B040
	public static void WipeAll() { }

	// RVA: 0x998F10 Offset: 0x997510 VA: 0x180998F10
	protected void DoCycle() { }

	// RVA: 0x99ADE0 Offset: 0x9993E0 VA: 0x18099ADE0
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x999800 Offset: 0x997E00 VA: 0x180999800
	public Quaternion GetEstimatedAngularVelocity() { }

	// RVA: 0x999AF0 Offset: 0x9980F0 VA: 0x180999AF0
	public Vector3 GetEstimatedVelocity() { }

	// RVA: 0x998E10 Offset: 0x997410 VA: 0x180998E10 Slot: 4
	public void Dispose() { }

	// RVA: 0x998CC0 Offset: 0x9972C0 VA: 0x180998CC0
	public static void Clear() { }

	// RVA: 0x998D30 Offset: 0x997330 VA: 0x180998D30
	public static void Cycle() { }

	// RVA: 0x99B310 Offset: 0x999910 VA: 0x18099B310
	public void .ctor() { }

	// RVA: 0x99B240 Offset: 0x999840 VA: 0x18099B240
	private static void .cctor() { }

}

