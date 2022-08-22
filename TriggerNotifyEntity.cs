public class TriggerNotifyEntity : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10034
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyEntityTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA22750 Offset: 0xA20D50 VA: 0x180A22750
	public bool get_HasContents() { }

	// RVA: 0xA22500 Offset: 0xA20B00 VA: 0x180A22500 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA225D0 Offset: 0xA20BD0 VA: 0x180A225D0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA226D0 Offset: 0xA20CD0 VA: 0x180A226D0 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA22740 Offset: 0xA20D40 VA: 0x180A22740
	public void .ctor() { }

}

