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

	// RVA: 0x1213590 Offset: 0x1211B90 VA: 0x181213590
	private static void .cctor() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(CFDictionary settings) { }

	// RVA: 0x1213390 Offset: 0x1211990 VA: 0x181213390
	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	// RVA: 0x12137B0 Offset: 0x1211DB0 VA: 0x1812137B0
	public IntPtr get_AutoConfigurationJavaScript() { }

	// RVA: 0x1213870 Offset: 0x1211E70 VA: 0x181213870
	public IntPtr get_AutoConfigurationUrl() { }

	// RVA: 0x1213930 Offset: 0x1211F30 VA: 0x181213930
	public string get_HostName() { }

	// RVA: 0x1213A00 Offset: 0x1212000 VA: 0x181213A00
	public string get_Password() { }

	// RVA: 0x1213AD0 Offset: 0x12120D0 VA: 0x181213AD0
	public int get_Port() { }

	// RVA: 0x1213C70 Offset: 0x1212270 VA: 0x181213C70
	public CFProxyType get_ProxyType() { }

	// RVA: 0x1213D40 Offset: 0x1212340 VA: 0x181213D40
	public string get_Username() { }

}

