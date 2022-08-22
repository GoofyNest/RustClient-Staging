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

	// RVA: 0x1A95220 Offset: 0x1A93820 VA: 0x181A95220
	public static void Create() { }

	// RVA: 0x1A95310 Offset: 0x1A93910 VA: 0x181A95310
	private void Start() { }

	// RVA: 0x1A953A0 Offset: 0x1A939A0 VA: 0x181A953A0
	public void UpdateFrom(BasePlayer player) { }

	// RVA: 0x1A95430 Offset: 0x1A93A30 VA: 0x181A95430
	private void Update() { }

	// RVA: 0x1A95180 Offset: 0x1A93780 VA: 0x181A95180
	private void CleanupLayers() { }

	// RVA: 0x1A95A70 Offset: 0x1A94070 VA: 0x181A95A70
	public void .ctor() { }

	// RVA: 0x1A959E0 Offset: 0x1A93FE0 VA: 0x181A959E0
	private static void .cctor() { }

}

