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

	// RVA: 0x6FC2C0 Offset: 0x6FA8C0 VA: 0x1806FC2C0
	public Color get_GuideColor() { }

	// RVA: 0x6FC540 Offset: 0x6FAB40 VA: 0x1806FC540
	public void set_GuideColor(Color value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public int get_Guide() { }

	// RVA: 0x6FC5B0 Offset: 0x6FABB0 VA: 0x1806FC5B0
	public void set_Guide(int value) { }

	// RVA: 0x6FA970 Offset: 0x6F8F70 VA: 0x1806FA970
	private void Start() { }

	// RVA: 0x6F95D0 Offset: 0x6F7BD0 VA: 0x1806F95D0
	private void OnEnable() { }

	// RVA: 0x6F9270 Offset: 0x6F7870 VA: 0x1806F9270
	private void OnDisable() { }

	// RVA: 0x6FAB10 Offset: 0x6F9110 VA: 0x1806FAB10
	public void TogglePlayerFreeze() { }

	// RVA: 0x6F8D80 Offset: 0x6F7380 VA: 0x1806F8D80
	private bool IsPlayerUnfrozen() { }

	// RVA: 0x6F8940 Offset: 0x6F6F40 VA: 0x1806F8940
	public float FovToZoom(float fov) { }

	// RVA: 0x6FBF80 Offset: 0x6FA580 VA: 0x1806FBF80
	public float ZoomToFov(float zoom) { }

	// RVA: 0x6FA840 Offset: 0x6F8E40 VA: 0x1806FA840
	public void Save(string name) { }

	// RVA: 0x6FA630 Offset: 0x6F8C30 VA: 0x1806FA630
	public void SaveToFile(string name) { }

	// RVA: 0x6F89B0 Offset: 0x6F6FB0 VA: 0x1806F89B0
	public CameraMan.CameraState GetCurrentCameraSettings() { }

	// RVA: 0x6F90D0 Offset: 0x6F76D0 VA: 0x1806F90D0
	public bool Load(string name) { }

	// RVA: 0x6F6E30 Offset: 0x6F5430 VA: 0x1806F6E30
	public void ApplyState(CameraMan.CameraState savedState) { }

	// RVA: 0x6F9C00 Offset: 0x6F8200 VA: 0x1806F9C00
	public string PrintSaved() { }

	// RVA: 0x6F7100 Offset: 0x6F5700 VA: 0x1806F7100
	public void Clear() { }

	// RVA: 0x6FA750 Offset: 0x6F8D50 VA: 0x1806FA750
	private void SaveToPlayerPrefs() { }

	// RVA: 0x6F8EE0 Offset: 0x6F74E0 VA: 0x1806F8EE0
	private void LoadFromPlayerPrefs() { }

	// RVA: 0x6FC2E0 Offset: 0x6FA8E0 VA: 0x1806FC2E0
	private CameraMan.MovementType get_currentMovementType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC2D0 Offset: 0x6FA8D0 VA: 0x1806FC2D0
	public float get_Zoom() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6FC6C0 Offset: 0x6FACC0 VA: 0x1806FC6C0
	private void set_Zoom(float value) { }

	// RVA: 0x6FC250 Offset: 0x6FA850 VA: 0x1806FC250
	public float get_Fov() { }

	// RVA: 0x6FC4C0 Offset: 0x6FAAC0 VA: 0x1806FC4C0
	public void set_Fov(float value) { }

	// RVA: 0x6FC180 Offset: 0x6FA780 VA: 0x1806FC180
	public static bool get_Active() { }

	// RVA: 0x6FA940 Offset: 0x6F8F40 VA: 0x1806FA940
	public void ShakeView(float amplitude, float frequency, float duration) { }

	// RVA: 0x6FAA30 Offset: 0x6F9030 VA: 0x1806FAA30
	public void StopViewShake() { }

	// RVA: 0x6FBD20 Offset: 0x6FA320 VA: 0x1806FBD20
	private void Update() { }

	// RVA: 0x6FAA50 Offset: 0x6F9050 VA: 0x1806FAA50
	public void ToggleControl(bool state) { }

	// RVA: 0x6FACC0 Offset: 0x6F92C0 VA: 0x1806FACC0
	private void UpdateMovement() { }

	// RVA: 0x6F7180 Offset: 0x6F5780 VA: 0x1806F7180
	private void DoControls() { }

	// RVA: 0x6F8B80 Offset: 0x6F7180 VA: 0x1806F8B80
	public float GetDofDistance(BaseEntity target) { }

	// RVA: 0x6F8700 Offset: 0x6F6D00 VA: 0x1806F8700
	public void FocusOnTarget() { }

	// RVA: 0x6FC090 Offset: 0x6FA690 VA: 0x1806FC090
	public void .ctor() { }

	// RVA: 0x6FBFF0 Offset: 0x6FA5F0 VA: 0x1806FBFF0
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

