public class ValidationResult // TypeDefIndex: 1737
{	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x1AC6890 Offset: 0x1AC4E90 VA: 0x181AC6890
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Trusted() { }

	// RVA: 0xF8B3B0 Offset: 0xF899B0 VA: 0x180F8B3B0
	public bool get_UserDenied() { }

}

