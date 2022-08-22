public class TriggerNotify : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10032
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA22500 Offset: 0xA20B00 VA: 0x180A22500
	public bool get_HasContents() { }

	// RVA: 0xA22370 Offset: 0xA20970 VA: 0x180A22370 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0xA222A0 Offset: 0xA208A0 VA: 0x180A222A0 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0xA22490 Offset: 0xA20A90 VA: 0x180A22490 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA22250 Offset: 0xA20850 VA: 0x180A22250
	public void .ctor() { }

}

