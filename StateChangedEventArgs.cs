public sealed class StateChangedEventArgs : EventArgs // TypeDefIndex: 7145
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Message>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private StateChangeType <Type>k__BackingField; // 0x18

	// Properties
	public string Message { get; set; }
	public StateChangeType Type { get; set; }

	// Methods

	// RVA: 0x22E83B0 Offset: 0x22E69B0 VA: 0x1822E83B0
	internal void .ctor(StateChangeType stateChangeType, string message) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public StateChangeType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	private void set_Type(StateChangeType value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 3
	public override string ToString() { }

}

