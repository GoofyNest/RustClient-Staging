public struct X509ChainStatus // TypeDefIndex: 2829
{	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }


	internal void .ctor(X509ChainStatusFlags flag) { }

	public X509ChainStatusFlags get_Status() { }

	public void set_Status(X509ChainStatusFlags value) { }

	public void set_StatusInformation(string value) { }

	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

