public class ConditionalModel : PrefabAttribute // TypeDefIndex: 9051
{	// Fields
	public GameObjectRef prefab; // 0x98
	public bool onClient; // 0xA0
	public bool onServer; // 0xA1
	public ModelConditionTest[] conditions; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <targetPrefabId>k__BackingField; // 0xB0

	// Properties
	public uint targetPrefabId { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5B0 Offset: 0x2F8BB0 VA: 0x1802FA5B0
	public uint get_targetPrefabId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FA5C0 Offset: 0x2F8BC0 VA: 0x1802FA5C0
	private void set_targetPrefabId(uint value) { }

	// RVA: 0x2FA200 Offset: 0x2F8800 VA: 0x1802FA200 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2FA490 Offset: 0x2F8A90 VA: 0x1802FA490
	public bool RunTests(BaseEntity parent) { }

	// RVA: 0x2FA320 Offset: 0x2F8920 VA: 0x1802FA320
	public GameObject InstantiateSkin(BaseEntity parent) { }

	// RVA: 0x2FA2C0 Offset: 0x2F88C0 VA: 0x1802FA2C0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x2FA550 Offset: 0x2F8B50 VA: 0x1802FA550
	public void .ctor() { }

}

