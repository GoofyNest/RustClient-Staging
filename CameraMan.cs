public class CameraMan : SingletonComponent<CameraMan> // TypeDefIndex: 9140
{	// Fields
	public static string DefaultSaveName; // 0x0
	public const string SavePositionExtension = ".cam";
	public const string SavePositionDirectory = "camsaves";
	public bool OnlyControlWhenCursorHidden; // 0x18
	public bool NeedBothMouseButtonsToZoom; // 0x19
	public float LookSensitivity; // 0x1C
	public float MoveSpeed; // 0x20
	public static float GuideAspect; // 0x8
	public static float GuideRatio; // 0xC
	public Canvas canvas; // 0x28
	public Graphic[] guides; // 0x30
	private Color _guideColor; // 0x38
	private int _guide; // 0x48
	private bool startCulling; // 0x4C
	private static Dictionary<string, CameraMan.CameraState> stateDictionary; // 0x10
	private readonly ViewShake viewShake; // 0x50
	public BaseEntity TargetEntity; // 0x58
	private float targetDistance; // 0x60
	private float targetDistancePrev; // 0x64
	private Vector3 wishMove; // 0x68
	private Vector3 view; // 0x74
	private Vector3 viewPrev; // 0x80
	private Vector3 velocity; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Zoom>k__BackingField; // 0x98

	// Properties
	public Color GuideColor { get; set; }
	public int Guide { get; set; }
	private CameraMan.MovementType currentMovementType { get; }
	public float Zoom { get; set; }
	public float Fov { get; set; }
	public static bool Active { get; }

	// Methods

	// RVA: 0x6FC210 Offset: 0x6FA810 VA: 0x1806FC210
	public Color get_GuideColor() { }

	// RVA: 0x6FC490 Offset: 0x6FAA90 VA: 0x1806FC490
	public void set_GuideColor(Color value) { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public int get_Guide() { }

	// RVA: 0x6FC500 Offset: 0x6FAB00 VA: 0x1806FC500
	public void set_Guide(int value) { }

	// RVA: 0x6FA8C0 Offset: 0x6F8EC0 VA: 0x1806FA8C0
	private void Start() { }

	// RVA: 0x6F9520 Offset: 0x6F7B20 VA: 0x1806F9520
	private void OnEnable() { }

	// RVA: 0x6F91C0 Offset: 0x6F77C0 VA: 0x1806F91C0
	private void OnDisable() { }

	// RVA: 0x6FAA60 Offset: 0x6F9060 VA: 0x1806FAA60
	public void TogglePlayerFreeze() { }

	// RVA: 0x6F8CD0 Offset: 0x6F72D0 VA: 0x1806F8CD0
	private bool IsPlayerUnfrozen() { }

	// RVA: 0x6F8890 Offset: 0x6F6E90 VA: 0x1806F8890
	public float FovToZoom(float fov) { }

	// RVA: 0x6FBED0 Offset: 0x6FA4D0 VA: 0x1806FBED0
	public float ZoomToFov(float zoom) { }

	// RVA: 0x6FA790 Offset: 0x6F8D90 VA: 0x1806FA790
	public void Save(string name) { }

	// RVA: 0x6FA580 Offset: 0x6F8B80 VA: 0x1806FA580
	public void SaveToFile(string name) { }

	// RVA: 0x6F8900 Offset: 0x6F6F00 VA: 0x1806F8900
	public CameraMan.CameraState GetCurrentCameraSettings() { }

	// RVA: 0x6F9020 Offset: 0x6F7620 VA: 0x1806F9020
	public bool Load(string name) { }

	// RVA: 0x6F6D80 Offset: 0x6F5380 VA: 0x1806F6D80
	public void ApplyState(CameraMan.CameraState savedState) { }

	// RVA: 0x6F9B50 Offset: 0x6F8150 VA: 0x1806F9B50
	public string PrintSaved() { }

	// RVA: 0x6F7050 Offset: 0x6F5650 VA: 0x1806F7050
	public void Clear() { }

	// RVA: 0x6FA6A0 Offset: 0x6F8CA0 VA: 0x1806FA6A0
	private void SaveToPlayerPrefs() { }

	// RVA: 0x6F8E30 Offset: 0x6F7430 VA: 0x1806F8E30
	private void LoadFromPlayerPrefs() { }

	// RVA: 0x6FC230 Offset: 0x6FA830 VA: 0x1806FC230
	private CameraMan.MovementType get_currentMovementType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC220 Offset: 0x6FA820 VA: 0x1806FC220
	public float get_Zoom() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC610 Offset: 0x6FAC10 VA: 0x1806FC610
	private void set_Zoom(float value) { }

	// RVA: 0x6FC1A0 Offset: 0x6FA7A0 VA: 0x1806FC1A0
	public float get_Fov() { }

	// RVA: 0x6FC410 Offset: 0x6FAA10 VA: 0x1806FC410
	public void set_Fov(float value) { }

	// RVA: 0x6FC0D0 Offset: 0x6FA6D0 VA: 0x1806FC0D0
	public static bool get_Active() { }

	// RVA: 0x6FA890 Offset: 0x6F8E90 VA: 0x1806FA890
	public void ShakeView(float amplitude, float frequency, float duration) { }

	// RVA: 0x6FA980 Offset: 0x6F8F80 VA: 0x1806FA980
	public void StopViewShake() { }

	// RVA: 0x6FBC70 Offset: 0x6FA270 VA: 0x1806FBC70
	private void Update() { }

	// RVA: 0x6FA9A0 Offset: 0x6F8FA0 VA: 0x1806FA9A0
	public void ToggleControl(bool state) { }

	// RVA: 0x6FAC10 Offset: 0x6F9210 VA: 0x1806FAC10
	private void UpdateMovement() { }

	// RVA: 0x6F70D0 Offset: 0x6F56D0 VA: 0x1806F70D0
	private void DoControls() { }

	// RVA: 0x6F8AD0 Offset: 0x6F70D0 VA: 0x1806F8AD0
	public float GetDofDistance(BaseEntity target) { }

	// RVA: 0x6F8650 Offset: 0x6F6C50 VA: 0x1806F8650
	public void FocusOnTarget() { }

	// RVA: 0x6FBFE0 Offset: 0x6FA5E0 VA: 0x1806FBFE0
	public void .ctor() { }

	// RVA: 0x6FBF40 Offset: 0x6FA540 VA: 0x1806FBF40
	private static void .cctor() { }

}

public struct CameraMan.CameraState // TypeDefIndex: 9141
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 rotation; // 0xC
	public float zoom; // 0x18
	public float dof; // 0x1C

}

private enum CameraMan.MovementType // TypeDefIndex: 9142
{	// Fields
	public int value__; // 0x0
	public const CameraMan.MovementType Free = 0;
	public const CameraMan.MovementType Target = 1;
	public const CameraMan.MovementType LookAtPlayer = 2;

}

