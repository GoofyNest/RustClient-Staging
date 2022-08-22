public class MidiDriver // TypeDefIndex: 7642
{	// Fields
	private MidiDriver.ChannelState[] _channelArray; // 0x10
	private int _lastFrame; // 0x18
	private bool enabled; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiDriver.NoteOnDelegate <noteOnDelegate>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiDriver.NoteOffDelegate <noteOffDelegate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MidiDriver.KnobDelegate <knobDelegate>k__BackingField; // 0x30
	private static MidiDriver _instance; // 0x0

	// Properties
	public MidiDriver.NoteOnDelegate noteOnDelegate { get; set; }
	public MidiDriver.NoteOffDelegate noteOffDelegate { get; set; }
	public MidiDriver.KnobDelegate knobDelegate { get; set; }
	public static MidiDriver Instance { get; }

	// Methods

	// RVA: 0x2316990 Offset: 0x2314F90 VA: 0x182316990
	public float GetKey(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2316820 Offset: 0x2314E20 VA: 0x182316820
	public bool GetKeyDown(MidiChannel channel, int noteNumber) { }

	// RVA: 0x23168E0 Offset: 0x2314EE0 VA: 0x1823168E0
	public bool GetKeyUp(MidiChannel channel, int noteNumber) { }

	// RVA: 0x2316A70 Offset: 0x2315070 VA: 0x182316A70
	public int[] GetKnobNumbers(MidiChannel channel) { }

	// RVA: 0x2316B60 Offset: 0x2315160 VA: 0x182316B60
	public float GetKnob(MidiChannel channel, int knobNumber, float defaultValue) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public MidiDriver.NoteOnDelegate get_noteOnDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_noteOnDelegate(MidiDriver.NoteOnDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public MidiDriver.NoteOffDelegate get_noteOffDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_noteOffDelegate(MidiDriver.NoteOffDelegate value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public MidiDriver.KnobDelegate get_knobDelegate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	public void set_knobDelegate(MidiDriver.KnobDelegate value) { }

	// RVA: 0x23171D0 Offset: 0x23157D0 VA: 0x1823171D0
	private void .ctor() { }

	// RVA: 0x7D0DB0 Offset: 0x7CF3B0 VA: 0x1807D0DB0
	public void ToggleEnabled(bool state) { }

	// RVA: 0x2316720 Offset: 0x2314D20 VA: 0x182316720
	public void ClearOutstandingData() { }

	// RVA: 0x2316C50 Offset: 0x2315250 VA: 0x182316C50
	private void UpdateIfNeeded() { }

	// RVA: 0x2316C90 Offset: 0x2315290 VA: 0x182316C90
	public void Update() { }

	// RVA: 0x23167B0 Offset: 0x2314DB0 VA: 0x1823167B0
	public static extern ulong DequeueIncomingData() { }

	// RVA: 0x2317350 Offset: 0x2315950 VA: 0x182317350
	public static MidiDriver get_Instance() { }

}

private class MidiDriver.ChannelState // TypeDefIndex: 7643
{	// Fields
	public float[] _noteArray; // 0x10
	public Dictionary<int, float> _knobMap; // 0x18

	// Methods

	// RVA: 0x2316390 Offset: 0x2314990 VA: 0x182316390
	public void .ctor() { }

}

public sealed class MidiDriver.NoteOnDelegate : MulticastDelegate // TypeDefIndex: 7644
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x23164C0 Offset: 0x2314AC0 VA: 0x1823164C0 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x2317BB0 Offset: 0x23161B0 VA: 0x182317BB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, float velocity, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.NoteOffDelegate : MulticastDelegate // TypeDefIndex: 7645
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A4B900 Offset: 0x1A49F00 VA: 0x181A4B900 Slot: 12
	public virtual void Invoke(MidiChannel channel, int note) { }

	// RVA: 0x2317B20 Offset: 0x2316120 VA: 0x182317B20 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int note, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class MidiDriver.KnobDelegate : MulticastDelegate // TypeDefIndex: 7646
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x23164C0 Offset: 0x2314AC0 VA: 0x1823164C0 Slot: 12
	public virtual void Invoke(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x2316420 Offset: 0x2314A20 VA: 0x182316420 Slot: 13
	public virtual IAsyncResult BeginInvoke(MidiChannel channel, int knobNumber, float knobValue, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

