internal sealed class SerStack // TypeDefIndex: 1118
{	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x1203330 Offset: 0x1201930 VA: 0x181203330
	internal void .ctor(string stackId) { }

	// RVA: 0x12031F0 Offset: 0x12017F0 VA: 0x1812031F0
	internal void Push(object obj) { }

	// RVA: 0x1203160 Offset: 0x1201760 VA: 0x181203160
	internal object Pop() { }

	// RVA: 0x1203020 Offset: 0x1201620 VA: 0x181203020
	internal void IncreaseCapacity() { }

	// RVA: 0x1203110 Offset: 0x1201710 VA: 0x181203110
	internal object Peek() { }

	// RVA: 0x12030C0 Offset: 0x12016C0 VA: 0x1812030C0
	internal object PeekPeek() { }

	// RVA: 0x12030B0 Offset: 0x12016B0 VA: 0x1812030B0
	internal bool IsEmpty() { }

}

