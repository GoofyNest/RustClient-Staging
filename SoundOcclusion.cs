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
	// RVA: 0x7D0D40 Offset: 0x7CF340 VA: 0x1807D0D40
	public bool get_isOccluded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0DB0 Offset: 0x7CF3B0 VA: 0x1807D0DB0
	private void set_isOccluded(bool value) { }

	// RVA: 0xA7A160 Offset: 0xA78760 VA: 0x180A7A160
	public void Awake() { }

	// RVA: 0xA7A800 Offset: 0xA78E00 VA: 0x180A7A800
	public void Init() { }

	// RVA: 0xA7A920 Offset: 0xA78F20 VA: 0x180A7A920
	public void UpdateOcclusion(bool lerp = False) { }

	// RVA: 0xA7A1D0 Offset: 0xA787D0 VA: 0x180A7A1D0
	public void DoOcclusionCheck() { }

	// RVA: 0xA7AC10 Offset: 0xA79210 VA: 0x180A7AC10
	public void .ctor() { }

}

