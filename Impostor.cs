public class Impostor : MonoBehaviour, IClientComponent // TypeDefIndex: 10677
{	// Fields
	public ImpostorAsset asset; // 0x18
	[HeaderAttribute] // RVA: 0xF0900 Offset: 0xEFD00 VA: 0x1800F0900
	public GameObject reference; // 0x20
	public float angle; // 0x28
	public int resolution; // 0x2C
	public int padding; // 0x30
	public bool spriteOutlineAsMesh; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ImpostorInstanceData <InstanceData>k__BackingField; // 0x38
	public bool keepTrying; // 0x40

	// Properties
	public ImpostorInstanceData InstanceData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public ImpostorInstanceData get_InstanceData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	private void set_InstanceData(ImpostorInstanceData value) { }

	// RVA: 0x812580 Offset: 0x810B80 VA: 0x180812580
	private void Awake() { }

	// RVA: 0x812CE0 Offset: 0x8112E0 VA: 0x180812CE0
	private void OnEnable() { }

	// RVA: 0x812BB0 Offset: 0x8111B0 VA: 0x180812BB0
	private void OnDisable() { }

	// RVA: 0x812590 Offset: 0x810B90 VA: 0x180812590
	private void InitializeInstanceData() { }

	// RVA: 0x812E10 Offset: 0x811410 VA: 0x180812E10
	public void UpdateInstance() { }

	// RVA: 0x812E30 Offset: 0x811430 VA: 0x180812E30
	public void .ctor() { }

}

