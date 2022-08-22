public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 303
{	// Fields
	private static readonly StringComparer _invariantCulture; // 0x0
	private static readonly StringComparer _invariantCultureIgnoreCase; // 0x8
	private static readonly StringComparer _ordinal; // 0x10
	private static readonly StringComparer _ordinalIgnoreCase; // 0x18

	// Properties
	public static StringComparer InvariantCultureIgnoreCase { get; }
	public static StringComparer CurrentCultureIgnoreCase { get; }
	public static StringComparer Ordinal { get; }
	public static StringComparer OrdinalIgnoreCase { get; }

	// Methods

	// RVA: 0x18B0810 Offset: 0x18AEE10 VA: 0x1818B0810
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x18B0790 Offset: 0x18AED90 VA: 0x1818B0790
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x18B08D0 Offset: 0x18AEED0 VA: 0x1818B08D0
	public static StringComparer get_Ordinal() { }

	// RVA: 0x18B0870 Offset: 0x18AEE70 VA: 0x1818B0870
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x18B0410 Offset: 0x18AEA10 VA: 0x1818B0410
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x18B0250 Offset: 0x18AE850 VA: 0x1818B0250 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x18B04B0 Offset: 0x18AEAB0 VA: 0x1818B04B0 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x18B0590 Offset: 0x18AEB90 VA: 0x1818B0590 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18B0640 Offset: 0x18AEC40 VA: 0x1818B0640
	private static void .cctor() { }

}

