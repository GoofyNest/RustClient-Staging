public class TriggerNotify : TriggerBase, IPrefabPreProcess // TypeDefIndex: 10032
{	// Fields
	public GameObject notifyTarget; // 0x30
	private INotifyTrigger toNotify; // 0x38
	public bool runClientside; // 0x40
	public bool runServerside; // 0x41

	// Properties
	public bool HasContents { get; }

	// Methods

	// RVA: 0xA229F0 Offset: 0xA20FF0 VA: 0x180A229F0
	public bool get_HasContents() { }

	// RVA: 0xA22860 Offset: 0xA20E60 VA: 0x180A22860 Slot: 12
	internal override void OnObjects() { }

	// RVA: 0xA22790 Offset: 0xA20D90 VA: 0x180A22790 Slot: 13
	internal override void OnEmpty() { }

	// RVA: 0xA22980 Offset: 0xA20F80 VA: 0x180A22980 Slot: 15
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA22740 Offset: 0xA20D40 VA: 0x180A22740
	public void .ctor() { }

}

