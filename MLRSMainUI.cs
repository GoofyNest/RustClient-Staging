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

	// RVA: 0x553340 Offset: 0x551940 VA: 0x180553340
	public void Init(MLRS mlrs) { }

	// RVA: 0x553C40 Offset: 0x552240 VA: 0x180553C40
	protected void Start() { }

	// RVA: 0x553B60 Offset: 0x552160 VA: 0x180553B60
	protected void OnDisable() { }

	// RVA: 0x553DD0 Offset: 0x5523D0 VA: 0x180553DD0
	protected void Update() { }

	// RVA: 0x553320 Offset: 0x551920 VA: 0x180553320
	public string GetTitleText() { }

	// RVA: 0x553C20 Offset: 0x552220 VA: 0x180553C20
	public void SetTitleText(string text) { }

	// RVA: 0x5532B0 Offset: 0x5518B0 VA: 0x1805532B0
	public void CentreMap() { }

	// RVA: 0x552AD0 Offset: 0x5510D0 VA: 0x180552AD0
	private void ActiveUIUpdateTick() { }

	// RVA: 0x554080 Offset: 0x552680 VA: 0x180554080
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x553CD0 Offset: 0x5522D0 VA: 0x180553CD0
	private bool <ActiveUIUpdateTick>g__MouseIsOverTheMap|39_0() { }

}

