public class BushEntity : BaseEntity, IPrefabPreProcess // TypeDefIndex: 9673
{	// Fields
	public GameObjectRef prefab; // 0x168
	public bool globalBillboard; // 0x170

	// Methods

	// RVA: 0x6F1CD0 Offset: 0x6F02D0 VA: 0x1806F1CD0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0x6F1BC0 Offset: 0x6F01C0 VA: 0x1806F1BC0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6F1C50 Offset: 0x6F0250 VA: 0x1806F1C50 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x6F1D90 Offset: 0x6F0390 VA: 0x1806F1D90 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x6F1ED0 Offset: 0x6F04D0 VA: 0x1806F1ED0
	public void .ctor() { }

}

