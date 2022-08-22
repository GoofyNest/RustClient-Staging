internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 1386
{	// Fields
	private IComparer _comparer; // 0x10
	private IHashCodeProvider _hcp; // 0x18

	// Properties
	internal IComparer Comparer { get; }
	internal IHashCodeProvider HashCodeProvider { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1451DF0 Offset: 0x14503F0 VA: 0x181451DF0
	public int Compare(object a, object b) { }

	// RVA: 0x1451F90 Offset: 0x1450590 VA: 0x181451F90 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x14520F0 Offset: 0x14506F0 VA: 0x1814520F0 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal IComparer get_Comparer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal IHashCodeProvider get_HashCodeProvider() { }

}

internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 3105
{	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x15BE5A0 Offset: 0x15BCBA0 VA: 0x1815BE5A0 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x15BE6B0 Offset: 0x15BCCB0 VA: 0x1815BE6B0 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public IComparer get_Comparer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x15BE760 Offset: 0x15BCD60 VA: 0x1815BE760
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x15BE830 Offset: 0x15BCE30 VA: 0x1815BE830
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}

