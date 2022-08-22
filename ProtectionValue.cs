public class ProtectionValue : MonoBehaviour, IClothingChanged // TypeDefIndex: 11044
{	// Fields
	public CanvasGroup group; // 0x18
	public TextMeshProUGUI text; // 0x20
	public DamageType damageType; // 0x28
	public bool selectedItem; // 0x2C
	public bool displayBaseProtection; // 0x2D

	// Methods

	// RVA: 0x69A7D0 Offset: 0x698DD0 VA: 0x18069A7D0
	private void OnEnable() { }

	// RVA: 0x69A720 Offset: 0x698D20 VA: 0x18069A720
	private void OnDisable() { }

	// RVA: 0x69A530 Offset: 0x698B30 VA: 0x18069A530 Slot: 4
	public void OnClothingChanged() { }

	// RVA: 0x69ADC0 Offset: 0x6993C0 VA: 0x18069ADC0
	public void UpdateFromItem(Item item) { }

	// RVA: 0x69A180 Offset: 0x698780 VA: 0x18069A180
	public float GetProtectionForArea(HitArea area) { }

	// RVA: 0x69AA10 Offset: 0x699010 VA: 0x18069AA10
	public void UpdateFromArea(HitArea area) { }

	// RVA: 0x69A850 Offset: 0x698E50 VA: 0x18069A850
	public void SetValue(float val) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

