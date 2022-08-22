public class ChallengeResponse : IDisposable // TypeDefIndex: 1725
{	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1AB3460 Offset: 0x1AB1A60 VA: 0x181AB3460
	public void .ctor() { }

	// RVA: 0x1AB34E0 Offset: 0x1AB1AE0 VA: 0x181AB34E0
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1AB2B80 Offset: 0x1AB1180 VA: 0x181AB2B80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AB3830 Offset: 0x1AB1E30 VA: 0x181AB3830
	public void set_Password(string value) { }

	// RVA: 0x1AB3730 Offset: 0x1AB1D30 VA: 0x181AB3730
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1AB3650 Offset: 0x1AB1C50 VA: 0x181AB3650
	public byte[] get_LM() { }

	// RVA: 0x1AB36C0 Offset: 0x1AB1CC0 VA: 0x181AB36C0
	public byte[] get_NT() { }

	// RVA: 0x1AB2A60 Offset: 0x1AB1060 VA: 0x181AB2A60 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AB2B10 Offset: 0x1AB1110 VA: 0x181AB2B10
	private void Dispose(bool disposing) { }

	// RVA: 0x1AB2CC0 Offset: 0x1AB12C0 VA: 0x181AB2CC0
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1AB3030 Offset: 0x1AB1630 VA: 0x181AB3030
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB2EE0 Offset: 0x1AB14E0 VA: 0x181AB2EE0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB33B0 Offset: 0x1AB19B0 VA: 0x181AB33B0
	private static void .cctor() { }

}

