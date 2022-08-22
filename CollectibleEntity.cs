public class CollectibleEntity : BaseEntity, IPrefabPreProcess // TypeDefIndex: 8550
{	// Fields
	public Translate.Phrase itemName; // 0x168
	public ItemAmount[] itemList; // 0x170
	public GameObjectRef pickupEffect; // 0x178
	public float xpScale; // 0x180

	// Methods

	// RVA: 0x57C5A0 Offset: 0x57ABA0 VA: 0x18057C5A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x57C440 Offset: 0x57AA40 VA: 0x18057C440 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x57C690 Offset: 0x57AC90 VA: 0x18057C690 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x57C800 Offset: 0x57AE00 VA: 0x18057C800
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C7C0 Offset: 0x57ADC0 VA: 0x18057C7C0
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

