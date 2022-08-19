public class ProtectionValue : MonoBehaviour, IClothingChanged // TypeDefIndex: 11044
{	// Fields
	public CanvasGroup group; // 0x18
	public TextMeshProUGUI text; // 0x20
	public DamageType damageType; // 0x28
	public bool selectedItem; // 0x2C
	public bool displayBaseProtection; // 0x2D

	// Methods

	// RVA: 0x69A6C0 Offset: 0x698CC0 VA: 0x18069A6C0
	private void OnEnable() { }

	// RVA: 0x69A610 Offset: 0x698C10 VA: 0x18069A610
	private void OnDisable() { }

	// RVA: 0x69A420 Offset: 0x698A20 VA: 0x18069A420 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x69ACB0 Offset: 0x6992B0 VA: 0x18069ACB0
	public void UpdateFromItem(Item item) { }

	// RVA: 0x69A070 Offset: 0x698670 VA: 0x18069A070
	public float GetProtectionForArea(HitArea area) { }

	// RVA: 0x69A900 Offset: 0x698F00 VA: 0x18069A900
	public void UpdateFromArea(HitArea area) { }

	// RVA: 0x69A740 Offset: 0x698D40 VA: 0x18069A740
	public void SetValue(float val) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

