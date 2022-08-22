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

	// RVA: 0x1AB3F10 Offset: 0x1AB2510 VA: 0x181AB3F10
	public void .ctor() { }

	// RVA: 0x1AB3F90 Offset: 0x1AB2590 VA: 0x181AB3F90
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1AB3630 Offset: 0x1AB1C30 VA: 0x181AB3630 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AB42E0 Offset: 0x1AB28E0 VA: 0x181AB42E0
	public void set_Password(string value) { }

	// RVA: 0x1AB41E0 Offset: 0x1AB27E0 VA: 0x181AB41E0
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1AB4100 Offset: 0x1AB2700 VA: 0x181AB4100
	public byte[] get_LM() { }

	// RVA: 0x1AB4170 Offset: 0x1AB2770 VA: 0x181AB4170
	public byte[] get_NT() { }

	// RVA: 0x1AB3510 Offset: 0x1AB1B10 VA: 0x181AB3510 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AB35C0 Offset: 0x1AB1BC0 VA: 0x181AB35C0
	private void Dispose(bool disposing) { }

	// RVA: 0x1AB3770 Offset: 0x1AB1D70 VA: 0x181AB3770
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1AB3AE0 Offset: 0x1AB20E0 VA: 0x181AB3AE0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AB3990 Offset: 0x1AB1F90 VA: 0x181AB3990
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AB3E60 Offset: 0x1AB2460 VA: 0x181AB3E60
	private static void .cctor() { }

}

