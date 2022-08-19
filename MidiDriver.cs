public class MidiDriver // TypeDefIndex: 7642
{	// Fields
	private MidiDriver.ChannelState[] _channelArray; // 0x10
	private int _lastFrame; // 0x18
	private bool enabled; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MidiDriver.NoteOnDelegate <noteOnDelegate>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MidiDriver.NoteOffDelegate <noteOffDelegate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MidiDriver.KnobDelegate <knobDelegate>k__BackingField; // 0x30
	private static MidiDriver _instance; // 0x0

	// Properties
	public MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public MidiDriver.KnobDelegate knobDelegate { get; set; }
	public static MidiDriver Instance { get; }

	// Methods

	// RVA: 0x2316890 Offset: 0x2314E90 VA: 0x182316890
	public float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2316720 Offset: 0x2314D20 VA: 0x182316720
	public bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x23167E0 Offset: 0x2314DE0 VA: 0x1823167E0
	public bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2316970 Offset: 0x2314F70 VA: 0x182316970
	public int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x2316A60 Offset: 0x2315060 VA: 0x182316A60
	public float GetKnob(MidiChannel channel, int knobNumber, float defaultValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public MidiDriver.KnobDelegate get_knobDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x23170D0 Offset: 0x23156D0 VA: 0x1823170D0
	private void .ctor() { }

	// RVA: 0x7D0CA0 Offset: 0x7CF2A0 VA: 0x1807D0CA0
	public void ToggleEnabled(bool state) { }

	// RVA: 0x2316620 Offset: 0x2314C20 VA: 0x182316620
	public void ClearOutstandingData() { }

	// RVA: 0x2316B50 Offset: 0x2315150 VA: 0x182316B50
	private void UpdateIfNeeded() { }

	// RVA: 0x2316B90 Offset: 0x2315190 VA: 0x182316B90
	public void Update() { }

	// RVA: 0x23166B0 Offset: 0x2314CB0 VA: 0x1823166B0
	public static extern ulong DequeueIncomingData() { }

	// RVA: 0x2317250 Offset: 0x2315850 VA: 0x182317250
	public static MidiDriver get_Instance() { }

}

private class MidiDriver.ChannelState // TypeDefIndex: 7643
{	// Fields
	public float[] _noteArray; // 0x10
	public Dictionary<int, float> _knobMap; // 0x18

	// Methods

	// RVA: 0x2316290 Offset: 0x2314890 VA: 0x182316290
	public void .ctor() { }

}

public sealed class MidiDriver.NoteOnDelegate : MulticastDelegate // TypeDefIndex: 7644
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x23163C0 Offset: 0x23149C0 VA: 0x1823163C0 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x2317AB0 Offset: 0x23160B0 VA: 0x182317AB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, float velocity, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.NoteOffDelegate : MulticastDelegate // TypeDefIndex: 7645
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A4B680 Offset: 0x1A49C80 VA: 0x181A4B680 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note) { }

	// RVA: 0x2317A20 Offset: 0x2316020 VA: 0x182317A20 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.KnobDelegate : MulticastDelegate // TypeDefIndex: 7646
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x23163C0 Offset: 0x23149C0 VA: 0x1823163C0 Slot: 12
	public virtual void Invoke(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x2316320 Offset: 0x2314920 VA: 0x182316320 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int knobNumber, float knobValue, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

