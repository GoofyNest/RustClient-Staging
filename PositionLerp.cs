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

	// RVA: 0x99B930 Offset: 0x999F30 VA: 0x18099B930
	public void set_Enabled(bool value) { }

	// RVA: 0x99B890 Offset: 0x999E90 VA: 0x18099B890
	public static float get_LerpTime() { }

	// RVA: 0x99A390 Offset: 0x998990 VA: 0x18099A390
	private void OnEnable() { }

	// RVA: 0x99A310 Offset: 0x998910 VA: 0x18099A310
	private void OnDisable() { }

	// RVA: 0x99A270 Offset: 0x998870 VA: 0x18099A270
	public void Initialize(IPosLerpTarget target) { }

	// RVA: 0x99AA90 Offset: 0x999090 VA: 0x18099AA90
	public void Snapshot(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x99A9D0 Offset: 0x998FD0 VA: 0x18099A9D0
	public void Snapshot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x99A7E0 Offset: 0x998DE0 VA: 0x18099A7E0
	public void SnapTo(Vector3 position, Quaternion rotation, float serverTime) { }

	// RVA: 0x99A6B0 Offset: 0x998CB0 VA: 0x18099A6B0
	public void SnapTo(Vector3 position, Quaternion rotation) { }

	// RVA: 0x99A420 Offset: 0x998A20 VA: 0x18099A420
	public void SnapToEnd() { }

	// RVA: 0x99B6C0 Offset: 0x999CC0 VA: 0x18099B6C0
	public void Wipe() { }

	// RVA: 0x99B530 Offset: 0x999B30 VA: 0x18099B530
	public static void WipeAll() { }

	// RVA: 0x999400 Offset: 0x997A00 VA: 0x180999400
	protected void DoCycle() { }

	// RVA: 0x99B2D0 Offset: 0x9998D0 VA: 0x18099B2D0
	public void TransformEntries(Matrix4x4 matrix) { }

	// RVA: 0x999CF0 Offset: 0x9982F0 VA: 0x180999CF0
	public Quaternion GetEstimatedAngularVelocity() { }

	// RVA: 0x999FE0 Offset: 0x9985E0 VA: 0x180999FE0
	public Vector3 GetEstimatedVelocity() { }

	// RVA: 0x999300 Offset: 0x997900 VA: 0x180999300 Slot: 4
	public void Dispose() { }

	// RVA: 0x9991B0 Offset: 0x9977B0 VA: 0x1809991B0
	public static void Clear() { }

	// RVA: 0x999220 Offset: 0x997820 VA: 0x180999220
	public static void Cycle() { }

	// RVA: 0x99B800 Offset: 0x999E00 VA: 0x18099B800
	public void .ctor() { }

	// RVA: 0x99B730 Offset: 0x999D30 VA: 0x18099B730
	private static void .cctor() { }

}

