public class SoundOcclusion : MonoBehaviour // TypeDefIndex: 9038
{	// Fields
	public LayerMask occlusionLayerMask; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <isOccluded>k__BackingField; // 0x1C
	private float occlusionAmount; // 0x20
	private Sound sound; // 0x28
	private OnePoleLowpassFilter lowpass; // 0x30
	private SoundModulation.Modulator gainMod; // 0x38
	private Vector3 soundOffset; // 0x40
	private float lastOcclusionCheck; // 0x4C
	private float occlusionCheckInterval; // 0x50
	private Ray ray; // 0x54
	private List<RaycastHit> hits; // 0x70

	// Properties
	public bool isOccluded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C30 Offset: 0x7CF230 VA: 0x1807D0C30
	public bool get_isOccluded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0CA0 Offset: 0x7CF2A0 VA: 0x1807D0CA0
	private void set_isOccluded(bool value) { }

	// RVA: 0xA79EA0 Offset: 0xA784A0 VA: 0x180A79EA0
	public void Awake() { }

	// RVA: 0xA7A540 Offset: 0xA78B40 VA: 0x180A7A540
	public void Init() { }

	// RVA: 0xA7A660 Offset: 0xA78C60 VA: 0x180A7A660
	public void UpdateOcclusion(bool lerp = False) { }

	// RVA: 0xA79F10 Offset: 0xA78510 VA: 0x180A79F10
	public void DoOcclusionCheck() { }

	// RVA: 0xA7A950 Offset: 0xA78F50 VA: 0x180A7A950
	public void .ctor() { }

}

