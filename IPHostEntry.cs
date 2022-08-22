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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_HostName() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_HostName(string value) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Aliases(string[] value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IPAddress[] get_AddressList() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0xA548F0 Offset: 0xA52EF0 VA: 0x180A548F0
	public void .ctor() { }

}

