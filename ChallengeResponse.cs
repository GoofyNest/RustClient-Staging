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

	// RVA: 0x1AB3620 Offset: 0x1AB1C20 VA: 0x181AB3620
	public void .ctor() { }

	// RVA: 0x1AB36A0 Offset: 0x1AB1CA0 VA: 0x181AB36A0
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1AB2D40 Offset: 0x1AB1340 VA: 0x181AB2D40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AB39F0 Offset: 0x1AB1FF0 VA: 0x181AB39F0
	public void set_Password(string value) { }

	// RVA: 0x1AB38F0 Offset: 0x1AB1EF0 VA: 0x181AB38F0
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1AB3810 Offset: 0x1AB1E10 VA: 0x181AB3810
	public byte[] get_LM() { }

	// RVA: 0x1AB3880 Offset: 0x1AB1E80 VA: 0x181AB3880
	public byte[] get_NT() { }

	// RVA: 0x1AB2C20 Offset: 0x1AB1220 VA: 0x181AB2C20 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AB2CD0 Offset: 0x1AB12D0 VA: 0x181AB2CD0
	private void Dispose(bool disposing) { }

	// RVA: 0x1AB2E80 Offset: 0x1AB1480 VA: 0x181AB2E80
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1AB31F0 Offset: 0x1AB17F0 VA: 0x181AB31F0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB30A0 Offset: 0x1AB16A0 VA: 0x181AB30A0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB3570 Offset: 0x1AB1B70 VA: 0x181AB3570
	private static void .cctor() { }

}

