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
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public ImpostorInstanceData get_InstanceData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	private void set_InstanceData(ImpostorInstanceData value) { }

	// RVA: 0x812B10 Offset: 0x811110 VA: 0x180812B10
	private void Awake() { }

	// RVA: 0x813270 Offset: 0x811870 VA: 0x180813270
	private void OnEnable() { }

	// RVA: 0x813140 Offset: 0x811740 VA: 0x180813140
	private void OnDisable() { }

	// RVA: 0x812B20 Offset: 0x811120 VA: 0x180812B20
	private void InitializeInstanceData() { }

	// RVA: 0x8133A0 Offset: 0x8119A0 VA: 0x1808133A0
	public void UpdateInstance() { }

	// RVA: 0x8133C0 Offset: 0x8119C0 VA: 0x1808133C0
	public void .ctor() { }

}

