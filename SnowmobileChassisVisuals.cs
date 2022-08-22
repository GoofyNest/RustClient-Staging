public class SnowmobileChassisVisuals : VehicleChassisVisuals<Snowmobile>, IClientComponent // TypeDefIndex: 9758
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Animator animator; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SnowmobileAudio audioScript; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SnowmobileChassisVisuals.TreadRenderer[] treadRenderers; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float treadSpeedMultiplier; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool flipRightSkiExtension; // 0x4C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftSki; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftSkiPistonIn; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftSkiPistonOut; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightSki; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightSkiPistonIn; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightSkiPistonOut; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float skiVisualAdjust; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float treadVisualAdjust; // 0x84
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float skiVisualMaxExtension; // 0x88
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float treadVisualMaxExtension; // 0x8C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float wheelSizeVisualMultiplier; // 0x90
	private float treadExtension; // 0x94
	private float treadPrevExtension; // 0x98
	private Snowmobile snowmobile; // 0xA0
	private float treadRotation; // 0xA8
	private MaterialPropertyBlock mpb; // 0xB0
	private Vector4 savedST; // 0xB8
	private static int animTurn; // 0x0
	private static int animSpeedometer; // 0x4
	private static int animTachometer; // 0x8
	private static int animFuel; // 0xC
	private static int animTreadWheels; // 0x10
	private int animNeedleShakeIndex; // 0xC8
	private int animEngineOnIndex; // 0xCC
	private float steerPercent; // 0xD0

	// Methods

	// RVA: 0x5B25C0 Offset: 0x5B0BC0 VA: 0x1805B25C0 Slot: 4
	public override void Init(Snowmobile owner, VehicleChassisVisuals.ClientWheelData<Snowmobile>[] clientWheelData) { }

	// RVA: 0x5B34A0 Offset: 0x5B1AA0 VA: 0x1805B34A0 Slot: 5
	protected override void PreWheelUpdateTick() { }

	// RVA: 0x5B2710 Offset: 0x5B0D10 VA: 0x1805B2710 Slot: 7
	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	// RVA: 0x5B3600 Offset: 0x5B1C00 VA: 0x1805B3600 Slot: 8
	protected override void StopAll() { }

	// RVA: 0x5B3790 Offset: 0x5B1D90 VA: 0x1805B3790 Slot: 6
	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, bool isOn, float steer, float dt) { }

	// RVA: 0x5B34B0 Offset: 0x5B1AB0 VA: 0x1805B34B0
	private void SetSuspensionExtension(Transform visualWheel, Vector3 restingLocalPos, float extension, float prevExtension, float maxVisualExtension, float updateSpeed, float dt, bool reverse) { }

	// RVA: 0x5B2550 Offset: 0x5B0B50 VA: 0x1805B2550
	private void InitAnim() { }

	// RVA: 0x5B3E30 Offset: 0x5B2430 VA: 0x1805B3E30
	public void .ctor() { }

	// RVA: 0x5B3D70 Offset: 0x5B2370 VA: 0x1805B3D70
	private static void .cctor() { }

}

private class SnowmobileChassisVisuals.TreadRenderer // TypeDefIndex: 9759
{	// Fields
	public Renderer renderer; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

