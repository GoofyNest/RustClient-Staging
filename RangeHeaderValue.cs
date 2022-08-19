public class RangeHeaderValue : ICloneable // TypeDefIndex: 5804
{	// Fields
	private List<RangeItemHeaderValue> ranges; // 0x10
	private string unit; // 0x18

	// Properties
	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }

	// Methods

	// RVA: 0x10960A0 Offset: 0x10946A0 VA: 0x1810960A0
	public void .ctor() { }

	// RVA: 0x1095E60 Offset: 0x1094460 VA: 0x181095E60
	private void .ctor(RangeHeaderValue source) { }

	// RVA: 0x10960F0 Offset: 0x10946F0 VA: 0x1810960F0
	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Unit() { }

	// RVA: 0x1095380 Offset: 0x1093980 VA: 0x181095380 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1095240 Offset: 0x1093840 VA: 0x181095240 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1095300 Offset: 0x1093900 VA: 0x181095300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10955A0 Offset: 0x1093BA0 VA: 0x1810955A0
	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	// RVA: 0x10953E0 Offset: 0x10939E0 VA: 0x1810953E0 Slot: 3
	public override string ToString() { }

}

