public class Type1Message : MessageBase // TypeDefIndex: 1731
{	private string _host; // 0x18
	private string _domain; // 0x20

	public string Domain { set; }
	public string Host { set; }


	public void .ctor() { }

	public void set_Domain(string value) { }

	public void set_Host(string value) { }

	protected override void Decode(byte[] message) { }

	public override byte[] GetBytes() { }

}

