public class SortKey // TypeDefIndex: 733
{	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x1385420 Offset: 0x1383A20 VA: 0x181385420
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x1385B10 Offset: 0x1384110 VA: 0x181385B10
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x1385B90 Offset: 0x1384190 VA: 0x181385B90
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x13855F0 Offset: 0x1383BF0 VA: 0x1813855F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13857A0 Offset: 0x1383DA0 VA: 0x1813857A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1385830 Offset: 0x1383E30 VA: 0x181385830 Slot: 3
	public override string ToString() { }

	// RVA: 0x1385B60 Offset: 0x1384160 VA: 0x181385B60
	internal void .ctor() { }

}

