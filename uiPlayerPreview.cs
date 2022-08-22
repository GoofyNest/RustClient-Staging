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

	// RVA: 0x1A81CF0 Offset: 0x1A802F0 VA: 0x181A81CF0
	public static void Create() { }

	// RVA: 0x1A81DE0 Offset: 0x1A803E0 VA: 0x181A81DE0
	private void Start() { }

	// RVA: 0x1A81E70 Offset: 0x1A80470 VA: 0x181A81E70
	public void UpdateFrom(BasePlayer player) { }

	// RVA: 0x1A81F00 Offset: 0x1A80500 VA: 0x181A81F00
	private void Update() { }

	// RVA: 0x1A81C50 Offset: 0x1A80250 VA: 0x181A81C50
	private void CleanupLayers() { }

	// RVA: 0x1A82540 Offset: 0x1A80B40 VA: 0x181A82540
	public void .ctor() { }

	// RVA: 0x1A824B0 Offset: 0x1A80AB0 VA: 0x181A824B0
	private static void .cctor() { }

}

