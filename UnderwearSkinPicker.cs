public class UnderwearSkinPicker : MonoBehaviour // TypeDefIndex: 9249
{	// Fields
	public GameObjectRef pickerIcon; // 0x18
	public GameObject container; // 0x20
	public Action skinChangedEvent; // 0x28
	public Sprite defaultNudeIcon; // 0x30
	public Sprite defaultIconMale; // 0x38
	public Sprite defaultIconFemale; // 0x40

	// Methods

	// RVA: 0xA07650 Offset: 0xA05C50 VA: 0x180A07650
	public void RefreshUnderwear() { }

	// RVA: 0xA07360 Offset: 0xA05960 VA: 0x180A07360
	protected void AddOption(string underwearShortName, string text, bool canUse, Sprite icon) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void OnUnderwearChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}
