public class MLRSMainUI : MonoBehaviour // TypeDefIndex: 9724
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool isFullscreen; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject noAimingModuleModeGO; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject activeModeGO; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MLRSAmmoUI noAimingModuleAmmoUI; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MLRSAmmoUI activeAmmoUI; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MLRSVelocityUI velocityUI; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText titleText; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText usernameText; // 0x50
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase readyStatus; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase realigningStatus; // 0x60
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TokenisedPhrase firingStatus; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RustText statusText; // 0x70
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MapView mapView; // 0x78
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRectEx mapScrollRect; // 0x80
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ScrollRectZoom mapScrollRectZoom; // 0x88
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform mapBaseRect; // 0x90
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform minRangeCircle; // 0x98
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform targetAimRect; // 0xA0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RectTransform trueAimRect; // 0xA8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UILineRenderer connectingLine; // 0xB0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject noTargetCirclePrefab; // 0xB8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform noTargetCircleParent; // 0xC0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition changeTargetSoundDef; // 0xC8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition readyToFireSoundDef; // 0xD0
	private MLRS mlrs; // 0xD8
	private MLRSAmmoUI curAmmoUI; // 0xE0
	private Nullable<bool> hadAimingModule; // 0xE8
	private float world2MapScale; // 0xEC
	private Vector3 mouseStartPos; // 0xF0
	private bool wasReadyToFire; // 0xFC
	private float lastReadyToFireSoundPlayed; // 0x100
	private float readyToFireSoundInterval; // 0x104

	// Methods

	// RVA: 0x5533B0 Offset: 0x5519B0 VA: 0x1805533B0
	public void Init(MLRS mlrs) { }

	// RVA: 0x553CB0 Offset: 0x5522B0 VA: 0x180553CB0
	protected void Start() { }

	// RVA: 0x553BD0 Offset: 0x5521D0 VA: 0x180553BD0
	protected void OnDisable() { }

	// RVA: 0x553E40 Offset: 0x552440 VA: 0x180553E40
	protected void Update() { }

	// RVA: 0x553390 Offset: 0x551990 VA: 0x180553390
	public string GetTitleText() { }

	// RVA: 0x553C90 Offset: 0x552290 VA: 0x180553C90
	public void SetTitleText(string text) { }

	// RVA: 0x553320 Offset: 0x551920 VA: 0x180553320
	public void CentreMap() { }

	// RVA: 0x552B40 Offset: 0x551140 VA: 0x180552B40
	private void ActiveUIUpdateTick() { }

	// RVA: 0x5540F0 Offset: 0x5526F0 VA: 0x1805540F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	private bool <ActiveUIUpdateTick>g__MouseIsOverTheMap|39_0() { }

}

