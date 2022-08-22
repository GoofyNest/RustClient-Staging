internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 1866
{	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1104D00 Offset: 0x1103300 VA: 0x181104D00
	public void .ctor() { }

	// RVA: 0x1104950 Offset: 0x1102F50 VA: 0x181104950 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x1104B30 Offset: 0x1103130 VA: 0x181104B30 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x1104AB0 Offset: 0x11030B0 VA: 0x181104AB0
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x1104970 Offset: 0x1102F70 VA: 0x181104970
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

private sealed class SecureStringHasher.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 1867
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB9AED0 Offset: 0xB994D0 VA: 0x180B9AED0 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0x11015C0 Offset: 0x10FFBC0 VA: 0x1811015C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

