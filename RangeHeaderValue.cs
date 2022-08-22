public class RangeHeaderValue : ICloneable // TypeDefIndex: 5804
{	// Fields
	private List<RangeItemHeaderValue> ranges; // 0x10
	private string unit; // 0x18

	// Properties
	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }

	// Methods

	// RVA: 0x1096360 Offset: 0x1094960 VA: 0x181096360
	public void .ctor() { }

	// RVA: 0x1096120 Offset: 0x1094720 VA: 0x181096120
	private void .ctor(RangeHeaderValue source) { }

	// RVA: 0x10963B0 Offset: 0x10949B0 VA: 0x1810963B0
	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Unit() { }

	// RVA: 0x1095640 Offset: 0x1093C40 VA: 0x181095640 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1095500 Offset: 0x1093B00 VA: 0x181095500 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10955C0 Offset: 0x1093BC0 VA: 0x1810955C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1095860 Offset: 0x1093E60 VA: 0x181095860
	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	// RVA: 0x10956A0 Offset: 0x1093CA0 VA: 0x1810956A0 Slot: 3
	public override string ToString() { }

}

