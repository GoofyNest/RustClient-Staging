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

	// RVA: 0x1386060 Offset: 0x1384660 VA: 0x181386060
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x1386750 Offset: 0x1384D50 VA: 0x181386750
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x13867D0 Offset: 0x1384DD0 VA: 0x1813867D0
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x1386230 Offset: 0x1384830 VA: 0x181386230 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x13863E0 Offset: 0x13849E0 VA: 0x1813863E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1386470 Offset: 0x1384A70 VA: 0x181386470 Slot: 3
	public override string ToString() { }

	// RVA: 0x13867A0 Offset: 0x1384DA0 VA: 0x1813867A0
	internal void .ctor() { }

}

