internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 1866
{	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1104290 Offset: 0x1102890 VA: 0x181104290
	public void .ctor() { }

	// RVA: 0x1103EE0 Offset: 0x11024E0 VA: 0x181103EE0 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x11040C0 Offset: 0x11026C0 VA: 0x1811040C0 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x1104040 Offset: 0x1102640 VA: 0x181104040
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x1103F00 Offset: 0x1102500 VA: 0x181103F00
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

private sealed class SecureStringHasher.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 1867
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB9AA00 Offset: 0xB99000 VA: 0x180B9AA00 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0x1100B50 Offset: 0x10FF150 VA: 0x181100B50 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

