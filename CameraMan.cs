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

	// RVA: 0x6FC1B0 Offset: 0x6FA7B0 VA: 0x1806FC1B0
	public Color get_GuideColor() { }

	// RVA: 0x6FC430 Offset: 0x6FAA30 VA: 0x1806FC430
	public void set_GuideColor(Color value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public int get_Guide() { }

	// RVA: 0x6FC4A0 Offset: 0x6FAAA0 VA: 0x1806FC4A0
	public void set_Guide(int value) { }

	// RVA: 0x6FA860 Offset: 0x6F8E60 VA: 0x1806FA860
	private void Start() { }

	// RVA: 0x6F94C0 Offset: 0x6F7AC0 VA: 0x1806F94C0
	private void OnEnable() { }

	// RVA: 0x6F9160 Offset: 0x6F7760 VA: 0x1806F9160
	private void OnDisable() { }

	// RVA: 0x6FAA00 Offset: 0x6F9000 VA: 0x1806FAA00
	public void TogglePlayerFreeze() { }

	// RVA: 0x6F8C70 Offset: 0x6F7270 VA: 0x1806F8C70
	private bool IsPlayerUnfrozen() { }

	// RVA: 0x6F8830 Offset: 0x6F6E30 VA: 0x1806F8830
	public float FovToZoom(float fov) { }

	// RVA: 0x6FBE70 Offset: 0x6FA470 VA: 0x1806FBE70
	public float ZoomToFov(float zoom) { }

	// RVA: 0x6FA730 Offset: 0x6F8D30 VA: 0x1806FA730
	public void Save(string name) { }

	// RVA: 0x6FA520 Offset: 0x6F8B20 VA: 0x1806FA520
	public void SaveToFile(string name) { }

	// RVA: 0x6F88A0 Offset: 0x6F6EA0 VA: 0x1806F88A0
	public CameraMan.CameraState GetCurrentCameraSettings() { }

	// RVA: 0x6F8FC0 Offset: 0x6F75C0 VA: 0x1806F8FC0
	public bool Load(string name) { }

	// RVA: 0x6F6D20 Offset: 0x6F5320 VA: 0x1806F6D20
	public void ApplyState(CameraMan.CameraState savedState) { }

	// RVA: 0x6F9AF0 Offset: 0x6F80F0 VA: 0x1806F9AF0
	public string PrintSaved() { }

	// RVA: 0x6F6FF0 Offset: 0x6F55F0 VA: 0x1806F6FF0
	public void Clear() { }

	// RVA: 0x6FA640 Offset: 0x6F8C40 VA: 0x1806FA640
	private void SaveToPlayerPrefs() { }

	// RVA: 0x6F8DD0 Offset: 0x6F73D0 VA: 0x1806F8DD0
	private void LoadFromPlayerPrefs() { }

	// RVA: 0x6FC1D0 Offset: 0x6FA7D0 VA: 0x1806FC1D0
	private CameraMan.MovementType get_currentMovementType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC1C0 Offset: 0x6FA7C0 VA: 0x1806FC1C0
	public float get_Zoom() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC5B0 Offset: 0x6FABB0 VA: 0x1806FC5B0
	private void set_Zoom(float value) { }

	// RVA: 0x6FC140 Offset: 0x6FA740 VA: 0x1806FC140
	public float get_Fov() { }

	// RVA: 0x6FC3B0 Offset: 0x6FA9B0 VA: 0x1806FC3B0
	public void set_Fov(float value) { }

	// RVA: 0x6FC070 Offset: 0x6FA670 VA: 0x1806FC070
	public static bool get_Active() { }

	// RVA: 0x6FA830 Offset: 0x6F8E30 VA: 0x1806FA830
	public void ShakeView(float amplitude, float frequency, float duration) { }

	// RVA: 0x6FA920 Offset: 0x6F8F20 VA: 0x1806FA920
	public void StopViewShake() { }

	// RVA: 0x6FBC10 Offset: 0x6FA210 VA: 0x1806FBC10
	private void Update() { }

	// RVA: 0x6FA940 Offset: 0x6F8F40 VA: 0x1806FA940
	public void ToggleControl(bool state) { }

	// RVA: 0x6FABB0 Offset: 0x6F91B0 VA: 0x1806FABB0
	private void UpdateMovement() { }

	// RVA: 0x6F7070 Offset: 0x6F5670 VA: 0x1806F7070
	private void DoControls() { }

	// RVA: 0x6F8A70 Offset: 0x6F7070 VA: 0x1806F8A70
	public float GetDofDistance(BaseEntity target) { }

	// RVA: 0x6F85F0 Offset: 0x6F6BF0 VA: 0x1806F85F0
	public void FocusOnTarget() { }

	// RVA: 0x6FBF80 Offset: 0x6FA580 VA: 0x1806FBF80
	public void .ctor() { }

	// RVA: 0x6FBEE0 Offset: 0x6FA4E0 VA: 0x1806FBEE0
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

