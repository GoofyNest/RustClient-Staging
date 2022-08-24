public sealed class StateChangedEventArgs : EventArgs // TypeDefIndex: 7145
{	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private string <Message>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private StateChangeType <Type>k__BackingField; // 0x18

	public string Message { get; set; }
	public StateChangeType Type { get; set; }


	internal void .ctor(StateChangeType stateChangeType, string message) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public string get_Message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public StateChangeType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_Type(StateChangeType value) { }

	public override string ToString() { }

}

