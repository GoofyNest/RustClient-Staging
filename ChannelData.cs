internal class ChannelData // TypeDefIndex: 1139
{	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0xFDDDF0 Offset: 0xFDC3F0 VA: 0x180FDDDF0
	internal ArrayList get_ServerProviders() { }

	// RVA: 0xFDDD10 Offset: 0xFDC310 VA: 0x180FDDD10
	public ArrayList get_ClientProviders() { }

	// RVA: 0xFDDD80 Offset: 0xFDC380 VA: 0x180FDDD80
	public Hashtable get_CustomProperties() { }

	// RVA: 0xFDD430 Offset: 0xFDBA30 VA: 0x180FDD430
	public void CopyFrom(ChannelData other) { }

	// RVA: 0xFDDC50 Offset: 0xFDC250 VA: 0x180FDDC50
	public void .ctor() { }

}

public class ChannelData // TypeDefIndex: 7409
{	// Fields
	internal GranuleInfo[] Granules; // 0x10
	internal int[] ScaleFactorBits; // 0x18

	// Methods

	// RVA: 0x5DC300 Offset: 0x5DA900 VA: 0x1805DC300
	internal void .ctor() { }

}

