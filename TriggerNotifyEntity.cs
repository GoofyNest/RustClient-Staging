public class TriggerNotifyEntity : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10034
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyEntityTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA22260 Offset: 0xA20860 VA: 0x180A22260
	public bool get_HasContents() { }

	// RVA: 0xA22010 Offset: 0xA20610 VA: 0x180A22010 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA220E0 Offset: 0xA206E0 VA: 0x180A220E0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA221E0 Offset: 0xA207E0 VA: 0x180A221E0 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA22250 Offset: 0xA20850 VA: 0x180A22250
	public void .ctor() { }

}

