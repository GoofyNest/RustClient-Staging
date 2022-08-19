public class TriggerNotify : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10032
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA22240 Offset: 0xA20840 VA: 0x180A22240
	public bool get_HasContents() { }

	// RVA: 0xA220B0 Offset: 0xA206B0 VA: 0x180A220B0 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0xA21FE0 Offset: 0xA205E0 VA: 0x180A21FE0 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0xA221D0 Offset: 0xA207D0 VA: 0x180A221D0 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA21F90 Offset: 0xA20590 VA: 0x180A21F90
	public void .ctor() { }

}

