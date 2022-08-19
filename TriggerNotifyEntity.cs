public class TriggerNotifyEntity : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10034
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyEntityTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA21FA0 Offset: 0xA205A0 VA: 0x180A21FA0
	public bool get_HasContents() { }

	// RVA: 0xA21D50 Offset: 0xA20350 VA: 0x180A21D50 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA21E20 Offset: 0xA20420 VA: 0x180A21E20 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA21F20 Offset: 0xA20520 VA: 0x180A21F20 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA21F90 Offset: 0xA20590 VA: 0x180A21F90
	public void .ctor() { }

}

