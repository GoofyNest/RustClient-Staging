public class ColorRow : MaterialRow // TypeDefIndex: 7756
{	// Fields
	public Button Reset; // 0x20
	public Slider Red; // 0x28
	public Slider Green; // 0x30
	public Slider Blue; // 0x38
	private Color Default; // 0x40

	// Properties
	public bool IsDefault { get; }

	// Methods

	// RVA: 0xE73120 Offset: 0xE71720 VA: 0x180E73120
	public void Update() { }

	// RVA: 0xE731E0 Offset: 0xE717E0 VA: 0x180E731E0
	public bool get_IsDefault() { }

	// RVA: 0xE72E80 Offset: 0xE71480 VA: 0x180E72E80 Slot: 4
	public override void Read(Material source, Material def) { }

	// RVA: 0xE73020 Offset: 0xE71620 VA: 0x180E73020
	public void ResetToDefault() { }

	// RVA: 0xE72D30 Offset: 0xE71330 VA: 0x180E72D30
	public void OnChanged() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

