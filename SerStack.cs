internal sealed class SerStack // TypeDefIndex: 1118
{	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x1202C90 Offset: 0x1201290 VA: 0x181202C90
	internal void .ctor(string stackId) { }

	// RVA: 0x1202B50 Offset: 0x1201150 VA: 0x181202B50
	internal void Push(object obj) { }

	// RVA: 0x1202AC0 Offset: 0x12010C0 VA: 0x181202AC0
	internal object Pop() { }

	// RVA: 0x1202980 Offset: 0x1200F80 VA: 0x181202980
	internal void IncreaseCapacity() { }

	// RVA: 0x1202A70 Offset: 0x1201070 VA: 0x181202A70
	internal object Peek() { }

	// RVA: 0x1202A20 Offset: 0x1201020 VA: 0x181202A20
	internal object PeekPeek() { }

	// RVA: 0x1202A10 Offset: 0x1201010 VA: 0x181202A10
	internal bool IsEmpty() { }

}

