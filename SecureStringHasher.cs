internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 1866
{	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1103FD0 Offset: 0x11025D0 VA: 0x181103FD0
	public void .ctor() { }

	// RVA: 0x1103C20 Offset: 0x1102220 VA: 0x181103C20 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x1103E00 Offset: 0x1102400 VA: 0x181103E00 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x1103D80 Offset: 0x1102380 VA: 0x181103D80
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x1103C40 Offset: 0x1102240 VA: 0x181103C40
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

private sealed class SecureStringHasher.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 1867
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB9A740 Offset: 0xB98D40 VA: 0x180B9A740 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0x1100890 Offset: 0x10FEE90 VA: 0x181100890 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

