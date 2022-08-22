public class uiPlayerPreview : SingletonComponent<uiPlayerPreview> // TypeDefIndex: 11205
{	// Fields
	public Camera previewCamera; // 0x18
	public PlayerModel playermodel; // 0x20
	public ReflectionProbe reflectionProbe; // 0x28
	public SegmentMaskPositioning segmentMask; // 0x30
	private static readonly object FalseObject; // 0x0
	private static readonly object TrueObject; // 0x8
	internal BasePlayer needsUpdateFrom; // 0x38
	private PostProcessLayer postProcessLayer; // 0x40
	private bool wasOpen; // 0x48

	// Methods

	// RVA: 0x1A954E0 Offset: 0x1A93AE0 VA: 0x181A954E0
	public static void Create() { }

	// RVA: 0x1A955D0 Offset: 0x1A93BD0 VA: 0x181A955D0
	private void Start() { }

	// RVA: 0x1A95660 Offset: 0x1A93C60 VA: 0x181A95660
	public void UpdateFrom(BasePlayer player) { }

	// RVA: 0x1A956F0 Offset: 0x1A93CF0 VA: 0x181A956F0
	private void Update() { }

	// RVA: 0x1A95440 Offset: 0x1A93A40 VA: 0x181A95440
	private void CleanupLayers() { }

	// RVA: 0x1A95D30 Offset: 0x1A94330 VA: 0x181A95D30
	public void .ctor() { }

	// RVA: 0x1A95CA0 Offset: 0x1A942A0 VA: 0x181A95CA0
	private static void .cctor() { }

}

