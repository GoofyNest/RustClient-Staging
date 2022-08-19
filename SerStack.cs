internal sealed class SerStack // TypeDefIndex: 1118
{	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x12029D0 Offset: 0x1200FD0 VA: 0x1812029D0
	internal void .ctor(string stackId) { }

	// RVA: 0x1202890 Offset: 0x1200E90 VA: 0x181202890
	internal void Push(object obj) { }

	// RVA: 0x1202800 Offset: 0x1200E00 VA: 0x181202800
	internal object Pop() { }

	// RVA: 0x12026C0 Offset: 0x1200CC0 VA: 0x1812026C0
	internal void IncreaseCapacity() { }

	// RVA: 0x12027B0 Offset: 0x1200DB0 VA: 0x1812027B0
	internal object Peek() { }

	// RVA: 0x1202760 Offset: 0x1200D60 VA: 0x181202760
	internal object PeekPeek() { }

	// RVA: 0x1202750 Offset: 0x1200D50 VA: 0x181202750
	internal bool IsEmpty() { }

}

