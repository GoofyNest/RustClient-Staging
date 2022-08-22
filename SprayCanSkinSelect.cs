public class SprayCanSkinSelect : UIDialog // TypeDefIndex: 10911
{	// Fields
	public IconSkinPicker skinPicker; // 0x30
	private Action<bool, int> onSkinSelected; // 0x38
	private ItemBlueprint cachedBlueprint; // 0x40
	private BaseEntity targetEntity; // 0x48

	// Methods

	// RVA: 0xA82020 Offset: 0xA80620 VA: 0x180A82020
	private void Update() { }

	// RVA: 0xA81EA0 Offset: 0xA804A0 VA: 0x180A81EA0
	public void Setup(ItemBlueprint blueprint, SprayCan spray, BaseEntity ent, Action<bool, int> callback) { }

	// RVA: 0xA81F80 Offset: 0xA80580 VA: 0x180A81F80
	private void SkinChangedEvent() { }

	// RVA: 0xA81E70 Offset: 0xA80470 VA: 0x180A81E70 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

