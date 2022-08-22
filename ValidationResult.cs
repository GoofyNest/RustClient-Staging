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

	// RVA: 0x1AC6990 Offset: 0x1AC4F90 VA: 0x181AC6990
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_Trusted() { }

	// RVA: 0xF8B670 Offset: 0xF89C70 VA: 0x180F8B670
	public bool get_UserDenied() { }

}

