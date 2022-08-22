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
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	private void set_InstanceData(ImpostorInstanceData value) { }

	// RVA: 0x812470 Offset: 0x810A70 VA: 0x180812470
	private void Awake() { }

	// RVA: 0x812BD0 Offset: 0x8111D0 VA: 0x180812BD0
	private void OnEnable() { }

	// RVA: 0x812AA0 Offset: 0x8110A0 VA: 0x180812AA0
	private void OnDisable() { }

	// RVA: 0x812480 Offset: 0x810A80 VA: 0x180812480
	private void InitializeInstanceData() { }

	// RVA: 0x812D00 Offset: 0x811300 VA: 0x180812D00
	public void UpdateInstance() { }

	// RVA: 0x812D20 Offset: 0x811320 VA: 0x180812D20
	public void .ctor() { }

}

