public class ProtectionValue : MonoBehaviour, IClothingChanged // TypeDefIndex: 11044
{	// Fields
	public CanvasGroup group; // 0x18
	public TextMeshProUGUI text; // 0x20
	public DamageType damageType; // 0x28
	public bool selectedItem; // 0x2C
	public bool displayBaseProtection; // 0x2D

	// Methods

	// RVA: 0x69A760 Offset: 0x698D60 VA: 0x18069A760
	private void OnEnable() { }

	// RVA: 0x69A6B0 Offset: 0x698CB0 VA: 0x18069A6B0
	private void OnDisable() { }

	// RVA: 0x69A4C0 Offset: 0x698AC0 VA: 0x18069A4C0 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x69AD50 Offset: 0x699350 VA: 0x18069AD50
	public void UpdateFromItem(Item item) { }

	// RVA: 0x69A110 Offset: 0x698710 VA: 0x18069A110
	public float GetProtectionForArea(HitArea area) { }

	// RVA: 0x69A9A0 Offset: 0x698FA0 VA: 0x18069A9A0
	public void UpdateFromArea(HitArea area) { }

	// RVA: 0x69A7E0 Offset: 0x698DE0 VA: 0x18069A7E0
	public void SetValue(float val) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

