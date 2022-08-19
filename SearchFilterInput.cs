public class SearchFilterInput : MonoBehaviour // TypeDefIndex: 9235
{	// Fields
	public GameObject OpenRoot; // 0x18
	public GameObject ClosedRoot; // 0x20
	public RustInput InputField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <CurrentSearchInput>k__BackingField; // 0x30
	public Action<string> OnSearchFilterChanged; // 0x38

	// Properties
	public bool IsOpen { get; }
	public string CurrentSearchInput { get; set; }

	// Methods

	// RVA: 0x4A6060 Offset: 0x4A4660 VA: 0x1804A6060
	public bool get_IsOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public string get_CurrentSearchInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_CurrentSearchInput(string value) { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	public void Toggle() { }

	// RVA: 0x4A5F20 Offset: 0x4A4520 VA: 0x1804A5F20
	public void SetOpen(bool state) { }

	// RVA: 0x4A5D40 Offset: 0x4A4340 VA: 0x1804A5D40
	public void Cancel() { }

	// RVA: 0x4A5E40 Offset: 0x4A4440 VA: 0x1804A5E40
	public void OnSearchStringChanged(string newInput) { }

	// RVA: 0x4A5EB0 Offset: 0x4A44B0 VA: 0x1804A5EB0
	public void OnSearchStringSubmit(string newInput) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

