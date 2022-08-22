public class SearchFilterInput : MonoBehaviour // TypeDefIndex: 9235
{	// Fields
	public GameObject OpenRoot; // 0x18
	public GameObject ClosedRoot; // 0x20
	public RustInput InputField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <CurrentSearchInput>k__BackingField; // 0x30
	public Action<string> OnSearchFilterChanged; // 0x38

	// Properties
	public bool IsOpen { get; }
	public string CurrentSearchInput { get; set; }

	// Methods

	// RVA: 0x4A5FF0 Offset: 0x4A45F0 VA: 0x1804A5FF0
	public bool get_IsOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public string get_CurrentSearchInput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_CurrentSearchInput(string value) { }

	// RVA: 0x4A5FA0 Offset: 0x4A45A0 VA: 0x1804A5FA0
	public void Toggle() { }

	// RVA: 0x4A5EB0 Offset: 0x4A44B0 VA: 0x1804A5EB0
	public void SetOpen(bool state) { }

	// RVA: 0x4A5CD0 Offset: 0x4A42D0 VA: 0x1804A5CD0
	public void Cancel() { }

	// RVA: 0x4A5DD0 Offset: 0x4A43D0 VA: 0x1804A5DD0
	public void OnSearchStringChanged(string newInput) { }

	// RVA: 0x4A5E40 Offset: 0x4A4440 VA: 0x1804A5E40
	public void OnSearchStringSubmit(string newInput) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

