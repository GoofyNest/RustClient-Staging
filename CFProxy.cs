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

	// RVA: 0x12132D0 Offset: 0x12118D0 VA: 0x1812132D0
	private static void .cctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(CFDictionary settings) { }

	// RVA: 0x12130D0 Offset: 0x12116D0 VA: 0x1812130D0
	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	// RVA: 0x12134F0 Offset: 0x1211AF0 VA: 0x1812134F0
	public IntPtr get_AutoConfigurationJavaScript() { }

	// RVA: 0x12135B0 Offset: 0x1211BB0 VA: 0x1812135B0
	public IntPtr get_AutoConfigurationUrl() { }

	// RVA: 0x1213670 Offset: 0x1211C70 VA: 0x181213670
	public string get_HostName() { }

	// RVA: 0x1213740 Offset: 0x1211D40 VA: 0x181213740
	public string get_Password() { }

	// RVA: 0x1213810 Offset: 0x1211E10 VA: 0x181213810
	public int get_Port() { }

	// RVA: 0x12139B0 Offset: 0x1211FB0 VA: 0x1812139B0
	public CFProxyType get_ProxyType() { }

	// RVA: 0x1213A80 Offset: 0x1212080 VA: 0x181213A80
	public string get_Username() { }

}

