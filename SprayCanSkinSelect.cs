public class SprayCanSkinSelect : UIDialog // TypeDefIndex: 10911
{	// Fields
	public IconSkinPicker skinPicker; // 0x30
	private Action<bool, int> onSkinSelected; // 0x38
	private ItemBlueprint cachedBlueprint; // 0x40
	private BaseEntity targetEntity; // 0x48

	// Methods

	// RVA: 0xA81B50 Offset: 0xA80150 VA: 0x180A81B50
	private void Update() { }

	// RVA: 0xA819D0 Offset: 0xA7FFD0 VA: 0x180A819D0
	public void Setup(ItemBlueprint blueprint, SprayCan spray, BaseEntity ent, Action<bool, int> callback) { }

	// RVA: 0xA81AB0 Offset: 0xA800B0 VA: 0x180A81AB0
	private void SkinChangedEvent() { }

	// RVA: 0xA819A0 Offset: 0xA7FFA0 VA: 0x180A819A0 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

