public class SoundOcclusion : MonoBehaviour // TypeDefIndex: 9038
{	// Fields
	public LayerMask occlusionLayerMask; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C660 Offset: 0x79AC60 VA: 0x18079C660
	public bool get_isOccluded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6D0 Offset: 0x79ACD0 VA: 0x18079C6D0
	private void set_isOccluded(bool value) { }

	// RVA: 0xA7A630 Offset: 0xA78C30 VA: 0x180A7A630
	public void Awake() { }

	// RVA: 0xA7ACD0 Offset: 0xA792D0 VA: 0x180A7ACD0
	public void Init() { }

	// RVA: 0xA7ADF0 Offset: 0xA793F0 VA: 0x180A7ADF0
	public void UpdateOcclusion(bool lerp = False) { }

	// RVA: 0xA7A6A0 Offset: 0xA78CA0 VA: 0x180A7A6A0
	public void DoOcclusionCheck() { }

	// RVA: 0xA7B0E0 Offset: 0xA796E0 VA: 0x180A7B0E0
	public void .ctor() { }

}

