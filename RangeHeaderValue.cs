public class RangeHeaderValue : ICloneable // TypeDefIndex: 5804
{	// Fields
	private List<RangeItemHeaderValue> ranges; // 0x10
	private string unit; // 0x18

	// Properties
	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }

	// Methods

	// RVA: 0x1096DD0 Offset: 0x10953D0 VA: 0x181096DD0
	public void .ctor() { }

	// RVA: 0x1096B90 Offset: 0x1095190 VA: 0x181096B90
	private void .ctor(RangeHeaderValue source) { }

	// RVA: 0x1096E20 Offset: 0x1095420 VA: 0x181096E20
	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Unit() { }

	// RVA: 0x10960B0 Offset: 0x10946B0 VA: 0x1810960B0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1095F70 Offset: 0x1094570 VA: 0x181095F70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1096030 Offset: 0x1094630 VA: 0x181096030 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10962D0 Offset: 0x10948D0 VA: 0x1810962D0
	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	// RVA: 0x1096110 Offset: 0x1094710 VA: 0x181096110 Slot: 3
	public override string ToString() { }

}

