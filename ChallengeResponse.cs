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

	// RVA: 0x1AB3720 Offset: 0x1AB1D20 VA: 0x181AB3720
	public void .ctor() { }

	// RVA: 0x1AB37A0 Offset: 0x1AB1DA0 VA: 0x181AB37A0
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1AB2E40 Offset: 0x1AB1440 VA: 0x181AB2E40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AB3AF0 Offset: 0x1AB20F0 VA: 0x181AB3AF0
	public void set_Password(string value) { }

	// RVA: 0x1AB39F0 Offset: 0x1AB1FF0 VA: 0x181AB39F0
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1AB3910 Offset: 0x1AB1F10 VA: 0x181AB3910
	public byte[] get_LM() { }

	// RVA: 0x1AB3980 Offset: 0x1AB1F80 VA: 0x181AB3980
	public byte[] get_NT() { }

	// RVA: 0x1AB2D20 Offset: 0x1AB1320 VA: 0x181AB2D20 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AB2DD0 Offset: 0x1AB13D0 VA: 0x181AB2DD0
	private void Dispose(bool disposing) { }

	// RVA: 0x1AB2F80 Offset: 0x1AB1580 VA: 0x181AB2F80
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1AB32F0 Offset: 0x1AB18F0 VA: 0x181AB32F0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB31A0 Offset: 0x1AB17A0 VA: 0x181AB31A0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB3670 Offset: 0x1AB1C70 VA: 0x181AB3670
	private static void .cctor() { }

}

