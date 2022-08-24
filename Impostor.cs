public class Impostor : MonoBehaviour, IClientComponent // TypeDefIndex: 10681
{	public ImpostorAsset asset; // 0x18
	[HeaderAttribute] // RVA: 0xF0C30 Offset: 0xF0030 VA: 0x1800F0C30
	public GameObject reference; // 0x20
	public float angle; // 0x28
	public int resolution; // 0x2C
	public int padding; // 0x30
	public bool spriteOutlineAsMesh; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ImpostorInstanceData <InstanceData>k__BackingField; // 0x38
	public bool keepTrying; // 0x40

	public ImpostorInstanceData InstanceData { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ImpostorInstanceData get_InstanceData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_InstanceData(ImpostorInstanceData value) { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void InitializeInstanceData() { }

	public void UpdateInstance() { }

	public void .ctor() { }

}

