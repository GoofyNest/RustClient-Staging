internal class CFProxy // TypeDefIndex: 2523
{	// Fields
	private static IntPtr kCFProxyAutoConfigurationJavaScriptKey; // 0x0
	private static IntPtr kCFProxyAutoConfigurationURLKey; // 0x8
	private static IntPtr kCFProxyHostNameKey; // 0x10
	private static IntPtr kCFProxyPasswordKey; // 0x18
	private static IntPtr kCFProxyPortNumberKey; // 0x20
	private static IntPtr kCFProxyTypeKey; // 0x28
	private static IntPtr kCFProxyUsernameKey; // 0x30
	private static IntPtr kCFProxyTypeAutoConfigurationURL; // 0x38
	private static IntPtr kCFProxyTypeAutoConfigurationJavaScript; // 0x40
	private static IntPtr kCFProxyTypeFTP; // 0x48
	private static IntPtr kCFProxyTypeHTTP; // 0x50
	private static IntPtr kCFProxyTypeHTTPS; // 0x58
	private static IntPtr kCFProxyTypeSOCKS; // 0x60
	private CFDictionary settings; // 0x10

	// Properties
	public IntPtr AutoConfigurationJavaScript { get; }
	public IntPtr AutoConfigurationUrl { get; }
	public string HostName { get; }
	public string Password { get; }
	public int Port { get; }
	public CFProxyType ProxyType { get; }
	public string Username { get; }

	// Methods

	// RVA: 0x1213C30 Offset: 0x1212230 VA: 0x181213C30
	private static void .cctor() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(CFDictionary settings) { }

	// RVA: 0x1213A30 Offset: 0x1212030 VA: 0x181213A30
	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	// RVA: 0x1213E50 Offset: 0x1212450 VA: 0x181213E50
	public IntPtr get_AutoConfigurationJavaScript() { }

	// RVA: 0x1213F10 Offset: 0x1212510 VA: 0x181213F10
	public IntPtr get_AutoConfigurationUrl() { }

	// RVA: 0x1213FD0 Offset: 0x12125D0 VA: 0x181213FD0
	public string get_HostName() { }

	// RVA: 0x12140A0 Offset: 0x12126A0 VA: 0x1812140A0
	public string get_Password() { }

	// RVA: 0x1214170 Offset: 0x1212770 VA: 0x181214170
	public int get_Port() { }

	// RVA: 0x1214310 Offset: 0x1212910 VA: 0x181214310
	public CFProxyType get_ProxyType() { }

	// RVA: 0x12143E0 Offset: 0x12129E0 VA: 0x1812143E0
	public string get_Username() { }

}

