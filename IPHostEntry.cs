public class IPHostEntry // TypeDefIndex: 2884
{	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_HostName() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_HostName(string value) { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Aliases(string[] value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IPAddress[] get_AddressList() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0xA54DC0 Offset: 0xA533C0 VA: 0x180A54DC0
	public void .ctor() { }

}

